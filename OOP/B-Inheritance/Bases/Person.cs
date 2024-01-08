using System;
using OOP.Abstract.Interfaces;


namespace OOP.Abstract.Bases
{
    public abstract class Person : IPerson
    {
        #region Attributes
        
        public string Name {get;set;}
        public int Age {get;set;}
        public string Email {get;set;}
        public  Address Address { get; set; } //Composition Relation between Person and Address (Person Has Address)

        #endregion

        #region Constructors

        public Person()
        {
            this.Address = new Address();

            Console.WriteLine("Iam Person Constructor With Empty Parameters");

        }

        public Person(string name)
        {
            this.Address = new Address();

            this.Name = name;

            Console.WriteLine($"Iam Person Constructor With Name {name}");
        }

        public Person(string name,string email)
        {
            this.Address = new Address();
            this.Name = name;
            this.Email = email;

            Console.WriteLine($"Iam Person Constructor With Name {name} , Email = {email}");
        }

        public Person(string name,string email,int age)
        {
            this.Address = new Address();
            this.Name = name;
            this.Email = email;
            this.Age = age;

            Console.WriteLine($"Iam Person Constructor With Name {name} , Email = {email},Age = {age}");
        }

        #endregion

        #region Actions

        //Abstraction Methods
        public abstract void Walk();

        //Polymorphism Methods By OverLoading
        public void Eat()
        {
            Console.WriteLine($"{Name} eat");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{Name} eat {food}");
        }

        #endregion
    }
}
