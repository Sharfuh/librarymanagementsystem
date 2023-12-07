using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace librarymanagementsystem.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal FineAmount { get; set; }
    }
}