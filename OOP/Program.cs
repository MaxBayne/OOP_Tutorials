using System;
using OOP.Abstract.Bases;
using OOP.Abstract.Interfaces;
using OOP.Concrete;
using OOP.Models;

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
             * - Abstraction
             * - Polymorphism
             */



            //#################################################
            //Encapsulation ---------------------
            //#################################################

            /*
             * - mean hide any details for class inside methods and dont make anybody can change that details 
             * - protect class from being changed its data and make class in invalid state mean use methods to alter attributes and make validation on it
             * - u can use methods for alter attributes and access modifiers for hiding details
            */

            //Car bmw = new Car();

            //#################################################
            //Inheritance ---------------------
            //#################################################

            //(Is-A) => Ahmed Is A Person , BMW is A Car
            //Inheritance Is Relation Between Class and Class

            //Boy boy = new Boy();

            //boy.Name = "Ahmed";
            //boy.Email = "Ahmed@gmail.com";
            //boy.Age = 22;

            //Console.WriteLine(boy.Name);

            ///////

            //Boy boy1 = new Boy("Max Bayne");

            //Console.WriteLine(boy1.Name);

            ///////

            //Boy boy2 = new Boy("Eng.Mohammed Salah","mohammed.salah@gmail.com",25);

            //Console.WriteLine(boy2.Name);

            //#################################################
            //Composition --------------------- (Has-A) => Car Has A Person , Person Has A Watch
            //#################################################

            //Composition is Relation Between Object and Object

            /*
            Boy boy3 = new Boy("Composition");
            boy3.Address.CountryName = "Egypt";

            Console.WriteLine($"Boy name is {boy3.Name} , has address in {boy3.Address.CountryName}");
            */

            //#################################################
            //Abstraction (UnImplement) ---------------------
            //#################################################

            //Hide Implementation By using Interfaces

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

            //#################################################
            //Polymorphism ---------------------
            //#################################################

            //Polymorphism With interface and Inheritance
            //IPerson Interface or Person Class  = can store Boy or Girl


            IPerson boy = new Boy("Ahmed");
            Person girl = new Girl("Aya");

            Console.WriteLine(boy.Name);
            Console.WriteLine(girl.Name);
            

            //Polymorphism With Overloading

            /*
            Boy boy5 = new Boy("Mido");

            boy5.Eat();
            boy5.Eat("Mango");
            */
        }
    }
}
