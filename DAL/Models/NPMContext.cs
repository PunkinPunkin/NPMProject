using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class NPMContext : DbContext
    {
        public NPMContext()
        {
        }

        public NPMContext(DbContextOptions<NPMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<OrgInfos> OrgInfos { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<UserInfos> UserInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=MyDB;Persist Security Info=False;User ID=josh;Password=5a45nF9uW6;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog", "db_owner");

                entity.Property(e => e.Url).IsRequired();
            });

            modelBuilder.Entity<OrgInfos>(entity =>
            {
                entity.HasKey(e => e.OrgId);

                entity.ToTable("OrgInfos", "db_owner");

                entity.Property(e => e.OrgAddress).HasMaxLength(100);

                entity.Property(e => e.OrgName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post", "db_owner");

                entity.HasOne(d => d.Blog)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.BlogId);
            });

            modelBuilder.Entity<UserInfos>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10);
            });
        }
    }
}
