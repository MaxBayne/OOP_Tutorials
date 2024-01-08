using System;
using OOP.Abstract.Bases;

namespace OOP.Concrete
{
    public class Boy:Person
    {
        #region Attributes

        public Watch Watch { get; set; } //Composition Relationship between Boy And Watch (Boy Has Watch)

        #endregion

        #region Constructors

        public Boy()
        {
            
        }

        public Boy(string name) : base(name)
        {

        }

        public Boy(string name,string email) : base(name,email)
        {

        }

        public Boy(string name, string email,int age) : base(name, email,age)
        {

        }



        #endregion

        #region Actions

        public override void Walk()
        {
            Console.WriteLine($"{Name} is Walking");
        }

        #endregion
    }
}
