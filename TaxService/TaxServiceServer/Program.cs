using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using TaxServiceLibrary;

namespace TaxServiceServer
{
    class Program
    {
        private const string HTTP_ADDRESS = "http://localhost:1488/TaxService";
        private static ServiceHost _host;

        static void Main(string[] args)
        {
            Uri[] uris = { new Uri(HTTP_ADDRESS) };

            _host = new ServiceHost(typeof(TaxService), uris);

            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            _host.Description.Behaviors.Add(behavior);

            BasicHttpBinding httpBinding = new BasicHttpBinding();
            httpBinding.MaxReceivedMessageSize = 2100000000;
            _host.AddServiceEndpoint(typeof(ITaxService), httpBinding, HTTP_ADDRESS);
            _host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

            _host.Open();

            Console.WriteLine("Server is running. Press any key to stop it.");
            Console.ReadKey();
        }
    }
}
