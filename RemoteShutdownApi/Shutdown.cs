using System;
using System.Diagnostics;

namespace RemoteShutdownApi
{
    public class Shutdown
    {
        public Shutdown()
        {
        }

        public async Task Begin()
        {
            await Task.Run(
                () =>
                {
                    var process = new System.Diagnostics.Process();

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "shutdown";
                    startInfo.Arguments = "/r /f /t 0";
                    startInfo.UseShellExecute = true;
                    startInfo.Verb = "runas";
                    process.StartInfo = startInfo;
                    process.Start();
                });
        }
    }
}

