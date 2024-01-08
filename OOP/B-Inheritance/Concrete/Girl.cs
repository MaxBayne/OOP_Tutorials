using System;

namespace OOP.Concrete
{
    public class Girl:Person
    {
        #region Constructors

        public Girl()
        {

        }

        public Girl(string name) : base(name)
        {

        }

        public Girl(string name, string email) : base(name, email)
        {

        }

        public Girl(string name, string email, int age) : base(name, email, age)
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
