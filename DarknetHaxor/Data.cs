using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DarknetHaxor
{
    internal static class Data
    {
        internal static void Work() {
            float backUpSpeed = 1f;
            bool speedOn = false;

            while (true)
            {
                Core.HaveMatrix = false;

                var rBaseGameFacade = InternalMemory.Read<uint>(Offsets.Il2Cpp + Offsets.InitBase, out var baseGameFacade);
                if (!rBaseGameFacade || baseGameFacade == 0) {
                    ResetCache();
                    continue;
                }

                var rGameFacade = InternalMemory.Read<uint>(baseGameFacade, out var gameFacade);
                if (!rGameFacade || gameFacade == 0)
                {
                    ResetCache();
                    continue;
                }

                var rStaticGameFacade = InternalMemory.Read<uint>(gameFacade + Offsets.StaticClass, out var staticGameFacade);
                if (!rStaticGameFacade || staticGameFacade == 0)
                {
                    ResetCache();
                    continue;
                }

                var rCurrentGame = InternalMemory.Read<uint>(staticGameFacade, out var currentGame);
                if (!rCurrentGame || currentGame == 0)
                {
                    ResetCache();
                    continue;
                }

                var rCurrentMatch = InternalMemory.Read<uint>(currentGame + Offsets.CurrentMatch, out var currentMatch);
                if (!rCurrentMatch || currentMatch == 0)
                {
                    ResetCache();
                    continue;
                }


                var rLocalPlayer = InternalMemory.Read<uint>(currentMatch + Offsets.LocalPlayer, out var localPlayer);
                if (!rLocalPlayer || localPlayer == 0)
                {
                    continue;
                }

                Core.LocalPlayer = localPlayer;

                var rMainTransform = InternalMemory.Read<uint>(localPlayer + Offsets.MainCameraTransform, out var mainTransform);
                if (!rMainTransform || mainTransform == 0)
                {
                    continue;
                }

                var rMainTransformPos = Transform.GetPosition(mainTransform, out var mainPos);
                if (rMainTransformPos) {
                    Core.LocalMainCamera = mainPos;
                }

                var rFollowCamera = InternalMemory.Read<uint>(localPlayer + Offsets.FollowCamera, out var followCamera);
                if (!rFollowCamera || followCamera == 0)
                {
                    continue;
                }

                var rCamera = InternalMemory.Read<uint>(followCamera + Offsets.Camera, out var camera);
                if (!rCamera || camera == 0)
                {
                    continue;
                }

                var rCameraBase = InternalMemory.Read<uint>(camera + 0x8, out var cameraBase);
                if (!rCameraBase || cameraBase == 0)
                {
                    continue;
                }

                var rViewMatrix = InternalMemory.Read<Matrix4x4>(cameraBase + Offsets.ViewMatrix, out var viewMatrix);
                if (!rViewMatrix)
                {
                    continue;
                }


                Core.CameraMatrix = viewMatrix;
                Core.HaveMatrix = true;

                var rEntityDictionary = InternalMemory.Read<uint>(currentGame + Offsets.DictionaryEntities, out var entityDictionary);
                if (!rEntityDictionary || entityDictionary == 0)
                {
                    ResetCache();
                    continue;
                }

                var rEntities = InternalMemory.Read<uint>(entityDictionary + 0x14, out var entities);
                if (!rEntities || entities == 0)
                {
                    ResetCache();
                    continue;
                }


                entities = entities + 0x10;

                var rEntitiesCount = InternalMemory.Read<uint>(entityDictionary + 0x18, out var entitiesCount);
                if (!rEntitiesCount || entitiesCount < 1) continue;


                for (int i = 0; i < entitiesCount; i++) {
                    var rEntity = InternalMemory.Read<uint>((ulong)(i * 0x4 + entities), out var entity);

                    if (!rEntity || entity == 0) continue;
                    if (entity == localPlayer) continue;

                    Entity player;

                    if (Core.Entities.TryGetValue(entity, out player)) {
                        if (player.IsTeam == Bool3.True) continue;

                        if (player.IsTeam == Bool3.Unknown) {
                            var rAvatarManager = InternalMemory.Read<uint>(entity + Offsets.AvatarManager, out var avatarManager);

                            if (rAvatarManager && avatarManager != 0) {
                                var rAvatar = InternalMemory.Read<uint>(avatarManager + Offsets.Avatar, out var avatar);

                                if (rAvatar && avatar != 0) {
                                    var rIsVisible = InternalMemory.Read<bool>(avatar + Offsets.Avatar_IsVisible, out var isVisible);

                                    if (rIsVisible && isVisible) {
                                        var rAvatarData = InternalMemory.Read<uint>(avatar + Offsets.Avatar_Data, out var avatarData);

                                        if (rAvatarData && avatarData != 0) {
                                            var rIsTeam = InternalMemory.Read<bool>(avatarData + Offsets.Avatar_Data_IsTeam, out var isTeam);
                                            if (rIsTeam) {
                                                if (isTeam) {
                                                    player.IsTeam = Bool3.True;
                                                } else {
                                                    player.IsTeam = Bool3.False;
                                                    player.IsKnown = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (!player.IsKnown) continue;

                        if (Config.IgnoreKnocked) {
                            if (InternalMemory.Read<uint>(entity + Offsets.Player_ShadowBase, out var shadowBase)) {
                                if (shadowBase != 0) {
                                    if (InternalMemory.Read<int>(shadowBase + Offsets.XPose, out var xpose)) {
                                        player.IsKnocked = xpose == 8;
                                    }
                                }
                            }
                        }

                        var rIsDead = InternalMemory.Read<bool>(entity + Offsets.Player_IsDead, out var isDead);

                        if (rIsDead) {
                            player.IsDead = isDead;
                        }

                        if (Config.ESPName) {
                            var rNameAddr = InternalMemory.Read<uint>(entity + Offsets.Player_Name, out var nameAddr);
                            if (rNameAddr && nameAddr != 0) {
                                var rNameLen = InternalMemory.Read<int>(nameAddr + 0x8, out var nameLen);
                                if (rNameLen) {
                                    if (nameLen > 0) {
                                        var name = InternalMemory.ReadString(nameAddr + 0xC, nameLen);
                                        if (name != "" && player != null) {
                                            player.Name = name;
                                        }
                                    }
                                }
                            }


                            var rDataPool = InternalMemory.Read<uint>(entity + Offsets.Player_Data, out var dataPool);
                            if (rDataPool && dataPool != 0)
                            {
                                var rPoolObj = InternalMemory.Read<uint>(dataPool + 0x8, out var poolObj);
                                if (rPoolObj && poolObj != 0)
                                {
                                    var rPool = InternalMemory.Read<uint>(poolObj + 0x10, out var pool);
                                    if (rPool && pool != 0)
                                    {
                                        var rHealthAddr = InternalMemory.Read<uint>(pool + 0xC, out var healthAddr);
                                        if (rHealthAddr && healthAddr != 0)
                                        {
                                            var rHealth = InternalMemory.Read<short>(healthAddr, out var health);

                                            if (rHealth && player != null)
                                            {
                                                player.Health = health;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                       
                        var rHeadBone = InternalMemory.Read<uint>(entity + (uint)Bones.Head, out var headBone);

                        if (rHeadBone && headBone != 0) {
                            var rHeadTrans = Transform.GetNodePosition(headBone, out var headTransform);

                            if (rHeadTrans) {
                                player.Head = headTransform;
                                player.Distance = Vector3.Distance(mainPos, headTransform);
                            }
                        }

                        var rRootBone = InternalMemory.Read<uint>(entity + (uint)Bones.Root, out var rootBone);
                        if (rRootBone || rootBone != 0) {
                            var rRootTrans = Transform.GetNodePosition(rootBone, out var rootTransform);

                            if (rRootTrans) {
                                player.Root = rootTransform;
                            }
                        }
                    } else {
                        player = new Entity();
                        player.IsTeam = Bool3.Unknown;
                        player.IsKnown = false;
                        player.IsDead = true;
                        player.Health = 0;
                        player.IsKnocked = false;
                        player.Head = Vector3.Zero;
                        player.Root = Vector3.Zero;
                        player.Name = "";
                        player.IsFiring = false;
                        player.isVisible = false;
                        Core.Entities.TryAdd(entity, player);
                        continue;
                    }
                }
                Thread.Sleep(1);
            }
        }

        static void ResetCache() {
            Core.Entities = new();
            InternalMemory.Cache = new();
        }
    }
}
