using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Product
    {
        public Product()
        {
            BillDetail = new HashSet<BillDetail>();
            Category = new HashSet<Category>();
            Comment = new HashSet<Comment>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Picture { get; set; }
        public int? Memory { get; set; }
        public int? Quantity { get; set; }
        public int? Capacity { get; set; }
        public string Manufacturer { get; set; }
        public string Color { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<Category> Category { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
    }
}
