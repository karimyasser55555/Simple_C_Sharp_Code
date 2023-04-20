using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * Create a Fraction class to implement fraction mathematics
                * 
                * Class has 2 members: Numerator & Denominator
                * 
                * Functions to implement (Operator Overloaded):
                * 
                * 1) + (Addition of 2 fractions)
                * 2) ++ (Incrementing a fraction by 1)
                * 3) == (Comparing 2 fractions for similarity)
                * 4) Print (To show fraction as "x/y")
                * 5) Copy Constructor
            */


            Fraction Obj1 = new Fraction(1,3);
            Fraction Obj2 = new Fraction(3,6);
            Obj1.Print();
            Obj2.Print();

            Fraction Obj3 = new Fraction();
            Obj3 = Obj1 + Obj2;
            Obj3.Print();


            Fraction Obj = new Fraction(3, 5);
            Obj++;
            Obj.Print();

            bool Results = Obj1 == Obj2;
            Console.WriteLine(Results);

            Fraction Copy = new Fraction(Obj1);
            Copy.Print();

        }
    }
}
