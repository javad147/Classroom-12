using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    internal class Customer
    {
        static int Instance = 0;
        public Customer()
        {
            Instance++;

        }
        public static void GetInstances() 
        {
            Console.WriteLine(instances);

        }

    }
}
