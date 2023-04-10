using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _14._3._3.Program;

namespace _14._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var phoneBook = new List<Contact>();
           
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            var sortedContacts = phoneBook.OrderBy(s => s.Name).ThenBy(s => s.LastName);

            foreach (var Cont in sortedContacts)

                Console.WriteLine(Cont.Name + ", " + Cont.LastName);
        }
        public class Contact
        {
            public Contact(string name, string lastName, long phoneNumber, String email)
            {
                Name = name;
                LastName = lastName;
                PhoneNumber = phoneNumber;
                Email = email;
            }
            public String Name { get; set; }
            public String LastName { get; set; }
            public long PhoneNumber { get; set; }
            public String Email { get; set; }
        }
    }
}



