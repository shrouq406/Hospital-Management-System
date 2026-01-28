using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_system
{
     public   class Appointment
    {
        public int AppointmentID { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }

        public void DisplayAppointment()
        {
            Console.WriteLine("Patient name :" + Patient.name);
            Console.WriteLine("Appointment Id:" + AppointmentID);
            Console.WriteLine("Doctor name:" + Doctor.name);
            Console.WriteLine("Date Time:" + Date.ToShortDateString());
                
        }
    }
}
