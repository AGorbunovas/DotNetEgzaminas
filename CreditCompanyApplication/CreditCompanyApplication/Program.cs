using CreditCompanyApplication.Controller;
using System;

namespace CreditCompanyApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sveiki vartotojau. Iveskite savo duomenis.");
            Console.Write("Iveskite savo varda: ");
            var firstName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Iveskite savo pavarde: ");
            var lastName = Console.ReadLine();

            var userController = new UserController(firstName, lastName);
            userController.Save();
        }
    }
}
