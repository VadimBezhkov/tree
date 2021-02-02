using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    // Create abstract class Person
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
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public Person(string lastName, string firstName, DateTime dateOfBirth) : this(lastName, firstName)
        {
            DateOfBirth = dateOfBirth;
        }
        /// <summary>
        ///  Same behavior as overridden method ToString
        /// </summary>
        public virtual void Info()
        {
            Console.WriteLine($"Name:{LastName} {FirstName} Birthday {DateOfBirth}");
        }
    }
}
