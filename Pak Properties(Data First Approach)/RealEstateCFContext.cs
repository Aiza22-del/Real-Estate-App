using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace CodeFirstApproach
{
	public partial class RealEstateCFContext : DbContext
	{
		public RealEstateCFContext()
		{
		}

		public RealEstateCFContext(DbContextOptions<RealEstateCFContext> options)
			: base(options)
		{
		}

		public virtual DbSet<Admin> Admins { get; set; }

		public virtual DbSet<Property> Properties { get; set; }

		public virtual DbSet<Society> Societies { get; set; }

		public virtual DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
			=> optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RealEstateCF;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Admin>(entity =>
			{
				entity.HasKey(e => e.Id).HasName("PK__Admin__3214EC0712351D1B");

				entity.ToTable("Admin");

				entity.Property(e => e.City)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Email)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Password)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			modelBuilder.Entity<Property>(entity =>
			{
				entity.HasKey(e => e.Id).HasName("PK__Property__3214EC07F85F7403");

				entity.ToTable("Property");

				entity.Property(e => e.Address)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.AreaSize)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.City)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Status)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Type)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.UserId).HasColumnName("UserID");

				entity.HasOne(d => d.User).WithMany(p => p.Properties)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Property_User");
			});

			modelBuilder.Entity<Society>(entity =>
			{
				entity.HasKey(e => e.Id).HasName("PK__Society__3214EC07C2E257D0");

				entity.ToTable("Society");

				entity.Property(e => e.Address)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.City)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.PriceIndex)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Properties)
					.HasMaxLength(50)
					.IsUnicode(false)
					.HasColumnName("properties");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.HasKey(e => e.Id).HasName("PK__User__3214EC07FCDB594D");

				entity.ToTable("User");

				entity.Property(e => e.BuyerStatus)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.City)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.ContactNo)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Email)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.IsUnicode(false);
				entity.Property(e => e.Password)
					.HasMaxLength(10)
					.IsUnicode(false);
				entity.Property(e => e.SalerStatus)
					.HasMaxLength(50)
					.IsUnicode(false);
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
