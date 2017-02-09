using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Batata;

namespace BatataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!POP POP!!");
            Console.WriteLine("");

            Console.WriteLine("Boys:");            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(PopPop.randomFirstNameMale());
            }
            Console.WriteLine("");

            Console.WriteLine("Girls:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PopPop.randomFirstNameFemale());
            }
            Console.WriteLine("");

            Console.WriteLine("Unisex:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PopPop.randomFirstNameUnisex());
            }
            Console.WriteLine("");

            Console.WriteLine("Fullname:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PopPop.randomFullName());
            }
            Console.WriteLine("");

            Console.WriteLine("Surname:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(PopPop.randomSurname());
            }
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
