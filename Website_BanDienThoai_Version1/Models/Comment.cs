using System;
using System.Collections.Generic;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class Comment
    {
        public Comment()
        {
            InverseCommentId1Navigation = new HashSet<Comment>();
        }

        public int CommentId { get; set; }
        public int? ProductId { get; set; }
        public int? AccountId { get; set; }
        public string Content { get; set; }
        public DateTime? DateLog { get; set; }
        public int? CommentId1 { get; set; }

        public virtual Account Account { get; set; }
        public virtual Comment CommentId1Navigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Comment> InverseCommentId1Navigation { get; set; }
    }
}
