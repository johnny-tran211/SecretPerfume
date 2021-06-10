using Microsoft.EntityFrameworkCore;
using SecretPerfume.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretPerfume.Data
{
    public class SecrectPerfumeDbContext : DbContext
    {
        public SecrectPerfumeDbContext(DbContextOptions<SecrectPerfumeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Branch
            modelBuilder.Entity<Branch>().HasMany<Product>(b => b.Products)
                .WithOne(p => p.Branch)
                .HasForeignKey(p => p.Branch_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Category
            modelBuilder.Entity<Category>().HasMany<SubCategory>(c => c.SubCategories)
                .WithOne(s => s.Category)
                .HasForeignKey(s => s.Category_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Discount
            modelBuilder.Entity<Discount>().HasMany<Product>(d => d.Products)
                .WithOne(p => p.Discount)
                .HasForeignKey(p => p.Discount_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Discount>().HasMany<OrderDetail>(d => d.OrderDetails)
                .WithOne(p => p.Discount)
                .HasForeignKey(p => p.Discount_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Discount>().HasMany<Order>(d => d.Orders)
                .WithOne(p => p.Discount)
                .HasForeignKey(p => p.Discount_Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Discount Type
            modelBuilder.Entity<DiscountType>().HasMany<Discount>(dt => dt.Discounts)
                .WithOne(d => d.DiscountType)
                .HasForeignKey(d => d.Discount_Type_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Order
            modelBuilder.Entity<Order>().HasMany<OrderDetail>(c => c.OrderDetails)
                .WithOne(od => od.Order)
                .HasForeignKey(od => od.Order_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Product
            modelBuilder.Entity<Product>().HasMany<Rating>(d => d.Ratings)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasMany<ProductImage>(d => d.ProductImages)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasMany<Comment>(d => d.Comments)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Product>().HasMany<OrderDetail>(d => d.OrderDetails)
                .WithOne(p => p.Product)
                .HasForeignKey(p => p.Product_Id)
                .OnDelete(DeleteBehavior.Cascade);


            // Role
            modelBuilder.Entity<Role>().HasMany<User>(r => r.Users)
                .WithOne(u => u.Role)
                .HasForeignKey(p => p.Role_Id)
                .OnDelete(DeleteBehavior.SetNull);
            
            // Status
            modelBuilder.Entity<Status>().HasMany<Feedback>(s => s.Feedbacks)
                .WithOne(f => f.Status)
                .HasForeignKey(f => f.Status_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Status>().HasMany<Product>(s => s.Products)
                .WithOne(p => p.Status)
                .HasForeignKey(p => p.Status_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Status>().HasMany<Branch>(s => s.Branches)
                .WithOne(b => b.Status)
                .HasForeignKey(b => b.Status_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Status>().HasMany<Order>(s => s.Orders)
                .WithOne(o => o.Status)
                .HasForeignKey(o => o.Status_Id)
                .OnDelete(DeleteBehavior.Restrict);
 
             // User
            modelBuilder.Entity<User>().HasMany<Order>(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.User_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany<Comment>(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.User_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>().HasMany<Rating>(u => u.Ratings)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.User_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // Rating
            modelBuilder.Entity<Rating>().HasKey(r => new { r.Product_Id, r.User_Id });

            // Many to Many ( Product_SubCategory )
            modelBuilder.Entity<Product>().HasMany<SubCategory>(p => p.SubCategories)
                .WithMany(s => s.Products);
 
        }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<DiscountType> DiscountTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
