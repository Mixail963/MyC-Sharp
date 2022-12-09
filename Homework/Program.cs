using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1

{
    internal class Program
    {
        static void Main(string[] args)

        {
            string fName = "Misha Ciap";
            byte age = 40;
            string eMail = "mishaciap@gmail.com";

            float programmingGrades = 89.2F;
            float matematicsGrades = 45.7F;
            float physicsGrades = 90.3F;

            
            Console.WriteLine($"{"Full Name:",20} {fName,20}");
            Console.WriteLine($"{"Age:",20} {age,20}");
            Console.WriteLine($"{"E-Mail:",20} {eMail,20}");
            Console.WriteLine($"{"Programming Grades:",20} {programmingGrades,20}");
            Console.WriteLine($"{"Matematics Grades:",20} {matematicsGrades,20}");
            Console.WriteLine($"{"Physics Grades:",20} {physicsGrades,20}");
            
            /*
            string pattern = "Full Name:{0} \nAge:{1} \nE-mail:{2} \nPogramming Grades:{3} \nMatematics Grades:{4} \nPysics Grades:{5}";
            
            Console.WriteLine(pattern,
                              fName,
                              age,
                              eMail,
                              programmingGrades,
                              matematicsGrades,
                              physicsGrades);
            */
            Console.ReadKey(true);

        }
    }
}
