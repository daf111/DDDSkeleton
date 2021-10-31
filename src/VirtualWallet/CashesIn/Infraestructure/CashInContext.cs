using Company.src.Shared.Domain.ValueObject;
using Company.src.VirtualWallet.CashesIn.Domain;
using Company.src.VirtualWallet.CashesIn.Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.src.VirtualWallet.CashesIn.Infraestructure
{
    public class CashInContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<CashIn> CashesIn { get; set; }

        public CashInContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            object p = modelBuilder.Entity<CashIn>(x =>
            {
                x.ToTable("CashIn").HasKey(k => k.Id);
                x.Property(p => p.Id)
                    .HasConversion(p => p.Value, p => (IdentityValueObject)IdentityValueObject.Create(p).Value);
                x.Property(p => p.Name)
                    .HasConversion(p => p.Value, p => (CashInName)CashInName.Create(p).Value);
            });
        }
    }
}
