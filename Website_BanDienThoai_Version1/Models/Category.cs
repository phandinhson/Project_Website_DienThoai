using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Category
    {
        public int CategoryId { get; set; }
        public int? ProductId { get; set; }
        public string CategoryName { get; set; }

        public virtual Product Product { get; set; }
    }
}
