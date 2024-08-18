using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DarknetHaxor
{
    internal static class Aimbot
    {
        internal static void Work()
        {

            while (true)
            {
                if (!Config.AimBot)
                {
                    Thread.Sleep(1);
                    continue;
                }

                if ((WinAPI.GetAsyncKeyState(Config.AimbotKey) & 0x8000) == 0)
                {
                    Thread.Sleep(1);
                    continue;
                }

                Entity target = null;
                float distance = float.MaxValue;

                if (Core.Width == -1 || Core.Height == -1) continue;
                if (!Core.HaveMatrix) continue;

                var screenCenter = new Vector2(Core.Width / 2f, Core.Height / 2f);

                foreach (var entity in Core.Entities.Values)
                {
                    if (entity.IsDead) continue;

                
                    var head2D = W2S.WorldToScreen(Core.CameraMatrix, entity.Head, Core.Width, Core.Height);
                    var root2D = W2S.WorldToScreen(Core.CameraMatrix, entity.Root, Core.Width, Core.Height);

                    if (head2D.X < 1 || head2D.Y < 1) continue;
                    if (root2D.X < 1 || root2D.Y < 1) continue;

                    var playerDistance = Vector3.Distance(Core.LocalMainCamera, entity.Head);

                    if (playerDistance > Config.AimBotMaxDistance) continue;

                    var x = head2D.X - screenCenter.X;
                    var y = head2D.Y - screenCenter.Y;
                    var crosshairDist = (float)Math.Sqrt(x * x + y * y);

                    if (crosshairDist >= distance || crosshairDist == float.MaxValue)
                    {
                        continue;
                    }

                    if (crosshairDist > Config.AimBotFov)
                    {
                        continue;
                    }

                    distance = crosshairDist;
                    target = entity;
                }

                if (target != null)
                {
                    var playerLook = MathUtils.GetRotationToLocation(target.Head, 0.1f, Core.LocalMainCamera);

                    InternalMemory.Write(Core.LocalPlayer + Offsets.AimRotation, playerLook);
                    Thread.Sleep(10);
                }
            }
        }

    }
}
