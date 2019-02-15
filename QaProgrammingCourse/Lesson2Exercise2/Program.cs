using System;

namespace Lesson2Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dbPassword = "P@55w0rd";
            string dbUserName = "UserName";
            int i;
            Console.WriteLine("Type your username and password and hit Enter to submit.");
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine("Username:");
                string userName = Console.ReadLine();
                Console.WriteLine("Password:");
                string password = Console.ReadLine();
                if (userName == dbUserName && password == dbPassword) {
                    Console.WriteLine("You are logged in successful");
                    Console.ReadKey();
                    return;
                }
                else Console.WriteLine("Username or password entered is incorrect!");
            }
            if (i > 3)
            {
                Console.WriteLine("You typed wrong credentials three times! " +
                "\nBrute Force detected! CyberPolice is informed!" +
                "\nProgram will be closed.");
                Console.ReadKey();
            }
        }
    }
}
