using System.Data.Entity;
using Zextia.Entities;

namespace Zextia.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
         : base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSupplement> ProductSupplements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<Product>()
                .Property(p => p.Code)
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
               .HasRequired(p => p.Detail)
               .WithRequiredPrincipal(pd => pd.Product)   
               .WillCascadeOnDelete(true);

            modelBuilder.Entity<ProductDetail>()
                .HasKey(pd => pd.Id);

            modelBuilder.Entity<ProductDetail>()
                .Property(pd => pd.Description)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<ProductSupplement>()
                .HasKey(ps => ps.Id);

            modelBuilder.Entity<ProductSupplement>()
                .Property(ps => ps.Batches)
                .HasMaxLength(100);

            modelBuilder.Entity<ProductSupplement>()
                .HasRequired(ps => ps.Product)
                .WithMany(p => p.Supplements)
                .HasForeignKey(ps => ps.ProductId);
        }
    }
}
