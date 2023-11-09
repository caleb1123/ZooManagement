using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BusinessLayer.Models
{
    public partial class zooContext : DbContext
    {
        public zooContext()
        {
        }

        public zooContext(DbContextOptions<zooContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<Animal> Animals { get; set; } = null!;
        public virtual DbSet<AnimalCage> AnimalCages { get; set; } = null!;
        public virtual DbSet<Cage> Cages { get; set; } = null!;
        public virtual DbSet<CageArea> CageAreas { get; set; } = null!;
        public virtual DbSet<Diet> Diets { get; set; } = null!;
        public virtual DbSet<Experience> Experiences { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Species> Species { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<ZooArea> ZooAreas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database =zoo;uid=sa;pwd=12345;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__Account__D03DEDCB1628BF16");

                entity.ToTable("Account");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.IdRole).HasColumnName("Id_Role");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("User_Name");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK__Account__Id_Role__398D8EEE");
            });

            modelBuilder.Entity<Animal>(entity =>
            {
                entity.HasKey(e => e.IdAnimal)
                    .HasName("PK__Animal__B37EB51A5AF82CA0");

                entity.ToTable("Animal");

                entity.Property(e => e.IdAnimal).HasColumnName("Id_Animal");

                entity.Property(e => e.AnimalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Animal_Name");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDiet).HasColumnName("Id_Diet");

                entity.Property(e => e.IdSpecies).HasColumnName("Id_species");

                entity.Property(e => e.Nickname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("nickname");

                entity.Property(e => e.Size)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDietNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdDiet)
                    .HasConstraintName("FK__Animal__Id_Diet__46E78A0C");

                entity.HasOne(d => d.IdSpeciesNavigation)
                    .WithMany(p => p.Animals)
                    .HasForeignKey(d => d.IdSpecies)
                    .HasConstraintName("FK__Animal__Weight__45F365D3");
            });

            modelBuilder.Entity<AnimalCage>(entity =>
            {
                entity.ToTable("Animal_Cage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAnimal).HasColumnName("Id_animal");

                entity.Property(e => e.IdCage).HasColumnName("Id_Cage");

                entity.HasOne(d => d.IdAnimalNavigation)
                    .WithMany(p => p.AnimalCages)
                    .HasForeignKey(d => d.IdAnimal)
                    .HasConstraintName("FK__Animal_Ca__Id_an__4BAC3F29");

                entity.HasOne(d => d.IdCageNavigation)
                    .WithMany(p => p.AnimalCages)
                    .HasForeignKey(d => d.IdCage)
                    .HasConstraintName("FK__Animal_Ca__Id_Ca__4CA06362");
            });

            modelBuilder.Entity<Cage>(entity =>
            {
                entity.HasKey(e => e.IdCage)
                    .HasName("PK__Cage__A7BCA2250A7EAEBB");

                entity.ToTable("Cage");

                entity.Property(e => e.IdCage).HasColumnName("Id_Cage");

                entity.Property(e => e.CageName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cage_Name");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CageArea>(entity =>
            {
                entity.ToTable("Cage_Area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdArea).HasColumnName("Id_Area");

                entity.Property(e => e.IdCage).HasColumnName("Id_Cage");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.CageAreas)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("FK__Cage_Area__Id_Ar__52593CB8");

                entity.HasOne(d => d.IdCageNavigation)
                    .WithMany(p => p.CageAreas)
                    .HasForeignKey(d => d.IdCage)
                    .HasConstraintName("FK__Cage_Area__Id_Ca__5165187F");
            });

            modelBuilder.Entity<Diet>(entity =>
            {
                entity.HasKey(e => e.IdDiet)
                    .HasName("PK__Diet__101B4ECCD71AD573");

                entity.ToTable("Diet");

                entity.Property(e => e.IdDiet).HasColumnName("Id_Diet");

                entity.Property(e => e.FoodFrequecy)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("food_Frequecy");

                entity.Property(e => e.FoodQuantity).HasColumnName("food_quantity");

                entity.Property(e => e.IdFood).HasColumnName("Id_Food");

                entity.HasOne(d => d.IdFoodNavigation)
                    .WithMany(p => p.Diets)
                    .HasForeignKey(d => d.IdFood)
                    .HasConstraintName("FK__Diet__food_quant__4316F928");
            });

            modelBuilder.Entity<Experience>(entity =>
            {
                entity.ToTable("Experience");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdAnimal).HasColumnName("Id_Animal");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("Start_Date");

                entity.HasOne(d => d.IdAnimalNavigation)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.IdAnimal)
                    .HasConstraintName("FK__Experienc__Id_An__5535A963");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Experienc__Id_Us__5629CD9C");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.IdFood)
                    .HasName("PK__Food__E10088B0188B5C0A");

                entity.ToTable("Food");

                entity.Property(e => e.IdFood).HasColumnName("Id_Food");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FoodName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Food_Name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Role__34ADFA60F2275908");

                entity.ToTable("Role");

                entity.Property(e => e.IdRole).HasColumnName("Id_Role");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Species>(entity =>
            {
                entity.HasKey(e => e.IdSpecies)
                    .HasName("PK__Species__4919762BB7136151");

                entity.Property(e => e.IdSpecies).HasColumnName("Id_Species");

                entity.Property(e => e.SpeciesName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Species_Name");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.HasKey(e => e.IdTicket)
                    .HasName("PK__Ticket__2CE8F3C7FA16DA64");

                entity.ToTable("Ticket");

                entity.Property(e => e.IdTicket).HasColumnName("Id_Ticket");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.IdUser).HasColumnName("Id_User");

                entity.Property(e => e.QuantityAdult).HasColumnName("Quantity_Adult");

                entity.Property(e => e.QuantityChild).HasColumnName("Quantity_Child");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Ticket__Id_User__3C69FB99");
            });

            modelBuilder.Entity<ZooArea>(entity =>
            {
                entity.HasKey(e => e.IdArea)
                    .HasName("PK__Zoo_Area__9C42D7FE154E0286");

                entity.ToTable("Zoo_Area");

                entity.Property(e => e.IdArea).HasColumnName("Id_Area");

                entity.Property(e => e.AreaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Area_Name");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("description");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
