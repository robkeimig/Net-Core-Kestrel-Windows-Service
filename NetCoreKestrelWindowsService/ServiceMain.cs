using System.IO;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

namespace NetCoreKestrelWindowsService
{
    public class ServiceMain
    {
        public static void Main(string[] args)
        {
            var exePath = Process.GetCurrentProcess().MainModule.FileName;
            var directoryPath = Path.GetDirectoryName(exePath);

            var host = new WebHostBuilder()
                        .UseKestrel()
                        .UseContentRoot(directoryPath)
                        .UseStartup<Startup>()
                        .UseUrls("http://+:5000")
                        .Build();

            if (Debugger.IsAttached || args.Contains("--debug"))
            {
                host.Run();
            }
            else
            {
                host.RunAsSampleWebHostService();
            }
        }
    }
}
