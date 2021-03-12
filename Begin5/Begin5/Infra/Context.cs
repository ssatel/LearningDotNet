using Begin5.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Begin5.Infra
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Conta> Conta {get;set;}

        public DbSet<Usuario> Usuario { get; set;}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        // //   optionsBuilder.UseMySQL("server=localhost;database=new_schema;user=root;password=ml@Satel2014");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.HasKey(c => c.NumeroConta);
                entity.Property(c => c.NumeroConta).IsRequired();

            });

            modelBuilder.Entity<Usuario>(entity => 
            {
                entity.HasKey(u => u.UserID);
                entity.Property(u => u.UserID).IsRequired();

            });
        }
    }
}
