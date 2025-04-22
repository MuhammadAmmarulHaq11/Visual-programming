using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_and_Global_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            void age()
            {
                int personAge;//Local Variable
                personAge = 21;
                Console.WriteLine(personAge);
            }

            string personName; //Global Variable
            personName = "Ammar-ul-haq";
            Console.WriteLine(personName);
            age();
        }
    }
}
