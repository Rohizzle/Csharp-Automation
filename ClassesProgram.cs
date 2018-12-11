using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person perOne = new Person();
            perOne.FirstName = "Roheel";
            perOne.LastName = "Arshad";
            perOne.Country = "Scotland";

            Person perTwo = new Person();
            perTwo.FirstName = "Mohfizzle";
            perTwo.LastName = "Foshizzle";
            perTwo.Country = "UK";

            Console.WriteLine(perOne.FirstName);
            Console.WriteLine(perTwo.FirstName);
        }
    }

    class Person
    {
        string firstName;
        string lastName;
        DateTime birthDate;
        string country;

        public string FirstName
        {
            get { return firstName;  }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value;  }
        }

        public DateTime BirthDate { get; set; }
        public string Country { get; set; }
    }
}
