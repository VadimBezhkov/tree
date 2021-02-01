using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    abstract public class Person
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        private DateTime _dateOfBirth;
        public Person()
        {

        }
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public Person(string lastName, string firstName, DateTime dateOfBirth) : this(lastName, firstName)
        {
            DateOfBirth = dateOfBirth;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Name:{LastName} {FirstName} Birthday {DateOfBirth}");
        }

    }
}
