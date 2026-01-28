using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_system
{
    public  class Patient
    {
        public string name { get; set; }
        public int age { get; set; }
        public long  id { get; set; }
        public string Gender { get; set; }
        public string Diagonsis { get; set; }

       public void DisplayPatient()
        {
            Console.WriteLine("Name of Patient:" + name);
            Console.WriteLine("age of Patient:" + age);
            Console.WriteLine("id of Patient:" + id);
            Console.WriteLine("Diagonsis of Patient:" + Diagonsis);
            Console.WriteLine("Gender of Patient:" + Gender);
        }
    }
}
