using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Account
    {
        public Account()
        {
            Comment = new HashSet<Comment>();
            Customer = new HashSet<Customer>();
        }

        public int AccountId { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
