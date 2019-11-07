using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDetail = new HashSet<BillDetail>();
            Customer = new HashSet<Customer>();
        }

        public int Idbill { get; set; }
        public int? TotalPrice { get; set; }
        public int? AccountId { get; set; }
        public DateTime? DateLog { get; set; }

        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
