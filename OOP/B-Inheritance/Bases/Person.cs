using System;
using OOP.Abstract.Interfaces;



public abstract class Person : IPerson
{
    #region Attributes

    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Email { get; private set; }
    public Address Address { get; private set; } //Composition Relation between Person and Address (Person Has Address)

    #endregion

    #region Constructors

    public Person()
    {
        Address = new Address();

        //Console.WriteLine("Iam Person Constructor With Empty Parameters");

    }

    public Person(string name)
    {
        Address = new Address();

        Name = name;

        //Console.WriteLine($"Iam Person Constructor With Name {name}");
    }

    public Person(string name, string email)
    {
        Address = new Address();
        Name = name;
        Email = email;

        //Console.WriteLine($"Iam Person Constructor With Name {name} , Email = {email}");
    }

    public Person(string name, string email, int age)
    {
        Address = new Address();
        Name = name;
        Email = email;
        Age = age;

        //Console.WriteLine($"Iam Person Constructor With Name {name} , Email = {email},Age = {age}");
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

    #region Encapsulation

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetAge(int age)
    {
        Age = age;
    }

    public void SetEmail(string email)
    {
        Email = email;
    }

    public void SetAddress(Address address)
    {
        Address = address;
    }

    #endregion

    #region Override

    public override string ToString()
    {
        return $"Name={Name},Age={Age},Email={Email},Type={GetType()}";
    }

    #endregion
}

