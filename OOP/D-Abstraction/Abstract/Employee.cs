using OOP.D_Abstraction.Interfaces;

namespace OOP.D_Abstraction.Base
{
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

        #region Abstraction By Encapsulation
        public double CalculateNetSalary()
        {
            return BasicSalary + AddOns - Subtracts;
        }
        #endregion

        #region Abstraction By Abstract Method
        public abstract string GetInfo();
        #endregion
    }
}
