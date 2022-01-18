using System;
using System.Collections.Generic;
using System.Text;

namespace OCPDemo
{
    public class StaffAccount : IAccounts
    {
        public MemberModel Create(IPersonModel person)
        {
            MemberModel member = new MemberModel();

            member.FirstName = person.FirstName;
            member.LastName = person.LastName;
            member.Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@staffemail.com";

            member.IsStaff = true;

            return member;
        }
    }
}
