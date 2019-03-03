using System;

namespace LibrarySystemClassLibrary
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;
        protected string gender;
        protected int id;
        protected string bookRequested;

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.gender = "";
            this.id = 0;
            this.bookRequested = "";
        }

        public Person(string firstName,string lastName,int age, string gender,int id,string bookRequested)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.id = id;
            this.bookRequested = BookRequested;
        }

        public string FirstName
        {
            get {return this.firstName; }
            set {this.firstName = value; }
        }

        public string LastName
        {
            get {return this.lastName; }
            set {this.lastName = value; }
        }

        public int Age 
        {
            get {return this.age; }
            set {this.age = value; }
        }

        public string Gender
        {
            get {return this.gender; }
            set {this.gender = value; }
        }

        public int Id
        {
            get {return this.id; }
            set{this.id = value; }
        }

        public string BookRequested
        {
            get {return this.bookRequested; }
            set {this.bookRequested = value; }
        }
    }
}
