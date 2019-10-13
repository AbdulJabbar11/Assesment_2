using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Assesment_2.Models
{
    public partial class Assesment_2Context : DbContext
    {
        public Assesment_2Context()
        {
        }

        public Assesment_2Context(DbContextOptions<Assesment_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CatagoriesManagement> CatagoriesManagement { get; set; }
        public virtual DbSet<ItemManagement> ItemManagement { get; set; }
        public virtual DbSet<UserManagement> UserManagement { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=ABDULJABBARGUJJ\\MSSQLSERVR;Database=Assesment_2;Trusted_Connection=True;User ID=sa; Password=jabbar786;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CatagoriesManagement>(entity =>
            {
                entity.ToTable("Catagories_management");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Picture)
                    .IsRequired()
                    .HasColumnName("picture");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemManagement>(entity =>
            {
                entity.ToTable("Item_management");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatagoryId).HasColumnName("catagoryID");

                entity.Property(e => e.Costprice)
                    .HasColumnName("costprice")
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50);

                entity.Property(e => e.Itemcode)
                    .HasColumnName("itemcode")
                    .HasMaxLength(50);

                entity.Property(e => e.Maincolor)
                    .HasColumnName("maincolor")
                    .HasMaxLength(50);

                entity.Property(e => e.Mainlmage).HasColumnName("mainlmage");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasMaxLength(50);

                entity.Property(e => e.Saleprice)
                    .HasColumnName("saleprice")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserManagement>(entity =>
            {
                entity.ToTable("User_management");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Displayname)
                    .HasColumnName("displayname")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.ProfilePicture).HasColumnName("profilePicture");

                entity.Property(e => e.RegisteredDate)
                    .HasColumnName("registeredDate")
                    .HasColumnType("date");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });
        }
    }
}
