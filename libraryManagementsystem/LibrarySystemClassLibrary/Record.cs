using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystemClassLibrary
{
    public class Record
    {
        private string bookNumber;
        private string bookTitle;
        private string personId;
        private string personName;
        private DateTime dateIssue;
        private DateTime dueDate;
        private DateTime dateReturned;
        private float lateFee;
        private float bookFee;
        private string issue;
        private string libarian;

        public Record()
        {
            this.bookNumber = "";
            this.bookTitle = "";
            this.personId = "";
            this.personName = "";
            this.dateIssue = DateTime.Now;
            this.dueDate = DateTime.Now;
            this.dateReturned = DateTime.Now;
            this.lateFee = 0;
            this.bookFee = 0;
            this.issue = "";
            this.libarian = "";
        }

        public Record(string bookNumber,string bookTitle,string personId,string personName,DateTime dateIssue,DateTime dueDate,DateTime dateReturned,float lateFee,float bookFee,string issue,string libarian)
        {
            this.bookNumber = bookNumber;
            this.bookTitle = bookTitle;
            this.personId = personId;
            this.personName = personName;
            this.dateIssue = dateIssue;
            this.dueDate = dueDate;
            this.dateReturned = dateReturned;
            this.lateFee = lateFee;
            this.bookFee = bookFee;
            this.issue = issue;
            this.libarian = libarian;
        }

        public string BookNumber
        {   get {return this.bookNumber; }
            set {this.bookNumber = value; }
        }

        public string BookTitle
        {
            get {return this.bookTitle; }
            set {this.bookTitle = value; }
        }

        public string PersonId
        {
            get {return this.personId; }
            set {this.personId = value; }
        }

        public string PersonName
        {
            get {return this.personName; }
            set {this.personName = value; }
        }

        public DateTime DateIssue
        {
            get {return this.dateIssue; }
            set {this.dateIssue = value; }
        }

        public DateTime DueDate
        {
            get {return this.dueDate; }
            set {this.dueDate = value; }
        }

        public DateTime DateReturned
        {
            get { return this.dateReturned; }
            set { this.dateReturned = value; }
        }

        public float LateFee
        {
            get {return this.lateFee ; }
            set {this.lateFee = value; }
        }

        public float BookFee
        {
            get {return this.bookFee; }
            set {this.bookFee = value; }
        }

        public string Issue
        {
            get {return this.issue; }
            set {this.issue = value; }
        }

        public string Libarian
        {
            get {return this.libarian; }
            set {this.libarian = value; }
        }
    } 
}
