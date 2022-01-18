using System;
using System.Collections.Generic;
using System.Text;

namespace OCPDemo
{
    public class StaffModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountCreation { get; set; } = new StaffAccount();
    }
}
