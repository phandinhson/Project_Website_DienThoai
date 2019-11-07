using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public int? AccountId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Gender { get; set; }

        public virtual Account Account { get; set; }
        public virtual Bill AccountNavigation { get; set; }
    }
}
