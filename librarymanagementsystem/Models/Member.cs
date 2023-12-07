using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace librarymanagementsystem.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string MembershipStatus { get; set; }
    }
}