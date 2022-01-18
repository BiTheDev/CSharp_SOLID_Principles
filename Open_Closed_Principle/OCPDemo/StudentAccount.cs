using System;
using System.Collections.Generic;
using System.Text;

namespace OCPDemo
{
    public class StudentAccount : IAccounts
    {
        public MemberModel Create(IPersonModel person)
        {
            MemberModel member = new MemberModel();

            member.FirstName = person.FirstName;
            member.LastName = person.LastName;
            member.Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@staffemail.com";

            member.IsStudent = true;

            return member;
        }
    }
}
