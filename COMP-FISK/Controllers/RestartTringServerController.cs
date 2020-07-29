using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_FISK.Controllers
{
    public static class RestartTringServerController
    {
        public static async Task<bool> RestartServisa()
        {
            if (Process.GetProcessesByName("Tring.Fiscal.Server").Length > 0)
            {
                await UgasiServis();
                await Task.Delay(2000);
                await UpaliServis();
                return await Task.FromResult(true);
            }
            else
            {
                await UpaliServis();
                return await Task.FromResult(false);
            }
        }

        private static Task<bool> UpaliServis()
        {
            Process.Start(@"C:\TRING\Tring.Fiscal.Server.exe");

            if (Process.GetProcessesByName("Tring.Fiscal.Server").Length > 0)
                return Task.FromResult(true);
            else
                return Task.FromResult(false);
        }

        private static Task<bool> UgasiServis()
        {
            Process.GetProcessesByName("Tring.Fiscal.Server")[0].Kill();

            return Task.FromResult(true);
        }
    }
}
