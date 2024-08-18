using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;
using static DarknetHaxor.WinAPI;

namespace DarknetHaxor {
    internal class ESP : ClickableTransparentOverlay.Overlay {

      

       
        protected override unsafe void Render() {
            if (!Core.HaveMatrix) return;

            CreateHandle();

            var tmp = Core.Entities;

            foreach (var entity in tmp.Values) {
                if (entity.IsDead || !entity.IsKnown) continue;
                var dist = Vector3.Distance(Core.LocalMainCamera, entity.Head);

                if (dist > 100) continue;

                var headScreenPos = W2S.WorldToScreen(Core.CameraMatrix, entity.Head, Core.Width, Core.Height);
                var bottomScreenPos = W2S.WorldToScreen(Core.CameraMatrix, entity.Root, Core.Width, Core.Height);

                if (headScreenPos.X < 1 || headScreenPos.Y < 1) continue;
                if (bottomScreenPos.X < 1 || bottomScreenPos.Y < 1) continue;

                float CornerHeight = Math.Abs(headScreenPos.Y - bottomScreenPos.Y);
                float CornerWidth = (float)(CornerHeight * 0.65);

                if (Config.ESPLine) {
                    ImGui.GetBackgroundDrawList().AddLine(new Vector2(Core.Width / 2f, 0f), headScreenPos, ColorToUint32(Config.ESPLineColor), 1f);
                }

                if (Config.ESPBox) {
                    uint boxColor = ColorToUint32(Config.ESPBoxColor);
                    Draw3dBox(headScreenPos.X - (CornerWidth / 2), headScreenPos.Y, CornerWidth, CornerHeight, boxColor, 1f);
                }

                if (Config.ESPName) {
                    if (entity.Name == "")
                        entity.Name = "BOT";
                    ImGui.GetForegroundDrawList().AddText(new Vector2(headScreenPos.X - (CornerWidth / 2), headScreenPos.Y - 20), ColorToUint32(Config.ESPNameColor), entity.Name + $"({MathF.Round(Vector3.Distance(Core.LocalMainCamera, entity.Head))}m)");
                }

                if (Config.ESPHealth) {
                    
                    DrawHealthBar(entity.Health, 200, headScreenPos.X - (CornerWidth / 2), headScreenPos.Y - 40, CornerHeight);
                }
            }
        }

     
        public void DrawCorneredBox(float X, float Y, float W, float H, uint color, float thickness)
        {
            var vList = ImGui.GetForegroundDrawList();

            float lineW = W / 3;
            float lineH = H / 3;

            vList.AddLine(new Vector2(X, Y - thickness / 2), new Vector2(X, Y + lineH), color, thickness);
            vList.AddLine(new Vector2(X - thickness / 2, Y), new Vector2(X + lineW, Y), color, thickness);
            vList.AddLine(new Vector2(X + W - lineW, Y), new Vector2(X + W + thickness / 2, Y), color, thickness);
            vList.AddLine(new Vector2(X + W, Y - thickness / 2), new Vector2(X + W, Y + lineH), color, thickness);
            vList.AddLine(new Vector2(X, Y + H - lineH), new Vector2(X, Y + H + thickness / 2), color, thickness);
            vList.AddLine(new Vector2(X - thickness / 2, Y + H), new Vector2(X + lineW, Y + H), color, thickness);
            vList.AddLine(new Vector2(X + W - lineW, Y + H), new Vector2(X + W + thickness / 2, Y + H), color, thickness);
            vList.AddLine(new Vector2(X + W, Y + H - lineH), new Vector2(X + W, Y + H + thickness / 2), color, thickness);
        }

        public void Draw3dBox(float X, float Y, float W, float H, uint color, float thickness)
        {

            var vList = ImGui.GetForegroundDrawList();

            Vector3[] screentions = new Vector3[]
            {
        new Vector3(X, Y, 0),                // Top-left front
        new Vector3(X, Y + H, 0),            // Bottom-left front
        new Vector3(X + W, Y + H, 0),        // Bottom-right front
        new Vector3(X + W, Y, 0),            // Top-right front
        new Vector3(X, Y, -W),               // Top-left back
        new Vector3(X, Y + H, -W),           // Bottom-left back
        new Vector3(X + W, Y + H, -W),       // Bottom-right back
        new Vector3(X + W, Y, -W)            // Top-right back
            };

            // Draw front face
            vList.AddLine(new Vector2(screentions[0].X, screentions[0].Y), new Vector2(screentions[1].X, screentions[1].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[1].X, screentions[1].Y), new Vector2(screentions[2].X, screentions[2].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[2].X, screentions[2].Y), new Vector2(screentions[3].X, screentions[3].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[3].X, screentions[3].Y), new Vector2(screentions[0].X, screentions[0].Y), color, thickness);

            // Draw back face
            vList.AddLine(new Vector2(screentions[4].X, screentions[4].Y), new Vector2(screentions[5].X, screentions[5].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[5].X, screentions[5].Y), new Vector2(screentions[6].X, screentions[6].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[6].X, screentions[6].Y), new Vector2(screentions[7].X, screentions[7].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[7].X, screentions[7].Y), new Vector2(screentions[4].X, screentions[4].Y), color, thickness);

            // Draw connecting lines
            vList.AddLine(new Vector2(screentions[0].X, screentions[0].Y), new Vector2(screentions[4].X, screentions[4].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[1].X, screentions[1].Y), new Vector2(screentions[5].X, screentions[5].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[2].X, screentions[2].Y), new Vector2(screentions[6].X, screentions[6].Y), color, thickness);
            vList.AddLine(new Vector2(screentions[3].X, screentions[3].Y), new Vector2(screentions[7].X, screentions[7].Y), color, thickness);

        }

        public void DrawHealthBar(short health, short maxHealth, float X, float Y, float height)
        {
            var vList = ImGui.GetForegroundDrawList();
            float healthPercentage = (float)health / maxHealth;
            float barHeight = height * healthPercentage;

            vList.AddRectFilled(new Vector2(X - 5, Y - 5), new Vector2(X + 120, Y + 20), ColorToUint32(Color.Black));

            vList.AddRectFilled(new Vector2(X - 5, Y), new Vector2(X + height, Y + 4), ColorToUint32(Color.White));
            vList.AddRectFilled(new Vector2(X + (height - barHeight), Y ), new Vector2(X + height, Y + 4), ColorToUint32(Color.Red));
        }
        static uint ColorToUint32(Color color) {
            return ImGui.ColorConvertFloat4ToU32(new Vector4(
            (float)(color.R / 255.0),
                (float)(color.G / 255.0),
                (float)(color.B / 255.0),
                (float)(color.A / 255.0)));
        }

        void CreateHandle() {
            RECT rect;
            GetWindowRect(Core.Handle, out rect);
            int x = rect.Left;
            int y = rect.Top;
            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;
            ImGui.SetWindowSize(new Vector2((float)width, (float)height));
            ImGui.SetWindowPos(new Vector2((float)x, (float)y));
            Size = new Size(width, height);
            Position = new Point(x, y);

            Core.Width = width;
            Core.Height = height;
        }
    }
}
