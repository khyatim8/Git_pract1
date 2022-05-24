using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main1(string[] args)
        {

            //string name = "khyati";
            //int a = 123456;
            //Console.WriteLine(name);
            //Console.WriteLine(a);

            /*IF ELSE---
             * int Number = 8;
            Console.WriteLine();
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + "Is a Even Number");
            }
            else
            {
                Console.WriteLine(Number + "Is a Odd Number");
            }*/

            /* IF ELSE IF---
             * int Age = 62 ;
            Console.WriteLine();
            if (Age < 18)
            {
                Console.WriteLine(Age +  "Is not able to Vote");
            }
            else if (Age > 18)
            {
                if (Age > 60)
                {
                    Console.WriteLine(Age + "Is senior citizen");
                }

                Console.WriteLine(Age + "Is able to vote");
            }*/

            /* SWITCH CASE & CONVERT TYPE--
             * Console.Write("Enter value to know the day: ");

             int choice = Convert.ToInt32(Console.ReadLine());
             switch (choice)
             {
                 case 1:
                     Console.WriteLine("Sunday");
                     break;
                 case 2:
                     Console.WriteLine("Monday");
                     break;
                 case 3:
                     Console.WriteLine("Tuesday");
                     break;
                 case 4:
                     Console.WriteLine("Wednesday");
                     break;
                 case 5:
                     Console.WriteLine("Thursday");
                     break;
                 case 6:
                     Console.WriteLine("Friday");
                     break;
                 case 7:
                     Console.WriteLine("Saturday");
                     break;
                 default:
                     Console.WriteLine("Not valid");
                     break;
             }*/
            Console.WriteLine("1-ADD, 2-SUB, 3-DIV, 4-MUL");
            Console.Write("Please select no. of operation you want to perfom: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2 numbers: " + "\n");
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Add: a + b= " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Sub: a - b= " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Div: a / b= " + (a / b));
                    break;
                case 4:
                    Console.WriteLine("Mul: a * b= " + (a * b));
                    break;
                default:
                    Console.WriteLine("Please select valid Number:");
                    break;
            }
        }
    }
}
