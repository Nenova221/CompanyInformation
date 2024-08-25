using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInformation
{
    public class CompanyInformation
    {
        static void Main()
        {
            Console.Write("Enter company Name: ");
            string CompanyName = Console.ReadLine();
            Console.Write("Enter company Address: ");
            string CompanyAddress = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            int CompanyNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter company fax number: ");
            int CompanyFaxNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter company WebSite: ");
            string CompanyWebSite = Console.ReadLine();
            Console.Write("Enter company Manager: ");
            string Manager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string ManagerFirstName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string ManagerSecondName = Console.ReadLine();
            Console.Write("Enter manager phone number :");
            int ManagerNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Firm: Name - {0}, Address - {1}, PhoneNumber - {2}, FaxNumber - {3}, Website - {4}, Manager - {5}", CompanyName, CompanyAddress, CompanyNumber, CompanyFaxNumber, CompanyWebSite, Manager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", ManagerFirstName, ManagerSecondName, ManagerNumber);
        }
    }
}
