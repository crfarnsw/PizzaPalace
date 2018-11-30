using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaPalace.Models
{
    public partial class PizzaPalacedbContext : DbContext
    {
        public PizzaPalacedbContext()
        {
        }

        public PizzaPalacedbContext(DbContextOptions<PizzaPalacedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Beverage> Beverage { get; set; }
        public virtual DbSet<BeverageOrder> BeverageOrder { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<PizzaOrder> PizzaOrder { get; set; }
        public virtual DbSet<PizzaToppings> PizzaToppings { get; set; }
        public virtual DbSet<Side> Side { get; set; }
        public virtual DbSet<SideOrder> SideOrder { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<Toppings> Toppings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:csi3450db.database.windows.net,1433;Initial Catalog=PizzaPalacedb;Persist Security Info=False;User ID=system;Password=PizzaPalace3450;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beverage>(entity =>
            {
                entity.Property(e => e.BeverageId).HasColumnName("BeverageID");

                entity.Property(e => e.BeverageName).HasMaxLength(1);

                entity.Property(e => e.BeveragePrice).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<BeverageOrder>(entity =>
            {
                entity.ToTable("Beverage_Order");

                entity.Property(e => e.BeverageOrderId).HasColumnName("BeverageOrderID");

                entity.Property(e => e.BeverageId).HasColumnName("BeverageID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.HasOne(d => d.Beverage)
                    .WithMany(p => p.BeverageOrder)
                    .HasForeignKey(d => d.BeverageId)
                    .HasConstraintName("FK__Beverage___Bever__04E4BC85");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.BeverageOrder)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK__Beverage___Order__03F0984C");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderItem)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderItem__Order__6D0D32F4");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__693CA210");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Orders__StoreID__6A30C649");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.Property(e => e.PizzaPrice).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<PizzaOrder>(entity =>
            {
                entity.ToTable("Pizza_Order");

                entity.Property(e => e.PizzaOrderId).HasColumnName("PizzaOrderID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.PizzaId).HasColumnName("PizzaID");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.OrderItemId)
                    .HasConstraintName("FK__Pizza_Ord__Order__72C60C4A");

                entity.HasOne(d => d.Pizza)
                    .WithMany(p => p.PizzaOrder)
                    .HasForeignKey(d => d.PizzaId)
                    .HasConstraintName("FK__Pizza_Ord__Pizza__73BA3083");
            });

            modelBuilder.Entity<PizzaToppings>(entity =>
            {
                entity.HasKey(e => e.PizzaToppingId);

                entity.ToTable("Pizza_Toppings");

                entity.Property(e => e.PizzaToppingId).HasColumnName("Pizza_ToppingID");

                entity.Property(e => e.PizzaOrderId).HasColumnName("PizzaOrderID");

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.HasOne(d => d.PizzaOrder)
                    .WithMany(p => p.PizzaToppings)
                    .HasForeignKey(d => d.PizzaOrderId)
                    .HasConstraintName("FK__Pizza_Top__Pizza__797309D9");

                entity.HasOne(d => d.Topping)
                    .WithMany(p => p.PizzaToppings)
                    .HasForeignKey(d => d.ToppingId)
                    .HasConstraintName("FK__Pizza_Top__Toppi__787EE5A0");
            });

            modelBuilder.Entity<Side>(entity =>
            {
                entity.Property(e => e.SideId).HasColumnName("SideID");

                entity.Property(e => e.SideName).HasMaxLength(50);

                entity.Property(e => e.SidePrice).HasColumnType("decimal(5, 2)");
            });

            modelBuilder.Entity<SideOrder>(entity =>
            {
                entity.ToTable("Side_Order");

                entity.Property(e => e.SideOrderId).HasColumnName("SideOrderID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.SideId).HasColumnName("SideID");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.SideOrder)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Side_Orde__Order__7E37BEF6");

                entity.HasOne(d => d.Side)
                    .WithMany(p => p.SideOrder)
                    .HasForeignKey(d => d.SideId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Side_Orde__SideI__7F2BE32F");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(50);

                entity.Property(e => e.StorePhoneNumber).HasMaxLength(10);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Toppings>(entity =>
            {
                entity.HasKey(e => e.ToppingId);

                entity.Property(e => e.ToppingId).HasColumnName("ToppingID");

                entity.Property(e => e.ToppingName).HasMaxLength(50);
            });
        }
    }
}
