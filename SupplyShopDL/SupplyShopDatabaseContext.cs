using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SupplyShop;
using SupplyShopModels;



namespace SupplyShopDL
{
    public partial class SupplyShopDatabaseContext : DbContext
    {
        public SupplyShopDatabaseContext()
        {
        }

        public SupplyShopDatabaseContext(DbContextOptions<SupplyShopDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<LineItems> LineItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<StoreFront> StoreFronts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.HasKey(e => e.CustomerId)
                    .HasName("Pk_CustomerId");

                entity.Property(e => e.CustCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_City");

                entity.Property(e => e.CustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_Email");

                entity.Property(e => e.CustPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cust_Phone");

                entity.Property(e => e.CustState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_State");

                entity.Property(e => e.CustStreetAdd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cust_StreetAdd");

                entity.Property(e => e.CustZip).HasColumnName("cust_Zip");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Customer_Name");
            });

            modelBuilder.Entity<LineItems>(entity =>
            {

                entity.ToTable("LineItems");

                entity.HasKey(e => e.LineItemID)
                    .HasName("Pk_LineItemID");

                entity.Property(e => e.LineItemID).HasColumnName("LineItemID");

                entity.Property(e => e.OrdersID).HasColumnName("OrdersID");

                entity.Property(e => e.ProductID).HasColumnName("ProductID");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.OrdersID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frkey_orderID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LineItems)
                    .HasForeignKey(d => d.ProductID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("frk_ProductID");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderID)
                    .HasName("Pk_OrdersID");

                entity.Property(e => e.OrderID).HasColumnName("OrdersID");

                entity.Property(e => e.CustomerID).HasColumnName("CustomerID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_StoreID");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.Property(e => e.ProductID).HasColumnName("ProductID");

                entity.HasKey(e => e.ProductID)
                    .HasName("Pk_ProductID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");

                entity.Property(e => e.ItemDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("itemDesc");

                entity.Property(e => e.itemName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("itemName");

                entity.Property(e => e.itemPrice).HasColumnName("itemPrice");

                entity.Property(e => e.itemQuanity).HasColumnName("prodQuantity");

                entity.Property(e => e.StoreID).HasColumnName("StoreID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.StoreID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fok_StoreID");
            });

            modelBuilder.Entity<StoreFront>(entity =>
            {
                entity.HasKey(e => e.StoreID)
                    .HasName("primary_key_StoreID");

                entity.ToTable("StoreFront");

                entity.Property(e => e.StoreID).HasColumnName("StoreID");

                entity.Property(e => e.StreetAdd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Store_City");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Store_State");

                entity.Property(e => e.Zip).HasColumnName("Store_Zip");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
