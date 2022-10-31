using BaroPortal.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework.Context
{
    public class AppBulletinContext : DbContext
    {
        public DbSet<Bulletin> Bulletins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server =baroportaldb.caaggpsonajp.ap-northeast-1.rds.amazonaws.com;Port=5432;Database = baroportaldb; User Id=postgres; Password =12345678");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bulletin>().ToTable("Bulletins");
            modelBuilder.Entity<Bulletin>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Bulletin>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Bulletin>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.CreateDate).IsRequired().HasDefaultValueSql("NOW()");
            modelBuilder.Entity<User>().Property(x => x.CreateDate).IsRequired().HasDefaultValueSql("NOW()");
        }
    }
}
