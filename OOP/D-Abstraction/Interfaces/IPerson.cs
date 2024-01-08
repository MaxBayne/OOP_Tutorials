
namespace OOP.Abstract.Interfaces
{
    public interface IPerson
    {
        //Attributes
        string Name { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        Address Address { get; set; }

        //Actions
    }
}