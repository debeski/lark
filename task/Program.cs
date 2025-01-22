using System;

namespace task
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            if (Login(username, password))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
        }

        public static bool Login(string username, string password)
        {
            // Dummy credentials for demonstration
            string validUsername = "admin";
            string validPassword = "password123";

            return username == validUsername && password == validPassword;
        }
    }
}
