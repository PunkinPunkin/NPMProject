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

        public virtual DbSet<NpmItem> NpmItem { get; set; }
        public virtual DbSet<NpmItemWorksRelation> NpmItemWorksRelation { get; set; }
        public virtual DbSet<NpmPCollection> NpmPCollection { get; set; }
        public virtual DbSet<NpmPSubject> NpmPSubject { get; set; }
        public virtual DbSet<NpmPTitle> NpmPTitle { get; set; }
        public virtual DbSet<NpmPainting> NpmPainting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.188.72;Initial Catalog=NPM_DAMS;Persist Security Info=False;User ID=npm_sa;Password=npm_sa!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<NpmItem>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("NPM_ITEM");

                entity.HasIndex(e => e.CollectionUnicode)
                    .HasName("idx_npm_item3");

                entity.HasIndex(e => e.Department)
                    .HasName("idx_npm_item1");

                entity.HasIndex(e => e.RegisterType)
                    .HasName("idx_npm_item4");

                entity.HasIndex(e => new { e.Palace, e.Catalog, e.ItemNo, e.ItemAddedNo })
                    .HasName("idx_npm_item2");

                entity.Property(e => e.AcceptedDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AccessoryName).HasMaxLength(40);

                entity.Property(e => e.AccessoryQuantity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Author).HasMaxLength(400);

                entity.Property(e => e.CancelDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CancelDocumentNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CancelFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CancelReason).HasMaxLength(2000);

                entity.Property(e => e.Catalog)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckFinish)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Checker).HasMaxLength(40);

                entity.Property(e => e.CollectType).HasMaxLength(10);

                entity.Property(e => e.CollectionUnicode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.CurrentBox)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCloset1)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCloset2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCloset3)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentPosition).HasMaxLength(50);

                entity.Property(e => e.CurrentStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Department)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentNo)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DocWordNo).HasMaxLength(100);

                entity.Property(e => e.Dynasty)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Era)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExhibitDimension).HasMaxLength(255);

                entity.Property(e => e.ForeignCurrencyType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAddedNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNoEnd)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNoStart)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.Property(e => e.LiteratureNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Material).HasMaxLength(100);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Ntcurrency).HasColumnName("NTCurrency");

                entity.Property(e => e.OriginalCollectUnit).HasMaxLength(40);

                entity.Property(e => e.OriginalCollector).HasMaxLength(80);

                entity.Property(e => e.OriginalEnglishTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalForeignTitle).HasMaxLength(500);

                entity.Property(e => e.OriginalNo)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalPosition)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalPrice)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRegGroupNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRegNo)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalShPost)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalSource).HasMaxLength(800);

                entity.Property(e => e.OriginalStatus).HasMaxLength(80);

                entity.Property(e => e.OriginalTitleName).HasMaxLength(400);

                entity.Property(e => e.OriginalTwPost).HasMaxLength(80);

                entity.Property(e => e.PaintingCheckDate).HasColumnType("datetime");

                entity.Property(e => e.PaintingCheckFinish)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaintingChecker).HasMaxLength(40);

                entity.Property(e => e.Palace)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PositionDescription).HasMaxLength(100);

                entity.Property(e => e.PreviousExhibitDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousVisitDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterDimension)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterStaff).HasMaxLength(50);

                entity.Property(e => e.RegisterType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisterWeight)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ShanghaiBox1).HasMaxLength(10);

                entity.Property(e => e.ShanghaiBox2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Shape).HasMaxLength(100);

                entity.Property(e => e.Source)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SouthRegisterNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StoreRoomName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StoreRoomNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(40);

                entity.Property(e => e.Style2).HasMaxLength(20);

                entity.Property(e => e.SubOriginalNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TaiwanBox1).HasMaxLength(10);

                entity.Property(e => e.TaiwanBox2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TaiwanBox3)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TempBox)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TempClass)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TijianStatus).HasMaxLength(80);

                entity.Property(e => e.Times).HasMaxLength(50);

                entity.Property(e => e.TitleName).HasMaxLength(400);

                entity.Property(e => e.TotalRegisterNo1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegisterNo2)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegisterNo3)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegisterNo4)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegisterNoEnd)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalRegisterNoStart)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.UtensilsChkRptName).HasMaxLength(100);

                entity.Property(e => e.UtensilsCurrentBox1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UtensilsCurrentBox2)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.UtensilsCurrentBox3)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedClass)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VerifiedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NpmItemWorksRelation>(entity =>
            {
                entity.HasKey(e => e.RelationId);

                entity.ToTable("NPM_ITEM_WORKS_RELATION");

                entity.HasIndex(e => e.ItemId)
                    .HasName("idx_NPM_ITEM_WORKS_RELATION2");

                entity.HasIndex(e => e.PaintingId)
                    .HasName("idx_NPM_ITEM_WORKS_RELATION1");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.NpmItemWorksRelation)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPM_ITEM_WORKS_RELATION2");

                entity.HasOne(d => d.Painting)
                    .WithMany(p => p.NpmItemWorksRelation)
                    .HasForeignKey(d => d.PaintingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPM_ITEM_WORKS_RELATION1");
            });

            modelBuilder.Entity<NpmPCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.ToTable("NPM_P_COLLECTION");

                entity.HasIndex(e => e.PaintingId)
                    .HasName("idx_NPM_P_COLLECTION1");

                entity.Property(e => e.CollectionType).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.HasOne(d => d.Painting)
                    .WithMany(p => p.NpmPCollection)
                    .HasForeignKey(d => d.PaintingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPM_P_COLLECTION");
            });

            modelBuilder.Entity<NpmPSubject>(entity =>
            {
                entity.HasKey(e => e.SubjectId);

                entity.ToTable("NPM_P_SUBJECT");

                entity.HasIndex(e => e.PaintingId)
                    .HasName("idx_NPM_P_SUBJECT1");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.Property(e => e.Subject1).HasMaxLength(20);

                entity.Property(e => e.Subject2).HasMaxLength(20);

                entity.Property(e => e.SubjectType).HasMaxLength(20);

                entity.HasOne(d => d.Painting)
                    .WithMany(p => p.NpmPSubject)
                    .HasForeignKey(d => d.PaintingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPM_P_SUBJECT");
            });

            modelBuilder.Entity<NpmPTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.ToTable("NPM_P_TITLE");

                entity.HasIndex(e => e.PaintingId)
                    .HasName("idx_NPM_P_TITLE1");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleType).HasMaxLength(10);

                entity.HasOne(d => d.Painting)
                    .WithMany(p => p.NpmPTitle)
                    .HasForeignKey(d => d.PaintingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NPM_P_TITLE");
            });

            modelBuilder.Entity<NpmPainting>(entity =>
            {
                entity.HasKey(e => e.PaintingId);

                entity.ToTable("NPM_PAINTING");

                entity.Property(e => e.Catalog)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CheckDate).HasColumnType("datetime");

                entity.Property(e => e.CheckFinish)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Checker).HasMaxLength(40);

                entity.Property(e => e.CreatationTime).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedIp)
                    .HasColumnName("CreatedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Creator).HasMaxLength(40);

                entity.Property(e => e.DataOpen)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemAddedNo)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.LastModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedIp)
                    .HasColumnName("LastModifiedIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifier).HasMaxLength(40);

                entity.Property(e => e.Palace)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Quantity).HasMaxLength(200);

                entity.Property(e => e.SeriesFu).HasMaxLength(50);

                entity.Property(e => e.SeriesJian).HasMaxLength(10);

                entity.Property(e => e.SeriesKai).HasMaxLength(50);

                entity.Property(e => e.SeriesType).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(4);
            });
        }
    }
}
