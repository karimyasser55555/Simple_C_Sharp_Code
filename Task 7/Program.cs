using System;

namespace Task_7
{
    public sealed class Picture
    {
        public Shape[] Shapes { get; set; }
        public double CalculateTotalArea(Shape[] Shapes)
        {
            double sum = 0;
            for (int i = 0; i < Shapes.Length; i++)
            {
                sum += Shapes[i].CalculateArea();
            }
            return sum;
        }
        //    public double CalculateTotalArea()
        //{
        //    double totalArea = 0;


        //    foreach (Shape shape in Shapes)
        //    {
        //        totalArea += shape.CalculateArea();
        //    }

        //    return totalArea;
        //}
    }

    public abstract class Shape
    {

        public int Dimension1 { set; get; }
        public int Dimension2 { set; get; }



        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public Square() { }
        public Square(Square value)
        {
            Dimension1 = value.Dimension1;
        }
        public Square(int _Dimension1)
        {
            Dimension1 = _Dimension1;
        }

        public override double CalculateArea()
        {
            return Math.Pow(Dimension1, 2);
        }
    }

    public class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(int _Dimension1, int _Dimension2)
        {
            Dimension1 = _Dimension1;
            Dimension2 = _Dimension2;
        }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2;
        }

    }

    public class Circle : Shape
    {
        public Circle() : this(1) { }
        public Circle(int _Dimension1)
        {
            Dimension1 = _Dimension1;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Dimension1, 2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            /*
 * Modify Problem 1 in Lab 6 to make "Shape" Class Abstract
 * and make CalcArea() abstract
 * 
 * 
 * Create Class "Picture" and add shapes array (as aggreggate)
 * and calculate total area in a function
 * 
 */
            // ======================= Problem 1 ===========================
            Console.WriteLine("Enter Your Dimension");
            //Console.WriteLine("1-Square 2-Circle 3-Rectangle ");
            //int choise = int.Parse(Console.ReadLine());
            //if (choise == 1)
            //{
            Console.WriteLine("1-Square  ");
            Console.WriteLine("Enter Dimension");
            int Dim = int.Parse(Console.ReadLine());
            Square Square_Area = new Square(Dim);
            Console.WriteLine("The Area Is : ");
            Console.WriteLine(Square_Area.CalculateArea());

            //}
            //else if (choise == 2)
            //{
            Console.WriteLine(" 2-Circle ");
            Console.WriteLine("Enter Radius ");
            int Dim1 = int.Parse(Console.ReadLine());
            Circle Circle_Area = new Circle(Dim1);
            Console.WriteLine("The Area Is : ");
            Console.WriteLine(Circle_Area.CalculateArea());
            //}
            //else if (choise == 3)
            //{
            Console.WriteLine(" 3-Rectangle ");
            Console.WriteLine("Enter Dimension 1  ");
            int Dim2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Dimension 2 ");
            int Dim3 = int.Parse(Console.ReadLine());
            Rectangle Rectangle_Area = new Rectangle(Dim2, Dim3);
            Console.WriteLine("The Area Is : ");
            Console.WriteLine(Rectangle_Area.CalculateArea());
            //}
            //else
            //{
            //Console.WriteLine("Error");
            //}
            //* ======================= Problem 2 ===========================
            Picture P = new Picture();
            Shape[] shapes = new Shape[3];
            shapes[0] = Square_Area;
            shapes[1] = Circle_Area;
            shapes[2] = Rectangle_Area;
            Console.WriteLine("The Total Area is :");
            Console.WriteLine(P.CalculateTotalArea(shapes));
        }
    }
}
