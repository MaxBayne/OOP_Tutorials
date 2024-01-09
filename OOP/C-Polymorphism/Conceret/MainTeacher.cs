﻿using OOP.C_Polymorphism.Base;


namespace OOP.C_Polymorphism.Conceret
{
    internal class MainTeacher : Teacher
    {
        public MainTeacher(string firstName, string lastName, double basicSalary, double addons, double subs) : base(firstName, lastName, basicSalary, addons, subs)
        {
        }


        #region Polymorphism With Overridding
        public override string GetInfo()
        {
            return $"Main Employee {FirstName} {LastName}";
        }
        #endregion

        #region Polymorphism With Overloading

        public double CalculateNetSalary(double taxPercent)
        {
            var totalSalary = BasicSalary + AddOns;
            var taxAmount = totalSalary * taxPercent / 100;
            var netSalary = totalSalary - taxAmount - Subtracts;

            return netSalary;
        }

        #endregion
    }
}
