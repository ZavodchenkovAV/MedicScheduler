using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS.DataModel;

namespace MS.DataGenerator
{
    public class MedicSchedulerContextInitializer:DropCreateDatabaseAlways<MedicSchedulerContext>
    {
        protected override void Seed(MedicSchedulerContext context)
        {
            AddPatients(context);
            AddSpecialities();
            AddDoctors(context);
            AddAppointments();
            context.SaveChanges();
        }

        private void AddPatients(MedicSchedulerContext context)
        {
            var patient1 = new Patient {Name = "Иван", Surname = "Иванов", BirthDate = new DateTime(1950, 5, 6), Sex = Sex.Male, PolicyNumber = "12345" };
            var patient2 = new Patient {Name = "Алексей", Surname = "Алексеев", BirthDate = new DateTime(1985, 11, 26), Sex = Sex.Male, PolicyNumber = "77845" };
            
            context.Patients.AddRange(new List<Patient>{ patient1,patient2});
        }

        private void AddDoctors(MedicSchedulerContext context)
        {
            var doctor1 = new Doctor{Name = "Sophi",Surname = "Belyaeva"};
            context.Doctors.AddRange(new List<Doctor> {doctor1});
        }

        private void AddSpecialities()
        {
            var spec1 = new Speciality {Name = "Терапевт" };
        }
        private void AddAppointments()
        {

        }
    }
}
