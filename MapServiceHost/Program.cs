using System;
using System.Configuration;
using System.ServiceModel;
using MapService;
using System.ServiceModel.Description;

namespace MapServiceHost
{
    class Program
    {
        private static readonly string serviceAddress;
        private static bool useProxy;

        static Program()
        {
            serviceAddress = ConfigurationManager.AppSettings["serviceAddress"];
            useProxy = bool.Parse(ConfigurationManager.AppSettings["useProxy"]);
        }

        static void Main(string[] args)
        {
            ServiceHost mapServiceHost = null;
            try
            {
                Uri httpBaseAddress = new Uri(serviceAddress);

                mapServiceHost = new ServiceHost(typeof(MapService.MapService), httpBaseAddress);

                var binding = new BasicHttpBinding();
                binding.MaxReceivedMessageSize = 20000000;
                binding.MaxBufferPoolSize = 20000000;
                binding.MaxBufferSize = 20000000;

                if (useProxy)
                {
                    binding.BypassProxyOnLocal = false;
                    binding.UseDefaultWebProxy = true;
                    binding.ProxyAddress = new Uri("http://127.0.0.1:8888");
                }

                mapServiceHost.AddServiceEndpoint(typeof(IMapService), binding, "");

                ServiceMetadataBehavior serviceBehavior = new ServiceMetadataBehavior();
                serviceBehavior.HttpGetEnabled = true;
                mapServiceHost.Description.Behaviors.Add(serviceBehavior);

                mapServiceHost.Open();
                Console.WriteLine("Service activated at address: {0}", httpBaseAddress);
                if(useProxy)
                {
                    Console.WriteLine("Service is using proxy on http://127.0.0.1:8888 address");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                mapServiceHost = null;
                Console.WriteLine("Error! " + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
