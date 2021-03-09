using Begin5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Infra
{
    public class Context : DbContext
    {
        public DbSet<ContaRepository> Conta {get;set;}

        public DbSet<Usuario> Usuario { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=new_schema;user=root;password=ml@Satel2014");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ContaRepository>(entity =>
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
