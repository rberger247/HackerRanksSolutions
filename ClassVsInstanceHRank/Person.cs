using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsInstanceHRank
{
    class Person
    {

        public int Age;
        public Person(int initialAge)
        {
          // Add some more code to run some checks on initialAge
            initialAge = Age;
            if (initialAge < 1)
            {

                Console.WriteLine("Age is not valid, setting age to 0");
                Age = 0;
            }
          

        }

        public void amIOld()
        {
           
            if (this.Age < 13)
            {

                Console.WriteLine("you are young");
            }
            else  if (this.Age >= 13 && this.Age < 18)
            {

                Console.WriteLine("you are a teenager");
            }
            else 
            {
                Console.WriteLine("you are old");
            }

         
        }


        public void yearPasses()
        {
            // Increment the age of the person in here
            Age++;
        }

    }
}
