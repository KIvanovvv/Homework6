using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryFormulas
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Chose options : (Triangle,Square,Radians)");

            string izbor = Console.ReadLine();
            if (izbor == "triangle")
            {
                Console.WriteLine("Enter side :" );
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter hight : ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("The area of the triangle is : " + a*(b/2));

            }
            if (izbor == "square")
            {
                Console.WriteLine("Enter side :");
                int a = int.Parse(Console.ReadLine());
               
                Console.WriteLine("The area of the square is : " + a *a);


            }
            if (izbor == "radians")
            {
                Console.WriteLine("Enter the degree you whant to transform in radiants :");
                int a = int.Parse(Console.ReadLine());
                

                Console.WriteLine("The degrees in radiants are =  " + (3.14/180)*a);

            }
        }
    }
}
