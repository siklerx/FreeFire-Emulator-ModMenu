using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarknetHaxor {
    internal static class UIUtils {
        // 48; 48; 47
        internal static void ElipseControl(Control control, int elipse) {
            var region = WinAPI.CreateRoundRectRgn(0, 0, control.Width, control.Height, elipse, elipse);

            control.Region = Region.FromHrgn(region);
        }

        internal static void MovableForm(Form form) {
            MovableControl(form, form);
        }

        internal static void MovableControl(Control control, Control target) {
            control.MouseDown += delegate (object sender, MouseEventArgs e) {
                if (e.Button == MouseButtons.Left) {
                    WinAPI.ReleaseCapture();
                    WinAPI.SendMessage(target.Handle, WinAPI.WM_NCLBUTTONDOWN, WinAPI.HT_CAPTION, 0);
                }
            };
        }

    }
}
