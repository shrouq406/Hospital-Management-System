using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_system
{
   public  class Doctor
    {
        public string name { get; set; }
        public long ID { get; set; }
        public string special { get; set; }
        public int PatientCount { get; set; }
        public int DoctorID { get;  set; }

        public void DisplayDoctor()
        {
            Console.WriteLine("Name of Doctor:" + name);
            Console.WriteLine("Id Of Doctor:" + ID);
            Console.WriteLine("Speciallization of Doctor:" + special);
            Console.WriteLine("Patient Count:" + PatientCount);
          
        }

    }
}
