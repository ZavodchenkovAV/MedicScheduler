using System;
using System.ServiceModel;
using MS.ServiceContracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS.ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new System.ServiceModel.ServiceHost(typeof(MedicSchedulerService), new Uri("http://localhost:8000/MedicSchedulerService"));
            host.AddServiceEndpoint(typeof(IMedicSchedulerService), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();
            host.Close();
        }
    }
}
