using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Convert To integer
            int n = Convert.ToInt32(Console.ReadLine());

            // Create a phoneBook 
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                string name = s[0];
                string phoneNumber = s[1];
                phoneBook.Add(name, phoneNumber);
            }
            while (true)
            {
                string nameToLookUp = Console.ReadLine();
                if (phoneBook.ContainsKey(nameToLookUp))
                {
                    string phoneNumber = phoneBook[nameToLookUp];
                    Console.WriteLine("{0}={1}", nameToLookUp, phoneNumber);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }



        }
    }
}
