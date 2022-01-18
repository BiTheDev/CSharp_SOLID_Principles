using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class Instructor : IInstructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
    }
}
