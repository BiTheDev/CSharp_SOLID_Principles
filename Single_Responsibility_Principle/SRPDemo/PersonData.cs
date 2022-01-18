using System;
using System.Collections.Generic;
using System.Text;

namespace SRPDemo
{
    public class PersonData
    {
        public static Person Received()
        {

            Person user = new Person();

            Messages.AskForName();
            user.Name = Console.ReadLine();

            Messages.AskForEmail();
            user.Email = Console.ReadLine();
            return user;
        } 
    }
}
