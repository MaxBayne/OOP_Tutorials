using System;
using OOP.Abstract.Interfaces;
using OOP.C_Polymorphism.Base;
using OOP.C_Polymorphism.Conceret;
using OOP.Concrete;


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

            IEmployee mainEmp = new MainEmployee("Mohammed","Salah",5000,100,50);
            IEmployee tempEmp = new TempEmployee("Mahmoud", "Khalid", 2000, 240, 70);

            //Polymorphism With Overloading

            var emp = new MainEmployee("Mohammed", "Salah", 5000, 100, 50);

            var netSalary = emp.CalculateNetSalary();
            var netSalaryWithTax = emp.CalculateNetSalary(14);

            Console.WriteLine($"Net Salary = {netSalary}");
            Console.WriteLine($"Net Salary With Tax = {netSalaryWithTax}");

            //Polymorphism With Overriding

            Console.WriteLine(emp.GetInfo());

            //#################################################
            //Abstraction (UnImplement) ---------------------
            //#################################################

            /*
             * - Hide Implementation By using Interfaces
             */
            Console.WriteLine("");
            Console.WriteLine("===========================================");
            Console.WriteLine("--------------- Abstraction ---------------");
            Console.WriteLine("===========================================");



            /*
            IPerson boy = new Boy("Mohammed");
            IPerson girl = new Girl("Mona");

            Console.WriteLine(boy.Name);
            Console.WriteLine(girl.Name);
            */

            //Hide Implementation By Using Abstract Classes
            /*
            Boy boy4 = new Boy("Ahmed");
            Girl girl4 = new Girl("Mona");

            boy4.Walk();
            girl4.Walk();
            */


        }
    }
}
