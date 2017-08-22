using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;
using System.ServiceProcess;

namespace NetCoreKestrelWindowsService
{
    public static class SampleWebHostServiceExtensions
    {
        public static void RunAsSampleWebHostService(this IWebHost host)
        {
            var webHostService = new SampleWebHostService(host);
            ServiceBase.Run(webHostService);
        }
    }

    internal class SampleWebHostService : WebHostService
    {
        public SampleWebHostService(IWebHost host) : base(host)
        {
        }

        protected override void OnStarting(string[] args)
        {
            base.OnStarting(args);
        }

        protected override void OnStarted()
        {
            base.OnStarted();
        }

        protected override void OnStopping()
        {
            base.OnStopping();
        }
    }
}
