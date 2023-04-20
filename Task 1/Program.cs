using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1- write a program to print "Hello World"
            Console.WriteLine("Hello World!");

            //2- write a program to print area of circle
            Console.WriteLine("Enter The Circle Radias With CM");
            int Radias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(3.14159*Radias*Radias+"  CM");

            //3- write a porgram to print + , - , / , * of 2 numbers 
            Console.WriteLine("Enter Num1 :");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num2 :");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculations");
            Console.WriteLine("Num1 + Num2");
            Console.WriteLine(Num1 + Num2);
            Console.WriteLine("Num1 - Num2");
            Console.WriteLine(Num1 - Num2);
            Console.WriteLine("Num1 / Num2");
            Console.WriteLine(Num1 / Num2);
            Console.WriteLine("Num1 * Num2");
            Console.WriteLine(Num1 * Num2);

            //4- write a program to print ascii number of any character(bouns)
            Console.WriteLine("Enter Character To Convert Into ASCII");
            char L = char.Parse(Console.ReadLine());
            Console.WriteLine((int)L);


            //5. Get a number from a user & checking if it is Even Or Odd Or Zero using if ...else statement.
            Console.WriteLine("Enter Number to Check :");
            int num = Convert.ToInt32(Console.ReadLine());
            Num1 = num % 2;
            if (Num1 == 0 && num != 0)
                Console.WriteLine("Numebr is an even integer.");
            else
                Console.WriteLine("Number is an odd integer.");
            /*6. Getting grade of a student as int, and printing it as char using if ...else statement:
                   90 and above      A
                   80 to 90          B
                   70 to 80          C
                   60 to 70          D
                   Below 60          F
   */
            Console.WriteLine("Enter Grade to Check :");
            int Grade = Convert.ToInt32(Console.ReadLine());
            if (Grade >= 90)
                Console.WriteLine("A");
            else if  (Grade < 90 && Grade >= 80)
                Console.WriteLine("B");
            else if (Grade < 80 && Grade >= 70)
                Console.WriteLine("C");
            else if (Grade < 70 && Grade >= 60)
                Console.WriteLine("D");
            else 
                Console.WriteLine("F");

            /* 7.Printing a simple menu using switch:
                   1.Add
                   2.Edit
                   3.Display
                   4.Exit
            */
            Console.WriteLine("Add (A) ");
            Console.WriteLine("Edit (E) ");
            Console.WriteLine("Display (D) ");
            Console.WriteLine("Exit (X) ");

            char Menu = char.Parse(Console.ReadLine());

            switch (Menu)
            {
                case 'A':
                    Console.WriteLine("Add (A) ");
                    break;

                case 'E':
                    Console.WriteLine("Edit (E) ");
                    break;

                case 'D':
                    Console.WriteLine("Display (D) ");
                    break;

                case 'X':
                    Console.WriteLine("Exit (X) ");
                    break;

                default:
                    Console.WriteLine("Exit (X) ");
                    break;
            }
            //8- update in problem no 3 , Take 2 numbers And Operator(+,/,-,*), then Print Result
            Console.WriteLine("Enter the action to be performed");
            Console.WriteLine("Press A for Addition");
            Console.WriteLine("Press B for Subtraction");
            Console.WriteLine("Press C for Multiplication");
            Console.WriteLine("Press D for Division ");
            char action = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1st input");
            int Num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd input");
            int Num_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 'A':
                    {
                        result = Num_1 + Num_2;
                        Console.WriteLine("Your Results Is :"+result);
                        break;
                    }
                case 'B':
                    {
                        result = Num_1 - Num_2;
                        Console.WriteLine("Your Results Is :" + result);
                        break;
                    }
                case 'C':
                    {
                        result = Num_1 * Num_2;
                        Console.WriteLine("Your Results Is :" + result);
                        break;
                    }
                case 'D':
                    {
                        result = Num_1 / Num_2;
                        Console.WriteLine("Your Results Is :" + result);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }

        }

      
    }
}
