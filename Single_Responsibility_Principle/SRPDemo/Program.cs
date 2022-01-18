using System;

namespace SRPDemo
{
     class Program
    {
        static void Main(string[] args)
        {
            Messages.WelcomeMessage();

            Person user = PersonData.Received();

            Messages.ConfirmMessage(user.Name, user.Email);
        }
    }
}
