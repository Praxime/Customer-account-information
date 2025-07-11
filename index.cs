/* Made by Praxime */
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            string email, username, password;
          
            /* Specify email, username and password here */
            email = "example@gmail.com";
            username = "Example username";
            password = "ExamplePassword1234";

            string cname, displayname;
            int pass, admin;

            /* Specify customer password here */
            admin = 1234;

            Console.Title = "Customer Account Information";
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.Clear();
            // Display name
            Console.Write("* What's your name? ");
            displayname = Console.ReadLine();
            Console.Clear();
            Console.Write("* Please enter the username: ");
            cname = Console.ReadLine();
            /* Specify customer username here */
            if (cname == "test")
            {
                Console.Write("* Please enter your password: ");
                pass = int.Parse(Console.ReadLine());
                Console.Beep(37, 250);
                if (pass == admin)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Beep(1200, 500);
                    Console.WriteLine("Welcome " + displayname);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("-= Steam account information =-");
                    Console.WriteLine("- Email: " + email);
                    Console.WriteLine("- Username: " + username);
                    Console.WriteLine("- Password: " + password);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Username or password was incorrect");
                    Console.Beep(1200, 300);
                    Console.Beep(1200, 300);
                    Console.Beep(1200, 300);
                    Console.Beep(1200, 300);
                    Console.WriteLine("Press any key to exit...");
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("This username is not specified");
                Console.Beep(1200, 300);
                Console.Beep(1200, 300);
                Console.Beep(1200, 300);
                Console.Beep(1200, 300);
                Console.WriteLine("Press any key to exit...");
            }
            Console.ReadKey(true);
        }
    }
}
