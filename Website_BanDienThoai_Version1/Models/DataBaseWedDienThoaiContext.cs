using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Website_BanDienThoai_Version1.Models
{
    public partial class DataBaseWedDienThoaiContext : DbContext
    {
        public DataBaseWedDienThoaiContext()
        {
        }

        public DataBaseWedDienThoaiContext(DbContextOptions<DataBaseWedDienThoaiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-LRIE6A1;Initial Catalog=DataBaseWedDienThoai;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.Idbill)
                    .HasName("PK__Bill__23BDC1E6B8FBA457");

                entity.Property(e => e.Idbill).HasColumnName("IDBill");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DateLog).HasColumnType("datetime");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasKey(e => new { e.Idbill, e.ProductId })
                    .HasName("PK__Bill_Det__E8FD0D88B0EB8FCC");

                entity.ToTable("Bill_Detail");

                entity.Property(e => e.Idbill).HasColumnName("IDBill");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.IdbillNavigation)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.Idbill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill_Deta__IDBil__47DBAE45");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill_Deta__Produ__48CFD27E");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Category_Product");
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CommentId1).HasColumnName("Comment_ID");

                entity.Property(e => e.DateLog).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Comment__Account__3F466844");

                entity.HasOne(d => d.CommentId1Navigation)
                    .WithMany(p => p.InverseCommentId1Navigation)
                    .HasForeignKey(d => d.CommentId1)
                    .HasConstraintName("FK__Comment__Comment__403A8C7D");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Comment__DateLog__3E52440B");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(69);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Customer__Accoun__398D8EEE");

                entity.HasOne(d => d.AccountNavigation)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Customer_Bill");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Manufacturer).HasMaxLength(20);

                entity.Property(e => e.Picture).HasMaxLength(200);

                entity.Property(e => e.ProductName).HasMaxLength(200);
            });
        }
    }
}
