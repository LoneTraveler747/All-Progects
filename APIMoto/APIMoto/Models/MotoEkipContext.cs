using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace APIMoto.Models
{
    public partial class MotoEkipContext : DbContext
    {
        public MotoEkipContext()
        {
        }

        public MotoEkipContext(DbContextOptions<MotoEkipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Kassa> Kassas { get; set; }
        public virtual DbSet<NameShop> NameShops { get; set; }
        public virtual DbSet<Pay> Pays { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PurchaseOfGood> PurchaseOfGoods { get; set; }
        public virtual DbSet<Storage> Storages { get; set; }
        public virtual DbSet<TypeProduct> TypeProducts { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployees)
                    .HasName("PK_Num_Employees");

                entity.Property(e => e.IdEmployees).HasColumnName("ID_Employees");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("First_Name");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Last_Name");

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Middle_Name")
                    .HasDefaultValueSql("('-')");

                entity.Property(e => e.PassportData)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Passport_data");

                entity.Property(e => e.Logins)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Logins");

                entity.Property(e => e.PasswordEmployee)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PasswordEmployee");
            });

            modelBuilder.Entity<Kassa>(entity =>
            {
                entity.HasKey(e => e.IdKassa)
                    .HasName("PK_ID_Kassa");

                entity.ToTable("Kassa");

                entity.Property(e => e.IdKassa).HasColumnName("ID_Kassa");

                entity.Property(e => e.DataStartChange)
                    .HasColumnType("datetime")
                    .HasColumnName("Data_start_change");

                entity.Property(e => e.DateEndChange)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_end_change");

                entity.Property(e => e.IdEmployees).HasColumnName("ID_Employees");
            });

            modelBuilder.Entity<NameShop>(entity =>
            {
                entity.HasKey(e => e.IdShop)
                    .HasName("PK_Name_magazin");

                entity.ToTable("Name_Shop");

                entity.Property(e => e.IdShop).HasColumnName("ID_Shop");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pay>(entity =>
            {
                entity.HasKey(e => e.IdPay)
                    .HasName("PK_ID_Pay");

                entity.ToTable("Pay");

                entity.Property(e => e.IdPay).HasColumnName("ID_Pay");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdEmployees).HasColumnName("ID_Employees");

                entity.Property(e => e.IdNameMagazin).HasColumnName("ID_Name_magazin");

                entity.Property(e => e.IdTovara).HasColumnName("ID_tovara");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).HasColumnName("Post_ID");

                entity.Property(e => e.NamePost)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_Post");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ArticleNumberaId)
                    .HasName("PK_Number_Product");

                entity.ToTable("Product");

                entity.Property(e => e.ArticleNumberaId).HasColumnName("Article_Numbera_ID");

                entity.Property(e => e.IdType).HasColumnName("ID_Type");

                entity.Property(e => e.NameOfItem)
                    .IsRequired()
                    .IsUnicode(false)
                    .HasColumnName("Name_of_item");
            });

            modelBuilder.Entity<PurchaseOfGood>(entity =>
            {
                entity.HasKey(e => e.IdParachase)
                    .HasName("PK_Nomer_zakupki_tovara");

                entity.ToTable("Purchase_of_goods");

                entity.Property(e => e.IdParachase).HasColumnName("ID_Parachase");

                entity.Property(e => e.ArticleNumber).HasColumnName("Article_Number");

                entity.Property(e => e.Data).HasColumnType("date");

                entity.Property(e => e.ValuesOfGoods).HasColumnName("Values_of_goods");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.HasKey(e => e.ArticleNumberss)
                    .HasName("PK_Sklad_ID_tovar");

                entity.ToTable("Storage");

                entity.Property(e => e.ArticleNumberss).HasColumnName("Article_Numberss");

                entity.Property(e => e.ArticleNumber).HasColumnName("Article_Number");
            });

            modelBuilder.Entity<TypeProduct>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK_ID_Type");

                entity.ToTable("Type_product");

                entity.Property(e => e.IdType).HasColumnName("ID_Type");

                entity.Property(e => e.NameType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Name_Type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
