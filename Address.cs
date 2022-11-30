using System.Security.Cryptography;

namespace ConsoleApp2
{

    class Account
    {
        protected string emailAddress;
        protected string name;
        public string getEmailAddress()
        {
            return "email";
        }
        public string getName()
        {
            return "name";
        }
        public void setEmailAddress()
        {
            Console.WriteLine("Set Email Address");
        }
        public void setName()
        {
            Console.WriteLine("Set name");
        }
    }
    class AddressBook
    {
        protected string name;
        
        public Contact getContact()
        {
            Contact c = new Contact();
            return c;
        }
        public Contact getContacts()
        {
            Contact c = new Contact();
            return c;
        }
        public string getName()
        {
            return "name";
        }
        public void insertContact(string contact)
        {
            Console.WriteLine("Inserted");
        }
        public void setName(string name)
        {
            Console.WriteLine("Set name");
        }
    }
    class Contact
    {
        protected string emailAddress;
        protected string faxNumber;
        protected string name;
        protected string primaryContactMethod;
        public string getEmailAddress()
        {
            return "email";
        }
        public string getFaxNumber()
        {
            return "number";
        }
        public string getName()
        {
            return "name";
        }
        public string getPrimaryContactMethod()
        {
            return "method";
        }
        public void setEmailAddress(string email)
        {
            Console.WriteLine("set email");
        }
        public void setFaxNumber(string fax)
        {
            Console.WriteLine("set fax");
        }
        public void setName(string name)
        {
            Console.WriteLine("set name");
        }
        public void setPrimaryContactMethod()
        {
            Console.WriteLine("Set method");
        }
    }
    class ContactGroup
    {
        protected string name;
        public string getName()
        {
            return "name";
        }
        public void setName(string name)
        {
            Console.WriteLine("Set name");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
