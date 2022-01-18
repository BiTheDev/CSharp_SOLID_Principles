using System;
using System.Collections.Generic;
using System.Text;

namespace OCPDemo
{
    public class MemberModel : PersonModel
    {
        public string Email { get; set; }
        public bool IsStaff { get; set; }
        public bool IsStudent { get; set; }
    }
}
