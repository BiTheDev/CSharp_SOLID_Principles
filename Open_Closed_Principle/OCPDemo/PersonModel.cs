using System;
using System.Collections.Generic;
using System.Text;

namespace OCPDemo
{
    public class PersonModel : IPersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IAccounts AccountCreation { get; set; } = new Accounts();

    }

}
