using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        static void Main(string[] args)
        {
            //for (int row = 0; row < 6; row++)
            //{
            //   for (int col = 0; col < row; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            /*for(int row = 0; row <= 8; row++)
            {
                for(int col = 0; col <= 8; col++)
                {
                    if (row == 0 || row == 8 || row == col || col == 0 || col == 8 || col == 8 - row + 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                 Console.WriteLine();
            }*/

            Console.Write("Enter number: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" row= " + row);

            for (int i = row; i >= 1; i--)
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= row; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            }
        }
    }
