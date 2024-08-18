using System.Diagnostics;
using System.Text;

namespace DarknetHaxor
{
    public partial class MainForm : Form
    {
        public static Label StatusLbl;
        IntPtr mainHandle;
        public MainForm(IntPtr handle)
        {
            mainHandle = handle;
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            StatusLbl = lblStatus;
            lblDistance.Text = $"Fov Range: {Config.AimBotFov}";
            lblStatus.Text = "Status: Finding Start Address";

            var processes = Process.GetProcessesByName("HD-Player");

            if (processes.Length != 1)
            {
                lblStatus.Text = "Status: Open just one emulator.";
                return;
            }

            var process = processes[0];
            var mainModulePath = Path.GetDirectoryName(process.MainModule.FileName);
            var adbPath = Path.Combine(mainModulePath, "HD-Adb.exe");

            if (!File.Exists(adbPath))
            {
                lblStatus.Text = "Status: Reinstall the emulator.";
                return;
            }


            var adb = new Adb(adbPath);
            await adb.Kill();

            var started = await adb.Start();
            if (!started)
            {
                lblStatus.Text = "Status: Failed to Start ADB";
                return;
            }

            String pkg = "com.dts.freefireth";
            String lib = "libil2cpp.so";

            bool isFreeFireMax = false;
            if (isFreeFireMax)
            {
                pkg = "com.dts.freefiremax";
            }

            var moduleAddr = await adb.FindModule(pkg, lib);
            lblStatus.Text = "Status: Founded Start Address: " + moduleAddr;

            Offsets.Il2Cpp = moduleAddr;
            Core.Handle = FindRenderWindow(mainHandle);

            var esp = new ESP();
            await esp.Start();

            new Thread(Data.Work) { IsBackground = true }.Start();
            new Thread(Aimbot.Work) { IsBackground = true }.Start();

        }

        static IntPtr FindRenderWindow(IntPtr parent)
        {
            IntPtr renderWindow = IntPtr.Zero;
            WinAPI.EnumChildWindows(parent, (hWnd, lParam) =>
            {
                StringBuilder sb = new StringBuilder(256);
                WinAPI.GetWindowText(hWnd, sb, sb.Capacity);
                string windowName = sb.ToString();
                if (!string.IsNullOrEmpty(windowName))
                {
                    if (windowName != "HD-Player")
                    {
                        renderWindow = hWnd;
                    }
                }
                return true;
            }, IntPtr.Zero);

            return renderWindow;
        }


        private void checkAimBot_CheckedChanged(object sender, EventArgs e)
        {
            Config.AimBot = checkAimBot.Checked;
        }

        private void checkESPLines_CheckedChanged(object sender, EventArgs e)
        {
            Config.ESPLine = checkESPLines.Checked;
        }

        private void checkEspBox_CheckedChanged(object sender, EventArgs e)
        {
            Config.ESPBox = checkEspName.Checked;
        }

        private void checkEspName_CheckedChanged(object sender, EventArgs e)
        {
            Config.ESPName = checkBox1.Checked;
        }

        private void trackAimBotDistance_Scroll(object sender, EventArgs e)
        {
            var distance = trackAimBotDistance.Value;

            lblDistance.Text = $"Fov Range: {distance}";

            Config.AimBotFov = distance;
        }
    }
}
