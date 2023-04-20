using System;
using System.Linq;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Print Multiples of num 4 from 0 to 100 [for loop] مضاعفات الرقم 4   
            //int a, i;
            //Console.WriteLine("Multiples of 4 are : ");
            //for (i = 1; i <= 100; i++)
            //{
            //    a = i % 4;
            //    if (a == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            ////    2.Calculate multiplication of 10 numbers givin by user[for loop].
            //int Mult = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Enter Number");
            //    int Num = int.Parse(Console.ReadLine());
            //    Mult *= Num;


            //}
            //Console.WriteLine(" Number Is :" + Mult);
            ////    //3. Print ASCII code for all char from 0-255 [for loop] 
            ////    for (int i = 0; i <= 255; i++)
            ////    {

            ////        Console.WriteLine("ASCII value of " + i + " = " + (char)i);
            ////    }
            ////    //4. Get numbers from user until total reaches 100 [while]  3  50 27 20 
            ////    int i = 0;
            ////    while (i < 100)
            ////    {
            ////        Console.WriteLine("Enter Number");
            ////        int A = int.Parse(Console.ReadLine());
            ////        if (A > 100)
            ////        {
            ////            Console.WriteLine("Error");
            ////        }
            ////        else if (A == 100)
            ////        {
            ////            i = 100;
            ////        }
            ////        else
            ////        {

            ////            i = A + i;
            ////            if (i > 100)
            ////            {
            ////                Console.WriteLine("Error");
            ////            }
            ////            else
            ////            {
            ////                Console.WriteLine("The Total Is :" + i);
            ////            }

            ////        }

            ////    }

            ////    //5.Print ASCII code a char from user until user press x[do while] 
            ////    int i = 0;
            ////    do
            ////    {
            ////        Console.WriteLine("Enter char To convert it into ASCII");
            ////        ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            ////        Console.WriteLine("\n");
            ////        i = consoleKeyInfo.KeyChar;
            ////        Console.WriteLine(i);

            ////    }
            ////    while (i != 'x');


            //6. Print simple menu again inside do while.
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("-Prodeuct :" + i);
            //    i++;
            //} while (i < 5);

            //////Arrays:
            ////    1 - Write a program to get sum of 1 student grades and get average
            //and Greatest num then print message if "Success" or "Fail"
            //Console.WriteLine("Enter Number Of Subjects");
            //int N_Subject = int.Parse(Console.ReadLine());
            //int[] Grades = new int[N_Subject];
            //int sum = 0;
            //for (int i = 0; i < Grades.Length; i++)
            //{
            //    Console.WriteLine($"Enter Grades : {i + 1}");
            //    Grades[i] = int.Parse(Console.ReadLine());
            //    sum += Grades[i];
            //}
            //Console.WriteLine("Grade Sum");
            //Console.WriteLine(sum);
            //Console.WriteLine("The Highest Grade ");
            //Console.WriteLine(Grades.Max());
            //Console.WriteLine("Grade Average");
            //Console.WriteLine((sum / N_Subject));
            //if (sum > (N_Subject * 50))
            //    Console.WriteLine("Success");
            //else
            //    Console.WriteLine("Fail");

            //////2 - For 1D array , Try Resize and Delete by Shifting
            //Console.WriteLine("Enter Size :");
            //int size = int.Parse(Console.ReadLine());

            //int[] Temp = new int[size + 3];
            //for (int i = 0; i < Grades.Length; i++)
            //{
            //    Temp[i] = Grades[i];
            //}
            //Grades = Temp;
            //Console.WriteLine(Grades[5]);
            //create and initialize array
                string[] myarray = {"C#", "Java", "C++", "Python",
                                 "HTML", "CSS", "JavaScript"};

            //    // Display original array before Resize
            Console.WriteLine("Original Array:");

            foreach (string i in myarray)
            {
                Console.WriteLine(i);
            }

            int len = myarray.Length;
            Console.WriteLine("Length of myarray: " + len);
            Console.WriteLine();

            // Resize the element of myarray and 
            // create a new array. Here new array
            // is smaller than the original array 
            // so, elements are copied from the 
            // myarray to the new array until the
            // new one is filled. The rest of the
            // elements in the old array are ignored
            Array.Resize(ref myarray, len - 3);

            Console.WriteLine("New array is less than myarray:");

            foreach (string j in myarray)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine("Length of myarray: " + myarray.Length);
        }

    }
    }

