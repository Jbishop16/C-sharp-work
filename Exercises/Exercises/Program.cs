using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            /*Console.WriteLine("Please enter an integer between 1 and 10 if you love Rosie.");
            int result;

            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result > 0 && result < 10)
                {
                    Console.WriteLine("You love Rosie!!");
                }
                else
                {
                    Console.WriteLine("You still love Rosie!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }*/

            //Exercise 2
            /*int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Please enter a number.");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number.");
            num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("This is your higher number:");
                Console.WriteLine(num2);
            }

            else
            {
                Console.WriteLine("This is your higher number:");
                Console.WriteLine(num1);
            }*/
            //Exercise 3
            /*int height = 0;
            int width = 0;
            Console.WriteLine("Please enter the height of the image");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the width of the image");
            width = int.Parse(Console.ReadLine());

            if (height > width)
                Console.WriteLine("The image is portrait.");
            else
                Console.WriteLine("The image is landscape.");*/
             //Exercise 4
            int speed_limit = 0;
            int car_speed = 0;
            int demerits = 0;

            Console.WriteLine("What is the speed limit on this road?");
            speed_limit = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the speed of the car driving by?");
            car_speed = int.Parse(Console.ReadLine());

            if (car_speed <= speed_limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                for (int i = 0; i < 13; i++)
                {
                    if (car_speed > speed_limit)
                    {
                        demerits++;
                        //Console.WriteLine("The driver has {0} demerits.", demerits);
                        speed_limit = speed_limit + 5;
                    }
                }
                Console.WriteLine("The driver has earned {0} demerits.", demerits);
                    if (demerits > 12)
                      {
                            Console.WriteLine("Suspend their license!");
                      }
                    
                
            }


        }
    }
}
