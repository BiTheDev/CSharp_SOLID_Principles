using System;
using System.Collections.Generic;

namespace OCPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IPersonModel> people = new List<IPersonModel>
            {
                new PersonModel { FirstName = "John", LastName = "Doe"},
                new StaffModel { FirstName = "Anna", LastName = "Lee"},
                new StudentModel { FirstName = "Jack", LastName = "House"}
            };

            List<MemberModel> members = new List<MemberModel>();
            foreach (var person in people)
            {
                members.Add(person.AccountCreation.Create(person));
            }

            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} {member.Email} IsStaff: {member.IsStaff} IsStudent: {member.IsStudent}");
            }
        }
    }
}
