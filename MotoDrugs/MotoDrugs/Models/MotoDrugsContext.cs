using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MotoDrugs.Models
{
    public partial class MotoDrugsContext : DbContext
    {
        public MotoDrugsContext()
        {
        }

        public MotoDrugsContext(DbContextOptions<MotoDrugsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allowance> Allowances { get; set; }
        public virtual DbSet<AllowanceEmployee> AllowanceEmployees { get; set; }
        public virtual DbSet<Attribute> Attributes { get; set; }
        public virtual DbSet<ChequeEquipment> ChequeEquipments { get; set; }
        public virtual DbSet<ChequeTech> ChequeTeches { get; set; }
        public virtual DbSet<ChequeTechPayment> ChequeTechPayments { get; set; }
        public virtual DbSet<ClientMan> ClientMen { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<EquipmentShowcase> EquipmentShowcases { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemIncoming> ItemIncomings { get; set; }
        public virtual DbSet<ItemInformation> ItemInformations { get; set; }
        public virtual DbSet<ItemsChequeEkip> ItemsChequeEkips { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Recovery> Recoverys { get; set; }
        public virtual DbSet<RecoveryEmployee> RecoveryEmployees { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Stemp> Stemps { get; set; }
        public virtual DbSet<TypeItem> TypeItems { get; set; }
        public virtual DbSet<TypePayment> TypePayments { get; set; }
        public virtual DbSet<Vacantion> Vacantions { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Allowance>(entity =>
            {
                entity.HasKey(e => e.IdAllowance)
                    .HasName("PK__Allowanc__C00DF9EDCD714E34");

                entity.ToTable("Allowance");

                entity.Property(e => e.IdAllowance).HasColumnName("Id_allowance");

                entity.Property(e => e.NameTypeAllowance)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_type_Allowance");

                entity.Property(e => e.SummAllowance)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Summ_allowance");
            });

            modelBuilder.Entity<AllowanceEmployee>(entity =>
            {
                entity.HasKey(e => e.IdAllowanceEmployee)
                    .HasName("PK__Allowanc__24795DB936DAAFFD");

                entity.ToTable("Allowance_Employee");

                entity.Property(e => e.IdAllowanceEmployee).HasColumnName("Id_allowance_Employee");

                entity.Property(e => e.IdAllowance).HasColumnName("id_Allowance");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");
                               
                    });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.HasKey(e => e.IdAttribute)
                    .HasName("PK__Attribut__47B6642AEABF7AEC");

                entity.ToTable("Attribute");

                entity.Property(e => e.IdAttribute).HasColumnName("Id_attribute");

                entity.Property(e => e.NameAttribute)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("Name_attribute");
            });

            modelBuilder.Entity<ChequeEquipment>(entity =>
            {
                entity.HasKey(e => e.IdNumCheque)
                    .HasName("PK__Cheque_E__0C7151638ED0D183");

                entity.ToTable("Cheque_Equipment");

                entity.Property(e => e.IdNumCheque).HasColumnName("Id_numCheque");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

               
            });

            modelBuilder.Entity<ChequeTech>(entity =>
            {
                entity.HasKey(e => e.IdChequeTech)
                    .HasName("PK__Cheque_T__A56601C878D79138");

                entity.ToTable("Cheque_Tech");

                entity.Property(e => e.IdChequeTech).HasColumnName("id_Cheque_Tech");

                entity.Property(e => e.IdChequeTechPayment).HasColumnName("id_Cheque_Tech_Payment");

                entity.Property(e => e.IdItem).HasColumnName("id_Item");

                
            });

            modelBuilder.Entity<ChequeTechPayment>(entity =>
            {
                entity.HasKey(e => e.IdCeque)
                    .HasName("PK__Cheque_T__3BA86DFDAD20A85E");

                entity.ToTable("Cheque_Tech_Payment");

                entity.Property(e => e.IdCeque).HasColumnName("Id_ceque");

                entity.Property(e => e.Addressr)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.IdTypePayment).HasColumnName("id_Type_Payment");

               
            });

            modelBuilder.Entity<ClientMan>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("PK__Client_M__F08F1F767EC07D57");

                entity.ToTable("Client_Man");

                entity.Property(e => e.IdClient).HasColumnName("id_Client");

                entity.Property(e => e.NameClient)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name_Client");

                entity.Property(e => e.NumberPhone).HasColumnName("Number_Phone");

                entity.Property(e => e.PassportClient).HasColumnName("passport_Client");

                entity.Property(e => e.PatronymicClient)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("patronymic_Client");

                entity.Property(e => e.SurnameClient)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("surname_Client");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.IdEmployee)
                    .HasName("PK__Employee__938D4B1087B8D920");

                entity.ToTable("Employee");

                entity.Property(e => e.IdEmployee).HasColumnName("Id_Employee");

                entity.Property(e => e.IdPost).HasColumnName("id_Post");

                entity.Property(e => e.Logins)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("logins");

                entity.Property(e => e.NameEmployee)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name_Employee");

                entity.Property(e => e.PasswordEmployee)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("password_employee");

                entity.Property(e => e.PatronymicEmployee)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("patronymic_Employee");

                entity.Property(e => e.SurnameEmployee)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("surname_Employee");

              
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => e.IdEquipment)
                    .HasName("PK__Equipmen__DC7CBD1232A1FF41");

                entity.Property(e => e.IdEquipment).HasColumnName("Id_equipment");

                entity.Property(e => e.DescriptionEquipment)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("Description_equipment");

                entity.Property(e => e.NameEquipment)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("Name_equipment");
            });

            modelBuilder.Entity<EquipmentShowcase>(entity =>
            {
                entity.HasKey(e => e.IdEquipmentShowcase)
                    .HasName("PK__Equipmen__AB51D7E3F990F998");

                entity.ToTable("Equipment_Showcase");

                entity.Property(e => e.IdEquipmentShowcase).HasColumnName("id_Equipment_Showcase");

                entity.Property(e => e.Cost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

               
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("PK__Item__911E3CD006C93A2B");

                entity.ToTable("Item");

                entity.Property(e => e.IdItem).HasColumnName("Id_item");

                entity.Property(e => e.IdTypeItem).HasColumnName("id_type_item");

                entity.Property(e => e.NameItem)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_item");

                entity.Property(e => e.QuantityItem).HasColumnName("Quantity_item");

                
            });

            modelBuilder.Entity<ItemIncoming>(entity =>
            {
                entity.HasKey(e => e.IdIncoming)
                    .HasName("PK__Item_Inc__C42F9D2FCFBA8256");

                entity.ToTable("Item_Incoming");

                entity.Property(e => e.IdIncoming).HasColumnName("Id_incoming");

                entity.Property(e => e.CostItem).HasColumnName("Cost_item");

                entity.Property(e => e.DateSending)
                    .HasColumnType("date")
                    .HasColumnName("Date_sending");

                entity.Property(e => e.IdItem).HasColumnName("id_Item");

                entity.Property(e => e.IdProvider).HasColumnName("id_Provider");

               
            });

            modelBuilder.Entity<ItemInformation>(entity =>
            {
                entity.HasKey(e => e.IdEquipment)
                    .HasName("PK__Item_Inf__DC7CBD12F306F6DE");

                entity.ToTable("Item_Information");

                entity.Property(e => e.IdEquipment).HasColumnName("Id_equipment");

                entity.Property(e => e.NumAttribute).HasColumnName("num_Attribute");

                entity.Property(e => e.NumEquipment).HasColumnName("num_Equipment");

                entity.Property(e => e.NumItem).HasColumnName("num_Item");

                entity.Property(e => e.NumStemp).HasColumnName("num_Stemp");

              
            });

            modelBuilder.Entity<ItemsChequeEkip>(entity =>
            {
                entity.HasKey(e => e.IdItemsChequeEkip)
                    .HasName("PK__Items_Ch__756DEDFC05EECC09");

                entity.ToTable("Items_Cheque_Ekip");

                entity.Property(e => e.IdItemsChequeEkip).HasColumnName("id_Items_Cheque_Ekip");

                entity.Property(e => e.IdChequeEkip).HasColumnName("Id_Cheque_Ekip");

                entity.Property(e => e.IdItemEkip).HasColumnName("Id_Item_Ekip");

               
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.IdPost)
                    .HasName("PK__Post__5CB61D3ECC5538D4");

                entity.ToTable("Post");

                entity.Property(e => e.IdPost).HasColumnName("Id_post");

                entity.Property(e => e.IdSalary).HasColumnName("id_Salary");

                entity.Property(e => e.NamePost)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name_Post");

            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.IdProvider)
                    .HasName("PK__Provider__E8B2F94B0EC36914");

                entity.ToTable("Provider");

                entity.Property(e => e.IdProvider).HasColumnName("Id_provider");

                entity.Property(e => e.NameProvider)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_provider");
            });

            modelBuilder.Entity<Recovery>(entity =>
            {
                entity.HasKey(e => e.IdRecovery)
                    .HasName("PK__Recovery__ECB95022736194CE");

                entity.Property(e => e.IdRecovery).HasColumnName("Id_recovery");

                entity.Property(e => e.NameTypeRecovery)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_type_Recovery");

                entity.Property(e => e.SummRecovery)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("Summ_recovery");
            });

            modelBuilder.Entity<RecoveryEmployee>(entity =>
            {
                entity.HasKey(e => e.IdRecoveryEmployee)
                    .HasName("PK__Recovery__AD5EF798E11DD19A");

                entity.ToTable("Recovery_Employee");

                entity.Property(e => e.IdRecoveryEmployee).HasColumnName("Id_recovery_Employee");

                entity.Property(e => e.IdEmployee).HasColumnName("id_Employee");

                entity.Property(e => e.IdRecovery).HasColumnName("id_Recovery");

              
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.HasKey(e => e.IdSalary)
                    .HasName("PK__Salary__0A8A705199D85454");

                entity.ToTable("Salary");

                entity.Property(e => e.IdSalary).HasColumnName("Id_salary");

                entity.Property(e => e.MaxSalary)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("max_Salary");

                entity.Property(e => e.MinSalary)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("min_Salary");
            });

            modelBuilder.Entity<Stemp>(entity =>
            {
                entity.HasKey(e => e.IdStemp)
                    .HasName("PK__Stemp__FC465DF8CEC317BF");

                entity.ToTable("Stemp");

                entity.Property(e => e.IdStemp).HasColumnName("Id_stemp");

                entity.Property(e => e.NameStemp)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("Name_stemp");
            });

            modelBuilder.Entity<TypeItem>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("PK__Type_ite__74C1FDF65E0211EA");

                entity.ToTable("Type_item");

                entity.Property(e => e.IdType).HasColumnName("Id_type");

                entity.Property(e => e.NameType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Name_type");
            });

            modelBuilder.Entity<TypePayment>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("PK__Type_Pay__862FEFE05C22944D");

                entity.ToTable("Type_Payment");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.NameType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("name_Type");
            });

            modelBuilder.Entity<Vacantion>(entity =>
            {
                entity.HasKey(e => e.IdVacation)
                    .HasName("PK__Vacantio__1C7837AEB5A357C1");

                entity.ToTable("Vacantion");

                entity.Property(e => e.IdVacation).HasColumnName("Id_vacation");

                entity.Property(e => e.EndVacation)
                    .HasColumnType("date")
                    .HasColumnName("End_vacation");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.StartVacation)
                    .HasColumnType("date")
                    .HasColumnName("Start_vacation");

              
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.IdItemsInWarehouse)
                    .HasName("PK__Warehous__788F31B30455EAE3");

                entity.ToTable("Warehouse");

                entity.Property(e => e.IdItemsInWarehouse).HasColumnName("Id_items_in_warehouse");

                entity.Property(e => e.IdItemForWarhouse).HasColumnName("id_item_for_warhouse");

                entity.Property(e => e.QuantityWarehouse).HasColumnName("Quantity_warehouse");

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
