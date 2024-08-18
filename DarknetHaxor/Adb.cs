
using System.Diagnostics;
using System.Text;

namespace DarknetHaxor
{
    internal class Adb
    {
        string _path;
        StringBuilder _builder;
        Process _process;
        internal Adb(string path)
        {
            _path = path;
            _builder = new StringBuilder();
        }

        internal async Task Kill()
        {
            
            await Task.Run(() => {
                ExecuteAdbCommand("kill-server");

                var adbProcesses = Process.GetProcessesByName("HD-Adb");

                foreach (var adbProcess in adbProcesses)
                {
                    adbProcess.Kill();
                    adbProcess.WaitForExit();
                }

                return Task.CompletedTask;
            });
        }
        internal async Task<bool> Start()
        {
            return await Task.Run(() => {
                ExecuteAdbCommand("kill-server");
                ExecuteAdbCommand("devices");

                _process = new Process();
                _process.StartInfo.FileName = _path;
                _process.StartInfo.Arguments = "shell \"getprop ro.secure ; /boot/android/android/system/xbin/bstk/su\"";
                _process.StartInfo.RedirectStandardOutput = true;
                _process.StartInfo.RedirectStandardError = true;
                _process.StartInfo.RedirectStandardInput = true;
                _process.StartInfo.UseShellExecute = false;
                _process.StartInfo.CreateNoWindow = true;
                _process.EnableRaisingEvents = true;
                _process.OutputDataReceived += Receiver;
                _process.ErrorDataReceived += Receiver;

                _process.Start();
                _process.BeginOutputReadLine();
                _process.BeginErrorReadLine();

                _process.StandardInput.AutoFlush = true;

                while (_builder.Length == 0) Thread.Sleep(1);

                return true;
            });
        }

        void Receiver(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
                _builder.AppendLine(e.Data);
        }

        internal async Task<uint> FindModule(string process, string module)
        {
            return await Task.Run(() => {
                _builder.Clear();

                _process.StandardInput.WriteLine($"ps");

                while (_builder.Length == 0) Thread.Sleep(1);

                var pid = "";

                while (string.IsNullOrEmpty(pid))
                {
                    Thread.Sleep(1);

                    var procLines = _builder.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var procLine in procLines)
                    {
                        if (procLine.Contains(process))
                        {
                            var splitted = procLine.Split(' ');
                            var tempLine = procLine.Replace(" ", "");

                            if (!tempLine.StartsWith(splitted[0]))
                                return 1U;

                            var startIndex = splitted[0].Length;

                            pid = tempLine.Substring(startIndex, Math.Min(4, tempLine.Length - startIndex));
                        }
                    }
                }

                _builder.Clear();
                _process.StandardInput.WriteLine($"cat proc/{pid}/maps | grep {module}");

                while (_builder.Length == 0) Thread.Sleep(1);

                var modules = _builder.ToString().Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                var mod = modules[0].Split('-');

                _process.Kill();
                _process.WaitForExit();

                _ = Kill();

            
                return Convert.ToUInt32(mod[0], 16);
            });
        }



        void ExecuteAdbCommand(string command)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _path,
                    Arguments = command,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            proc.WaitForExit();
        }


    }
}
