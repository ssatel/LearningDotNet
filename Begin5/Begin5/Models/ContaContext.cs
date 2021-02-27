using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Begin5.Models
{
    public class ContaContext : DbContext
    {
        public DbSet<Conta> Conta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=new_schema;user=root;password=ml@Satel2014");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Conta>(entity =>
            {
                entity.HasKey(c => c.NumeroConta);
                entity.Property(c => c.NumeroConta).IsRequired();
                


            });

        }
    }
}
