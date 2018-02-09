using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuperStackHackerRank
{
    class Program
    {
        static void Main(string[] args)
        {         

            int _operations_size = 0;
            _operations_size = Convert.ToInt32(Console.ReadLine());
            string[] _operations = new string[_operations_size];
            string _operations_item;
            for (int _operations_i = 0; _operations_i < _operations_size; _operations_i++)
            {
                _operations_item = Console.ReadLine();
                _operations[_operations_i] = _operations_item;
            }
            
            Solution.Superstack(_operations);
            Console.ReadLine();

        }
    }
}
