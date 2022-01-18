using System;
using System.Collections.Generic;
using System.Text;

namespace SRPDemo
{
    public class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to demo application!!");
        }

        public static void AskForName()
        {
            Console.WriteLine("Please enter your name: ");
        }

        public static void AskForEmail()
        {
            Console.WriteLine("Please enter your email: ");
        }
        public static void ConfirmMessage(string name, string email)
        {
            Console.WriteLine($"Welcome to the service. Your name is {name} and your email is {email}");
        }
    }
}
