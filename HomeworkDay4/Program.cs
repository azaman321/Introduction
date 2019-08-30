using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDay4
{
    class Program
    {
        static void Main(string[] args)
        {
            Special casem = new Special();
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int value = casem.intgera(num1, num2, num3,  out int answer);
            Console.WriteLine($"Addition is {answer}");
            
            Console.Read();

            //Cat cat1 = new Cat();


        }

        class Special
        {
            public int intgera(int num1, int num2, int num3, out int answer)
            {
                
                 
                answer = num1 + num2 + num3;
                int product = num1 * num2 * num3;
                Console.WriteLine($"product is {product}");
                return product;


            } 
        }

        class Cat
        {
            string name;
            int age;
            Cat(string name, int age)
            {
                name = "Tibby";
                age = 2;

            }
           
        }
        class Method {
            public static void age() {
            }

        }
    }
}
