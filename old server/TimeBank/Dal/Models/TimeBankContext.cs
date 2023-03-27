using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dal.Models
{
    public partial class TimeBankContext : DbContext
    {
        public TimeBankContext()
        {
        }

        public TimeBankContext(DbContextOptions<TimeBankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberCategory> MemberCategories { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<ReportsDetail> ReportsDetails { get; set; }
        public virtual DbSet<WaitingList> WaitingLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-EODP1E7\\SQLEXPRESS;Database=TimeBank;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AmountPeopleOffered).HasColumnName("amountPeopleOffered");

                entity.Property(e => e.Approved).HasColumnName("approved");

                entity.Property(e => e.FatherCategoryId).HasColumnName("fatherCategoryId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.HasOne(d => d.FatherCategory)
                    .WithMany(p => p.InverseFatherCategory)
                    .HasForeignKey(d => d.FatherCategoryId)
                    .HasConstraintName("FK_Categories_Categories");
            });

            modelBuilder.Entity<Member>(entity =>
            {
                entity.HasIndex(e => e.Phone, "UQ__Members__B43B145F5DA20410")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IsManager).HasColumnName("isManager");

                entity.Property(e => e.Mail)
                    .HasMaxLength(40)
                    .HasColumnName("mail")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("name")
                    .IsFixedLength(true);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("password")
                    .IsFixedLength(true);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.RemainingHours).HasColumnName("remainingHours");

                entity.Property(e => e.ToCheck).HasColumnName("toCheck");

                entity.Property(e => e.YearBorn).HasColumnName("yearBorn");
            });

            modelBuilder.Entity<MemberCategory>(entity =>
            {
                entity.ToTable("MemberCategory");

                entity.HasIndex(e => new { e.MemberId, e.CategoryId }, "UQ__MemberCa__EDEB600A9889EE38")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.ExperienceYears).HasColumnName("experienceYears");

                entity.Property(e => e.ForGroup).HasColumnName("forGroup");

                entity.Property(e => e.MaxGroup).HasColumnName("maxGroup");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.Property(e => e.MinGruop).HasColumnName("minGruop");

                entity.Property(e => e.Place)
                    .HasMaxLength(30)
                    .HasColumnName("place")
                    .IsFixedLength(true);

                entity.Property(e => e.PossibilityComeCustomerHome).HasColumnName("possibilityComeCustomerHome");

                entity.Property(e => e.RestrictionsDescription)
                    .HasMaxLength(30)
                    .HasColumnName("restrictionsDescription")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MemberCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberCategory_Categories");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.MemberCategories)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberCategory_Members");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.GiverId).HasColumnName("giverId");

                entity.Property(e => e.Hour).HasColumnName("hour");

                entity.Property(e => e.Note)
                    .HasMaxLength(100)
                    .HasColumnName("note")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Reports)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reports_MemberCategory");
            });

            modelBuilder.Entity<ReportsDetail>(entity =>
            {
                entity.HasIndex(e => new { e.GetterMemberId, e.ReportId }, "UQ__ReportsD__09B6221A6A2F8BFB")
                    .IsUnique();

                entity.HasIndex(e => new { e.GetterMemberId, e.ReportId }, "unique_report_and_waiting_report_details")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.GetterMemberId).HasColumnName("getterMemberId");

                entity.Property(e => e.ReceiverApproved).HasColumnName("receiverApproved");

                entity.Property(e => e.ReportId).HasColumnName("reportId");

                entity.HasOne(d => d.GetterMember)
                    .WithMany(p => p.ReportsDetails)
                    .HasForeignKey(d => d.GetterMemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsDetails_Members");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportsDetails)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsDetails_Reports");
            });

            modelBuilder.Entity<WaitingList>(entity =>
            {
                entity.ToTable("WaitingList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("date")
                    .HasColumnName("expiryDate");

                entity.Property(e => e.MemberId).HasColumnName("memberId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.WaitingLists)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WaitingList_Categories");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.WaitingLists)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WaitingList_Members");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
