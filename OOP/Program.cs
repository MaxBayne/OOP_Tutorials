using System;
using OOP.C_Polymorphism.Base;
using OOP.C_Polymorphism.Conceret;
using OOP.Concrete;
using OOP.D_Abstraction.Conceret;
using OOP.D_Abstraction.Interfaces;



namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //OOP Concepts
            //------------
            /*
             * - Encapsulation
             * - Inheritance
             * - Polymorphism
             * - Abstraction
             */



            //#################################################
            //Encapsulation ---------------------
            //#################################################

            /*
             * - mean hide any details for class inside methods and dont make anybody can change that details 
             * - protect class from being changed its data and make class in invalid state mean use methods to alter attributes and make validation on it
             * - u can use methods for alter attributes and access modifiers for hiding details
            */

            Console.WriteLine("===========================================");
            Console.WriteLine("-------------- Encapsulation --------------");
            Console.WriteLine("===========================================");

            //here i cant alter any attributes directlly just using methods

            Car car = new Car();

            car.ChangeSpeed(1000);
            car.ChangeColor("Red");
            car.ChangeModel("SUV");

            Console.WriteLine(car);

            //#################################################
            //Inheritance ---------------------
            //#################################################

            /*
             * (Is-A) => Ahmed Is A Person , BMW is A Car
             * Inheritance Is Relation Between Class and Class
            */
            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("--------------- Inheritance ---------------");
            Console.WriteLine("===========================================");

            Person boy = new Boy();
            Person girl = new Girl();

            boy.SetName("Ahmed");
            boy.SetEmail("Ahmed@gmail.com");
            boy.SetAge(22);

            girl.SetName("Mona");
            girl.SetEmail("Mona@gmail.com");
            girl.SetAge(20);

            Console.WriteLine(boy);
            Console.WriteLine(girl);


            //#################################################
            //Polymorphism ---------------------
            //#################################################

            /*
             * - Polymorphism With interface and Inheritance 
             * - Polymorphism using overloading
             * - Polymorphism using overRiding
             */

            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("--------------- Polymorphism ---------------");
            Console.WriteLine("===========================================");

            //Polymorphism With Interfaces

            ITeacher mainTeacher = new MainTeacher("Mohammed","Salah",5000,100,50);
            ITeacher tempTeacher = new TempTeacher("Mahmoud", "Khalid", 2000, 240, 70);

            //Polymorphism With Overloading

            var teacher = new MainTeacher("Mohammed", "Salah", 5000, 100, 50);

            var netSalary = teacher.CalculateNetSalary();
            var netSalaryWithTax = teacher.CalculateNetSalary(14);

            Console.WriteLine($"Net Salary = {netSalary}");
            Console.WriteLine($"Net Salary With Tax = {netSalaryWithTax}");

            //Polymorphism With Overriding

            Console.WriteLine(teacher.GetInfo());

            //#################################################
            //Abstraction (UnImplement) ---------------------
            //#################################################

            /*
             * - Hide Implementation and Details for class
             * - Abstraction using Abstract Method
             * - Abstraction using Abstract Class
             * - Abstraction using interfaces
             */

            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("--------------- Abstraction ---------------");
            Console.WriteLine("===========================================");

            IEmployee employee = new MainEmployee("mohammed","salah",5000,500,300);

            Console.WriteLine(employee);



        }
    }
}
