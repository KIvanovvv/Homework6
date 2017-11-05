using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigestInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 3 integers : " );
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("The biggest integers is : ");
            

            
            Console.WriteLine(Math.Max(Math.Max(x, y), z));
        }

      
    }
}

