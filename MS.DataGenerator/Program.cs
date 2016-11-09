using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.DataGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            using (MedicSchedulerContext context = new MedicSchedulerContext())
            {
                foreach (var patient in context.Patients)
                {
                    Console.WriteLine($"Surname: {patient.Surname},name:{patient.Name}");
                }
            }
            Console.WriteLine("end");
            Console.ReadLine();
        }
    }
}
