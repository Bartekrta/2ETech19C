using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class LibraryManagmentSystem
    {
        public string UserType, Username, Password;

        public void Login()
        {
            Console.WriteLine("Login");
        }
        public void Register()
        {
            Console.WriteLine("Register");
        }
        public void Logout()
        {
            Console.WriteLine("Logout");
        }
    }
    internal class User
    {
        public string Name;
        public int ID;

        public void Verify()
        {
            Console.WriteLine("Verify");
        }
        public void CheckAccount()
        {
            Console.WriteLine("Check account");
        }
        public void get_book_info()
        {
            Console.WriteLine("Get book info");
        }
    }
    internal class Account
    {
        public bool no_borrowed_books, no_reserved_books, no_returned_books, no_lost_books, fine_amount;

        public void Calculate_fine()
        {
            Console.WriteLine("Fine");
        }
    }
    internal class Book
    {
        public string title, Author, ISBN, Publication;

        public void Show_duedt()
        {
            Console.WriteLine("Due time");
        }
        public void Reservation_status()
        {
            Console.WriteLine("Reservation_status");
        }
        public void Feedback()
        {
            Console.WriteLine("Feedback");
        }
        public void Book_request()
        {
            Console.WriteLine("Book_request");
        }
        public void Renw_info()
        {
            Console.WriteLine("Renew info");
        }
    }
    internal class Librarian
    {
        public string Name, Password, SearchString;
        public int ID;

        public void Verify_librarian()
        {
            Console.WriteLine("Verified");
        }
        public void Search()
        {
            Console.WriteLine("Found");
        }
    }
    internal class Library_DataBase
    {
        public List<string> List_Of_Books = new List<string>();

        public void Add()
        {
            Console.WriteLine("Add");
        }
        public void Delete()
        {
            Console.WriteLine("Delete");
        }
        public void Update()
        {
            Console.WriteLine("Update");
        }
        public void Display()
        {
            Console.WriteLine("Display");
        }
        public void Search()
        {
            Console.WriteLine("Search");
        }

    }

    internal class Student
    {
        public string Class;
    }
    internal class Staff
    {
        public string Dept;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
