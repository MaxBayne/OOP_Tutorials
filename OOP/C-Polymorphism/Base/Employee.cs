using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.C_Polymorphism.Base
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        double BasicSalary { get; }
        double AddOns { get; }
        double Subtracts { get; }

        double CalculateNetSalary();
        string GetInfo();
    }



    //Base/Super Class
    public abstract class Employee : IEmployee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public double BasicSalary { get; private set; }
        public double AddOns { get; private set; }
        public double Subtracts { get; private set; }

        public Employee(string firstName,string lastName,double basicSalary,double addons,double subs)
        {
            FirstName = firstName;
            LastName = lastName;
            BasicSalary = basicSalary;
            AddOns = addons;
            Subtracts = subs;

        }

        public double CalculateNetSalary()
        {
            return BasicSalary + AddOns - Subtracts;
        }

        public abstract string GetInfo();
    }
}
