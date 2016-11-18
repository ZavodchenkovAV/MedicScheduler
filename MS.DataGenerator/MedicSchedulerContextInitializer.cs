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
        private readonly string[] _maleSurnames = new[]
        {"Иванов", "Алексеев", "Петров", "Сидоров", "Холодов", "Пушкин", "Есенин", "Шевченко", "Хацкевич"};
        private readonly string[] _femaleSurnames = new[]
       {"Иванова", "Алексеева", "Петрова", "Сидорова", "Холодова", "Пушкина", "Есенина", "Шевченко", "Хацкевич"};
        private readonly string[] _maleNames = new[]
       {"Иван", "Алексей", "Петр", "Сидор", "Василий", "Егор", "Владимир", "Павел", "Виктор"};
        private readonly string[] _femaleNames = new[]
       {"Мария", "Юлия", "Ульяна", "Галина", "Инна", "Евгения", "Вера", "Надежда", "Любовь"};

        private readonly string[] _specialities = new[]
        {"Терапевт", "Акушер-гинеколог", "Хирург", "Окулист", "Отоларинголог", "Уролог", "Кардиолог", "Стоматалог"};
        protected override void Seed(MedicSchedulerContext context)
        {
            AddPatients(context);
            AddSpecialities(context);
            AddDoctors(context);
            AddAppointments(context);
            context.SaveChanges();
        }

        private void AddPatients(MedicSchedulerContext context)
        {
            Random rand = new Random();
            Console.WriteLine("Add patient");
            for (int i = 0; i < 100; i++)
            {
                var sex = rand.Next(0,1);
                var surname = CreateName(rand, sex, _maleSurnames, _femaleSurnames);
                var name = CreateName(rand, sex, _maleNames, _femaleNames);
                var patient = new Patient
                {
                    Name = name,
                    Surname = surname,
                    BirthDate = CreateDateTime(rand),
                    Sex = (Sex) sex,
                    PolicyNumber = rand.Next(1000000).ToString()
                };
                context.Patients.Add(patient);
                Console.WriteLine($"patient {i}:{patient}");
            }
        }

        private DateTime CreateDateTime(Random rand)
        {
            var year = DateTime.Now.Year - rand.Next(100);
            var month = rand.Next(1, 12);
            int day;
            if (month == 4 || month == 6 || month == 9 || month == 11)
                day = rand.Next(1, 30);
            else if (month == 2)
            {
                if (year % 4 == 0 && year % 100 != 0)
                    day = rand.Next(1, 29);
                else
                    day = rand.Next(1, 28);
            }
            else
                day = rand.Next(1, 31);
            return new DateTime(year, month, day);
        }

        private string CreateName(Random rand, int sex, string[] maleNames, string[] femaleNames)
        {
            return 
                   sex ==
                       0
                           ? maleNames[rand.Next(maleNames.Length - 1)]
                           : femaleNames[rand.Next(femaleNames.Length - 1)];
        }

        private void AddDoctors(MedicSchedulerContext context)
        {
            Random rand = new Random();
            var specCount = context.Specialties.Local.Count;

            for (int i = 0; i < 10; i++)
            {
                var sex = rand.Next(1);
                var surname = CreateName(rand, sex, _maleSurnames, _femaleSurnames);
                var name = CreateName(rand, sex, _maleNames, _femaleNames);
                var doctor = new Doctor
                {
                    Name = name,
                    Surname = surname,
                   Speciality = context.Specialties.Local.ElementAtOrDefault(rand.Next(specCount-1))
                };
                context.Doctors.Add(doctor);
                Console.WriteLine($"doctor {i}:{doctor}");
            }
        }

        private void AddSpecialities(MedicSchedulerContext context)
        {
            foreach (var fspec in _specialities)
            {
                var spec1 = new Speciality { Name = fspec};
                context.Specialties.Add(spec1);
            }
        }
        private void AddAppointments(MedicSchedulerContext context)
        {
            Random rand = new Random();
            var pcount = context.Patients.Local.Count;
            var pdoctor = context.Doctors.Local.Count;
            for (int i = 0; i < 1000; i++)
            {
                var date = DateTime.Now.Date.AddDays(rand.Next(-30, 30));
                var app = new Appointment()
                {
                    Patient = context.Patients.Local.ElementAtOrDefault(rand.Next(pcount - 1)),
                    Doctor = context.Doctors.Local.ElementAtOrDefault(rand.Next(pdoctor - 1)),
                    ReceptionDateTime = new DateTime(date.Year,date.Month,date.Day,rand.Next(8,20),rand.Next(1,60),0) 
                };
                context.Appointments.Add(app);
                Console.WriteLine($"Appointment {i}:{app}");
            }
        }
    }
}
