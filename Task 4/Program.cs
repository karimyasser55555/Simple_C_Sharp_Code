using System;

namespace Task_4
{
 /*
 * Create "Student" class with the following properties:
 *  
 *  Name (Must be more than 5 characters)
 *  Age (Must be greater than or equal 20)
 *  Address
 *  Grade (Bonus: Make it an array)
 *  
 *  Password [without GET] (Must be more than or equal characters) 
 *  (Bonus 1: Validate with Regular Expressions)
 *  (Bonus 2: Set password only once)
 *  
 *  Username (Name + Age)
 * 
 *  Functions:
 *  ForgetPassword()
 *    
 *    Parameters: Username
 *    Returns a randomly generated password if parameter matches student's username, else throw an exception
 */
 class Student
    {
        private string Name;
        private int Age;
        public string Address { set; get; }
        public int Grade { set; get; }
        private string Password;

        //1-Name
        public string name
        {
            set {
                if (value.Length > 5)
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Wrong : Name Must Above 5 Char");
                }
            }
            get { return Name; }
        }
        //public void Set_name(string _name)
        //{
            
        //    if (_name.Length>5 )
        //    {
        //        Name = _name;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Name Must Above 5 Char");
        //    }
        //}
        //public string Get_name()
        //{
        //    return Name;
        //}

        //2-Age
        public int age
        {
            set {
                if (value >= 20)
                {
                    Age = value;
                }
                else
                {

                    Console.WriteLine("Wrong : Age Must Above 20");
                }
            }
            get { return Age; }
        }
        //public void Set_age(int _age)
        //{
           
        //    if (_age >= 20)
        //    {
        //        Age = _age;
        //    }
        //    else
        //    {
                
        //        Console.WriteLine("Age Must Above 20");
        //    }
            
        //}
        
        //public int Get_age()
        //{
        //    return Age;
        //}

        //3-Address
        //public string address
        //{
        //    set { Address = value }
        //    get { return Address }
        //}
        //public void Set_address(string _address)
        //{
           
            
        //    Address = _address;
        //}
        //public string Get_address()
        //{
        //    return Address;
        //}

        //4-Grade
        //public void Set_grade(int _grade)
        //{
            
            
        //    Grade = _grade;
        //}
        //public int Get_grade()
        //{
        //    return Grade;
        //}

        //5-Password
        public string password
        {
            set
            {
                if (value.Length > 8)
                {
                    Password = value;
                }
                else
                {
                    Console.WriteLine("Password Must Above 8 Char");
                }
            }

        }
        //public void Set_Password(string _Password)
        //{

        //    if (_Password.Length > 8)
        //    {
        //        Password = _Password;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Password Must Above 8 Char");
        //    }
        //}

        //6-UserName
        public string Get_UserName()
        {
            return Name + Age;
        }
        //7-ForgetPassword
        public string ForgetPassword(string UserName)
        {
            if (UserName == Get_UserName())
            {
                Console.WriteLine(Password);
                return Password;

            }
            else
            {
                Console.WriteLine("Wrong Password :");
                return Name;
            }
            
        }

    }





    class Program
    {
        static void Main(string[] args)

        {
           
            Student A = new Student();
            Console.WriteLine("Name Must Above 5 Char");
            string Na = Console.ReadLine();
            A.name=Na;



            Console.WriteLine("Enter Age Must Above 20");
            int Num = int.Parse(Console.ReadLine());
            A.age=Num;



            Console.WriteLine("Enter Address");
            string Adr = Console.ReadLine();
            A.Address = Adr;



            Console.WriteLine("Enter Grade");
            int Num1 = int.Parse(Console.ReadLine());
            A.Grade=(Num1);


            Console.WriteLine("Enter Password");
            string Pass = Console.ReadLine();
            A.password=Pass;
            A.Get_UserName();
            Console.WriteLine("Your User UserName Is :");
            Console.WriteLine(A.Get_UserName());
            Console.WriteLine("If You Forgot The Password Type Your UserName");
            string P = Console.ReadLine();
            Console.WriteLine("Your Forgotten Password");
            A.ForgetPassword(P);

            Console.WriteLine("Your Name");
            Console.WriteLine(A.name);
            Console.WriteLine("Your Age");
            Console.WriteLine(A.age);
            Console.WriteLine("Your Address");
            Console.WriteLine(A.Address);
            Console.WriteLine("Your Grade");
            Console.WriteLine(A.Grade);



        }
    }
    }
