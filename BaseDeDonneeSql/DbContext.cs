using BaseDeDonneeSql.FlightPriceNameSpace;
using BaseDeDonneeSql.Lotterie;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace BaseDeDonneeSql
{
    public partial class DbContextGarneau : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContextGarneau()
        {

        }
        public DbContextGarneau(DbContextOptions<DbContextGarneau> options)
            : base(options)
        {
        }
        public Microsoft.EntityFrameworkCore.DbSet<FlightPrice> FlightPrices { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<BouleNumero> ListeBoulesNumero { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<BilletLotterieEntity> BilletLotteries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Database=FormationC#Ezo;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
       
    }
}