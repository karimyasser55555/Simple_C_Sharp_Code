using System;

namespace Task_6
{
    /*
    * ======================= Problem 1 ===========================
    * Create "Shape" Parent Class with Property:
    * Dimension (Assume it is Radius in case of circle and Length in case of Square and Rectangle)
    * 
    * Functions:
    * CalcArea()
    * 
    * With the child Classes:
    * - Square 
    * - Circle
    * - Rectangle (Add a new Dimension property)
    * 
    * Each should have a CalcArea() Function that returns the area of the shape
    * 
    */
    class Shape
    {
        public int Dimension1 { set; get; }
        public int Dimension2 { set; get; }
        
    }
    class Square : Shape
    {
        public Square()  { }
        public Square(Square value)
        {
            Dimension1 = value.Dimension1; 
        }
        public Square (int _Dimension1)
        {
            Dimension1 = _Dimension1;
        }
        public int CalcArea_S()
        {
            return Dimension1 * Dimension1;
        }
    }
    class Circle : Shape
    {
        public Circle() : this(1) { }
        public Circle(int _Dimension1)
        {
            Dimension1 = _Dimension1;
        }
        public double CalcArea_C()
        {
            return Dimension1 * Dimension1 * Math.PI;
        }
    }
    class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(int _Dimension1, int _Dimension2)
        {
            Dimension1 = _Dimension1;
            Dimension2 = _Dimension2;
        }
        public double CalcArea_R()
        {
            return Dimension1 * Dimension2;
        }
    }
    

        class Program
        {
            static void Main(string[] args)
            {
            // ======================= Problem 1 ===========================
            Console.WriteLine("Enter Your Choise");
            Console.WriteLine("1-Square 2-Circle 3-Rectangle ");
            int choise = int.Parse(Console.ReadLine());
            if (choise == 1)
            {
                Console.WriteLine("Enter Dimension");
                int Dim = int.Parse(Console.ReadLine());
                Square Area = new Square(Dim);
                Console.WriteLine("The Area Is : ");
                Console.WriteLine(Area.CalcArea_S());

            }
            else if (choise == 2)
            {
                Console.WriteLine("Enter Radius ");
                int Dim = int.Parse(Console.ReadLine());
                Circle Area = new Circle(Dim);
                Console.WriteLine("The Area Is : ");
                Console.WriteLine(Area.CalcArea_C());
            }
            else if (choise == 3)
            {
                Console.WriteLine("Enter Dimension 1  ");
                int Dim1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Dimension 2 ");
                int Dim2 = int.Parse(Console.ReadLine());
                Rectangle Area = new Rectangle(Dim1, Dim2);
                Console.WriteLine("The Area Is : ");
                Console.WriteLine(Area.CalcArea_R());
            }
            else
            {
                Console.WriteLine("Error");
            }
            // ======================= Problem 2 ===========================

            //Picture P = new Picture();
            ////- Square (Composition)
            //Square S = new Square(10);
            //P.Sq = S;
            //Console.WriteLine("The Area Of Square :");
            //Console.WriteLine(P.Sq.CalcArea_S());
            //// - Rectangle (Aggregation)
            //Rectangle Re = new Rectangle(2,3);
            //P.R = Re;
            //Console.WriteLine("The Area Of Rectangle :");
            //Console.WriteLine(P.R.CalcArea_R());
            //// - Circle (Association)
            //Circle C = new Circle(5);
            //Console.WriteLine("The Area Of Circle :");
            //Console.WriteLine(P.clac_c(C));
            //Console.WriteLine("The Totla Area :");
            //Console.WriteLine(P.GetTotalArea()); 
            /*
            * ======================= Problem 2 ===========================
            * Create "Picture" Class with the function GetTotalArea() which gets area of all shapes in picture
            * and the following classes with their relations:
            * 
            * - Square (Composition)
            *     - GetArea() Function
            * - Rectangle (Aggregation)
            *     - GetArea() Function
            * - Circle (Association)
            *     - GetArea() Function
            */
        }
        }
    class Picture
    {
        //- Square (Composition)
        Square SQ;
        public Picture()
        {

        }
        public Picture(Square _SQ)
        {
            SQ = _SQ;
        }
        public Square Sq
        {
            set
            {
                SQ = new Square(value);
            }
            get
            {
                return new Square(SQ);
            }
        }
        // - Rectangle (Aggregation)
        public Rectangle R { set; get; }

        // - Circle (Association)

        public double clac_c(Circle c)
        {
            return c.CalcArea_C();
        }
        public double GetTotalArea()
        {
            return SQ.CalcArea_S() + R.CalcArea_R();
        }
    }
}


