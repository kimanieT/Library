using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystemClassLibrary
{
    public class Book
    {
        private string bookTitle;
        private string author;
        private string publisher;
        private int yearPublish;
        private int pages;
        private string bookNumber;
        private string status;
        private string type;
        private string genre;
        private float bookFee;
        private float lateFee;
        private int numberOfBooks;


        public Book()
        {
            this.bookTitle = "";
            this.author = "";
            this.publisher = "";
            this.yearPublish = 0;
            this.pages = 0;
            this.bookNumber = "";
            this.status = "";
            this.type = "";
            this.genre = "";
            this.bookFee = 0;
            this.numberOfBooks = 0;
        }

        public Book(string bookTitle,string author,string publisher,int yearPublish,int pages,string bookNumber,string status,string type,string genre,float bookFee,int numberOfBooks)
        {
            this.bookTitle = bookTitle;
            this.author = author;
            this.publisher = publisher;
            this.yearPublish = yearPublish;
            this.pages = pages;
            this.bookNumber = bookNumber;
            this.status = status;
            this.type = type;
            this.genre = genre;
            this.bookFee = bookFee;
            this.numberOfBooks = numberOfBooks;
        }

        public string BookTitle
        {
            get {return this.bookTitle; }
            set {this.bookTitle = value; }
        }

        public string Author
        {
            get {return this.author; }
            set {this.author = value; }
        }

        public string Publisher
        {
            get { return this.publisher; }
            set { this.publisher = value; }
        }

        public int YearPublish
        {
            get {return this.yearPublish; }
            set {this.yearPublish = value; }
        }

        public int Pages
        {
            get {return this.pages; }
            set {this.pages = value; }
        }

        public string BookNumber
        {
            get {return this.bookNumber; }
            set {this.bookNumber = value; }
        }

        public string Status
        {
            get {return this.status; }
            set {this.status = value; }
        }

        public string Type
        {
            get {return this.status; }
            set {this.status = value; }
        }

        public string Genre
        {
            get {return this.genre; }
            set {this.genre = value; }
        }

        public float BookFee
        {
            get { return this.bookFee; }
            set { this.bookFee = value; }
        }

        public int NumberOfBooks
        {
            get {return this.numberOfBooks; }
            set {this.numberOfBooks = value; }
        }
    }
}
