using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
   class Fraction
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int N, int D)
            
        {
            Numerator = N;
            Denominator = D;
        }
        public void Print()
        {
            Console.WriteLine($"{Numerator}/{Denominator}");
        }
     public static Fraction operator+(Fraction Obj1 , Fraction Obj2)
        {
            Fraction Result = new Fraction();
            if (Obj1.Denominator == Obj2.Denominator)
            {
                Result.Numerator = Obj1.Numerator + Obj2.Numerator;
                Result.Denominator = Obj1.Denominator;
                return Result;
            }
            else
            {
                Result.Numerator = (Obj1.Numerator * Obj2.Denominator) + (Obj2.Numerator * Obj1.Denominator);
                Result.Denominator = Obj1.Denominator * Obj2.Denominator;
                return Result;
            }

        }
      public static Fraction operator ++(Fraction Obj)
        {
           Fraction Result = new Fraction();
            Result.Numerator = Obj.Numerator + Obj.Denominator * 1;
            Result.Denominator = Obj.Denominator;
            return Result;
        }
        public static bool operator ==(Fraction Obj3 , Fraction Obj4)
        {
            return (Obj3.Numerator / Obj3.Denominator) == (Obj4.Numerator / Obj4.Denominator);
        }
        public static bool operator !=(Fraction Obj3, Fraction Obj4)
        {
            return !(Obj3 == Obj4);
        }
        public Fraction (Fraction Obj5) // Copy Constructor
        {
            this.Numerator = Obj5.Numerator;
            this.Denominator = Obj5.Denominator;
        }
    }

}



