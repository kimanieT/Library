using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystemClassLibrary
{
    public class Student : Person
    {
        private int grade;
        private string clas;

        public Student()
        {
            this.firstName = "";
            this.lastName = "";
            this.age = 0;
            this.gender = "";
            this.id = 0;
            this.bookRequested = "";
            this.grade = 0;
            this.clas = "";
        }

        public Student(string firstName, string lastName, int age, string gender, int id, string bookRequested, int grade, string clas)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.id = id;
            this.bookRequested = BookRequested;
            this.grade = grade;
            this.clas = clas;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }

        public string Clas
        { 
            get{return this.clas;}
            set {this.clas = value;} 
        }
    }
}
