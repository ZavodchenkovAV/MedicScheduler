using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MS.DataModel;

namespace MS.WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            using(MedicSchedulerContext context = new MedicSchedulerContext())
            {
                Patient patient1 = new Patient {PolicyId = 1,Name = "Ivan", Surname = "Ivanov",BirthDate = new DateTime(1950,5,6)};
                Patient patient2 = new Patient { PolicyId = 2, Name = "Alex", Surname = "Alexeev", BirthDate = new DateTime(1985, 11, 26) };

                // добавляем их в бд
                context.Patients.Add(patient1);
                context.Patients.Add(patient2);
                context.SaveChanges();
            }
        }
    }
}
