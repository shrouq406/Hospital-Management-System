
namespace Hospital_system
   
{
    class Program
    {
        static List<Patient> patients = new List<Patient>();
        static List<Doctor> doctors = new List<Doctor>();
        static List<Appointment> appointments = new List<Appointment>();


        static void AddDoctor()
        {
            Doctor d = new Doctor();
            Console.WriteLine("Doctor ID:");
            d.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Name of Doctor:");
            d.name = Console.ReadLine();
            Console.WriteLine("Specialliazation Of Doctor:");
            d.special = Console.ReadLine();
            d.PatientCount = 0;

            doctors.Add(d);
            Console.WriteLine("Doctor Added Successfuly!");
        }
        static void SearchDoctor()
        {
            Console.WriteLine("Enter Doctor speciallization:");
            string spcl = Console.ReadLine();

            foreach (var d in doctors)
            {
                if (d.special.Equals(spcl, StringComparison.OrdinalIgnoreCase))
                {
                    d.DisplayDoctor();
                }
            }
        }

        static void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor Id to delete:");
            int iD = int.Parse(Console.ReadLine());

            Doctor d = doctors.Find(x => x.ID == iD);

            if (d != null)
            {
                doctors.Remove(d);
                Console.WriteLine("Doctor deleted successfully!");

            }
            else
            {
                Console.WriteLine("Doctor not found to delete!");
            }
        }
        static void Displaydoctor()
        {
            UpdatePatientCounts();
            foreach (var d in doctors)
            {
                d.DisplayDoctor();
            }
        }

        static int CaculatePatientCount(int docID)
        {
            int count =0;
            foreach (var a in appointments)
            {
                if (a.Doctor.ID == docID)
                {
                    count++;
                }
            }
            return count;
        }
        static void UpdatePatientCounts()
        {
            foreach (var d in doctors)
            {
                d.PatientCount = CaculatePatientCount(d.DoctorID);
            }
        }

        static void AddPatient()
        {
            Patient p = new Patient();
            Console.WriteLine("Patient Id:");
            p.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Name of Patient:");
            p.name = Console.ReadLine();
            Console.WriteLine("Age of Patient:");
            p.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Gender of Patient:");
            p.Gender = Console.ReadLine();
            Console.WriteLine("Diagnosis of Patient:");
            p.Diagonsis = Console.ReadLine();

            patients.Add(p);
            Console.WriteLine("Patient Added Successfully!");
        }
        static void SearchPatient()
        {
            Console.WriteLine("Enter Patient Id:");
            int Id = int.Parse(Console.ReadLine());
            Patient p = patients.Find(x => x.id == Id);
            if (p != null)
            {
                p.DisplayPatient();
            }
            else
            {
                Console.WriteLine("Patient not found !");
            }
        }
        static void DeletePatient()
        {
            Console.WriteLine("Enter Patient Id to delete:");
            int id = int.Parse(Console.ReadLine());
            Patient p = patients.Find(x => x.id == id);
            if (p != null)
            {
                patients.Remove(p);
                Console.WriteLine("Patient deleted successfully!");

            }
            else
            {
                Console.WriteLine("Patient not found to delete!");
            }
        }
        static void Displaypatient()
        {
            foreach (var p in patients)
            {
                p.DisplayPatient();
            }
        }
        static void BookAppointment()
        {
            Console.WriteLine("Enter Patient Id:");
            int pid = int.Parse(Console.ReadLine());
            Patient p = patients.Find(x => x.id == pid);

            Console.WriteLine("Enter Doctor Id:");
            int did = int.Parse(Console.ReadLine());
            Doctor d = doctors.Find(x => x.ID == did);

            if (d != null && p != null)
            {
                Appointment A = new Appointment
                {
                    AppointmentID = appointments.Count + 1,
                    Patient = p,
                    Doctor = d,
                    Date = DateTime.Now

                };

                appointments.Add(A);
                d.PatientCount++;
                Console.WriteLine("Appointment booked successfully!");
            }
            else
            {
                Console.WriteLine("Patient or Doctor not found!");
            }
        }

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=====================================================");
                Console.WriteLine("========  Welcome To Hospital Management System =====");
                Console.WriteLine("=====================================================");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Book Appointment");
                Console.WriteLine("4. Show All Patients");
                Console.WriteLine("5. Show All Doctors");
                Console.WriteLine("6. Search Patient");
                Console.WriteLine("7. Search Doctor");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Delete Patient");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddPatient(); break;
                    case 2: AddDoctor();  break;
                    case 3: BookAppointment(); break;
                    case 4: Displaypatient();  break; 
                    case 5: Displaydoctor();  break;
                    case 6: SearchPatient(); break;
                    case 7: SearchDoctor();  break;
                    case 8: DeleteDoctor(); break;
                    case 9: DeletePatient(); break;
                    case 0: Console.WriteLine("Exiting..."); break;  
                    default: Console.WriteLine("Invalid choice!");  break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            } while (choice != 0);

        }
    }   
} 