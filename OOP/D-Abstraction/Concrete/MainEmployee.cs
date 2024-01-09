using OOP.D_Abstraction.Base;

namespace OOP.D_Abstraction.Conceret
{
    public class MainEmployee : Employee
    {
        public MainEmployee(string firstName, string lastName, double basicSalary, double addons, double subs) : base(firstName, lastName, basicSalary, addons, subs)
        {
        }


        #region Abstraction By Abstract Method
        public override string GetInfo()
        {
            return $"Main Employee {FirstName} {LastName}";
        }
        #endregion

        #region Abstraction By Encapsulation

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
