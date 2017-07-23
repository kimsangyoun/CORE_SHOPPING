using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CORE_SHOPPING.Models
{
    public partial class shopingContext : DbContext
    {
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("input your connection string here");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandNum);

                entity.ToTable("BRAND");

                entity.Property(e => e.BrandNum)
                    .HasColumnName("BRAND_NUM")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("BRAND_NAME")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CstNum);

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.CstNum)
                    .HasColumnName("CST_NUM")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CstAddress)
                    .HasColumnName("CST_ADDRESS")
                    .HasMaxLength(250);

                entity.Property(e => e.CstEmail)
                    .HasColumnName("CST_EMAIL")
                    .HasMaxLength(50);

                entity.Property(e => e.CstGrade)
                    .HasColumnName("CST_GRADE")
                    .HasColumnType("char(50)");

                entity.Property(e => e.CstId)
                    .HasColumnName("CST_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CstName)
                    .HasColumnName("CST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.CstPhone)
                    .HasColumnName("CST_PHONE")
                    .HasMaxLength(50);

                entity.Property(e => e.CstPwd)
                    .HasColumnName("CST_PWD")
                    .HasMaxLength(50);

                entity.Property(e => e.CstReserve)
                    .HasColumnName("CST_RESERVE")
                    .HasMaxLength(50);

                entity.Property(e => e.CstUsed)
                    .HasColumnName("CST_USED")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PdtNum);

                entity.ToTable("PRODUCT");

                entity.HasIndex(e => e.PdtBrand)
                    .HasName("BRAND_REFER");

                entity.Property(e => e.PdtNum)
                    .HasColumnName("PDT_NUM")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.PdtBrand)
                    .HasColumnName("PDT_BRAND")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PdtName)
                    .IsRequired()
                    .HasColumnName("PDT_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.PdtPrice)
                    .HasColumnName("PDT_PRICE")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PdtSale)
                    .HasColumnName("PDT_SALE")
                    .HasColumnType("int(11) unsigned");

                entity.Property(e => e.PdtType)
                    .IsRequired()
                    .HasColumnName("PDT_TYPE")
                    .HasColumnType("char(50)");

                entity.Property(e => e.PdtUsed)
                    .HasColumnName("PDT_USED")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.PdtBrandNavigation)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.PdtBrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("brand");
            });
        }
    }
}