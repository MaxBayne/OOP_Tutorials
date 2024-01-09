namespace OOP.D_Abstraction.Interfaces
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
}
