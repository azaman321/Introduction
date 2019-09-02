using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

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
            
            

            Cat cat1 = new Cat("SuperSaiyanSwagger",25);
            
            
            Console.WriteLine(cat1.Name + " " + cat1.Age);
            var json = new JavaScriptSerializer().Serialize(cat1);
            Console.WriteLine(json);

            
                        Console.Read();



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
            private string name;
            private int age;
            public Cat(string name, int age)
            {
                this.name = name;
                this.age = age;

            }

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Age
            {
                get => age;
                set => age = value;
            }
            public static object AgeofCat(Cat cat)
            {
                cat.age = cat.age + 5;
                return cat.age;
            }


        }
        
         

        
    }
}
