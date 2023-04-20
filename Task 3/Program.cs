using System;

namespace Task_3
{
    class Program
    {
        //Fill Function:
        static int[,] ArrayNumbers(int Num1, int Num2)
        {
            int[,] TDArr = new int[Num1, Num2];
            for (int r = 0; r < TDArr.GetLength(0); r++)
            {
               
                for (int c = 0; c < TDArr.GetLength(1); c++)
                {
                    
                    Console.WriteLine($"Enter Grade {r + 1} of Studebt {c + 1}");
                    TDArr[r, c] = int.Parse(Console.ReadLine());
                }
                
            }
             
            return TDArr;
        }
        //Print Function
        static void PrintArray (int[,] Arr)
        {
           
            for (int r = 0; r < Arr.GetLength(0); r++)
            {

                for (int c = 0; c < Arr.GetLength(1); c++)
                {

                    Console.WriteLine(Arr[r, c]);
                }

            }

            
        }
        //Sum Function 
        static int[,] SumNumbers(int Num1, int Num2)
        {
            int[,] TDArr = new int[Num1, Num2];
            for (int c = 0; c < TDArr.GetLength(1); c++)
            {
                int sum = 0;
                for (int r = 0; r < TDArr.GetLength(0); r++)
                {
                    Console.WriteLine($"Enter Grade {c + 1} of Studebt {r + 1}");
                    TDArr[r, c] = int.Parse(Console.ReadLine());
                    sum += TDArr[r, c];

                }
                Console.WriteLine("Total :" + sum);
            }

            return TDArr;
        }
        static void Main(string[] args)
        {
            //1.Fill and Print a 2D Array(Using Functions)

            int[,] Arr = ArrayNumbers(3, 2);
            PrintArray(Arr);


            //By Row
            //int[,] TDArr = new int[3, 2];

            //for (int r = 0; r < TDArr.GetLength(0); r++)
            //{

            //    for (int c = 0; c < TDArr.GetLength(1); c++)
            //    {
            //        PrintArray(r, c);
            //        TDArr[r, c] = int.Parse(Console.ReadLine());

            //    }
            //}
            ////By Column
            //int[,] TDArr = new int[3, 2];
            //for (int c = 0; c < TDArr.GetLength(1); c++)
            //{
            //    for (int r = 0; r < TDArr.GetLength(0); r++)
            //    {
            //       PrintArray(c, r);
            //        TDArr[r, c] = int.Parse(Console.ReadLine());
            //    }
            //}


            //2.Sum of every 'Column' in 2D Array(Using Functions)

            SumNumbers(3, 2);


            //// By Column
            //int[,] TDArr = new int[3, 2];
            //for (int c = 0; c < TDArr.GetLength(1); c++)
            //{
            //    int sum = 0;
            //    for (int r = 0; r < TDArr.GetLength(0); r++)
            //    {
            //        PrintArray(c, r);
            //        TDArr[r, c] = int.Parse(Console.ReadLine());
            //        sum += TDArr[r, c];

            //    }
            //    Console.WriteLine("Total :" + sum);
            //}
            ////By Row
            //int[,] TDArr = new int[3, 2];
            //for (int r = 0; r < TDArr.GetLength(0); r++)
            //{
            //    int sum = 0;
            //    for (int c = 0; c < TDArr.GetLength(1); c++)
            //    {
            //        PrintArray(r, c);
            //        TDArr[r, c] = int.Parse(Console.ReadLine());
            //        sum += TDArr[r, c];
            //    }
            //    Console.WriteLine("Total :" + sum);
            //}


            //3.Simple Menu on Array(Refer to Problem 6 in Lab 2)(2D Array Bonus)(Using Functions)
            Console.WriteLine("Add (A) ");
            Console.WriteLine("Edit (E) ");
            Console.WriteLine("Display (D) ");
            Console.WriteLine("Delete (L) ");
            Console.WriteLine("Exit (X) ");
             int[] Grades = new int[5];
            Grades[0] = 100;
            Grades[1] = 200;
            Grades[2] = 300;
            Grades[3] = 400;
            Grades[4] = 500;
            Console.WriteLine("My Array Lenth Now :" + Grades.Length);
            for (int i =0; i<4;i++)
            {
                char Menu = char.Parse(Console.ReadLine());

                if (Menu == 'A')
                {

                    Console.WriteLine("Add (A) ");
                    Console.WriteLine("Enter Size :");
                    int size = int.Parse(Console.ReadLine());

                    int[] Temp = new int[size + 5];
                    for (int j = 0; j < Grades.Length; j++)
                    {
                        Temp[j] = Grades[j];
                    }
                    Grades = Temp;
                    Console.WriteLine("My Array Lenth Now :" + Temp.Length);
                }
                else if (Menu == 'E')
                {
                    Console.WriteLine("Enter the Index :");
                    int I = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Value :");
                    int V = int.Parse(Console.ReadLine());
                    Grades[I] = V;
                    Console.WriteLine("The New  Value :" + V);

                }
                else if (Menu == 'D')
                {
                    foreach (int j in Grades)
                    {
                        Console.WriteLine(j);
                    }
                }
                else if (Menu == 'L')
                {
                    Console.WriteLine("My Array Lenth Now :" + Grades.Length);
                    foreach (int N in Grades)
                    {
                        Console.WriteLine(N);
                    }
                    Console.WriteLine("Enter The Index You Want To Delete :" );
                    int Item = int.Parse(Console.ReadLine());
                    int index = Item;

                    for (int A = index; A < Grades.Length - 1; A++)
                    {
                        Grades[A] = Grades[A + 1];
                    }
                    Array.Resize(ref Grades, Grades.Length - 1);

                    Console.WriteLine("My Array Lenth Now :" + Grades.Length);
                    foreach(int N in Grades)
                    {
                        Console.WriteLine(N);
                    }
                }
                else if (Menu == 'X')
                {
                    break;
                }
                else
                    break;

            
            }

        }


    }
}
