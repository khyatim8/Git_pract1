using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        static void Main(string[] args)
        {
            /*PALINDROME----
            /*Console.Write("Enter word: ");
            string name = Console.ReadLine();
            string reverse = "";
           
                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + name[i];
                }

                if (reverse == name)
                {
                    Console.Write(name + "is Palindrome");
                }
                else
                {
                    Console.Write(name +"is not Palindrome");
                }
                Console.WriteLine();*/

            /* 2ND HIGHEST NO.----
            int[] ar1 = new int[] { 12, 18, 65, 45, 77};
            int num1 = 0, temp = 0;
            for (int i = 0; i < ar1.Length; i++)
            {
                if (ar1[i] >= num1)
                {
                    temp = num1;
                    num1 = ar1[i];
                }
                else if ((ar1[i] < num1) && (ar1[i] > temp))
                {
                    temp = ar1[i];
                }
            }
            Console.WriteLine("The Largest Number is: " + num1);
            Console.WriteLine("The Second Highest Number is: " + temp);
            Console.WriteLine();
            */

            /* COUNT DUPLICATE NO. USING ARRAY----
            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            int x = 1;                                   
                                                             
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length - 1; j++)  
                                                            
                {
                    if (array[i] == array[j + 1])                
                                                                 
                        x = x + 1;
                }
                Console.WriteLine( array[i] + " repeated " + x + " time " );
                */

            /*MULTIPLY 2 ARRAYS----
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            //int[,] arr3 = new int[2, 2];

            //Input from arr1
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr1[" + row + "," + col + "]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Input from arr2
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine("Please enter the value for arr2[" + row + "," + col + "]: ");
                    arr2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }


            //Output
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write((arr1[row, col] * arr2[row, col]) + "\t");
                }
                Console.WriteLine(); 
            */

            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            //int[,] arr3 = new int[2, 2];

            //Input from arr1
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine("Please enter the value for arr1[" + row + "," + col + "]: ");
                    arr1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix before Transpose");
            //Matrix before Transpose
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    //Console.Write((arr1[row, col]+arr2[row,col])+"\t");
                    Console.Write(arr1[row, col] + "\t");
                }
                Console.WriteLine();
            }

            //process for transpose
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    arr2[col, row] = arr1[row, col];
                }
            }
            Console.WriteLine("Matrix After Transpose");
            //Output
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    //Console.Write((arr1[row, col]+arr2[row,col])+"\t");
                    Console.Write(arr2[row, col] + "\t");
                }
                Console.WriteLine();


            }
        }
    }
}

