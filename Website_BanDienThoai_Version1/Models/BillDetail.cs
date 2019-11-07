using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class BillDetail
    {
        public int Idbill { get; set; }
        public int ProductId { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual Bill IdbillNavigation { get; set; }
        public virtual Product Product { get; set; }
    }
}
