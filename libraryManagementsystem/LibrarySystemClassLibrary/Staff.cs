using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystemClassLibrary
{
    public class Staff : Person
    {
        private int trnNumber;

        public Staff()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.gender = "";
            this.id = 0;
            this.bookRequested = "";
            this.trnNumber = 0;
        }

        public Staff(string firstName, string lastName, int age, string gender, int id, string bookRequested, int grade, string clas,int trnNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.id = id;
            this.bookRequested = bookRequested;
            this.trnNumber = trnNumber;
        }

        public int TrnNumber
        {
            get {return this.trnNumber; }
            set {this.trnNumber = value; }
        }

    }
}
