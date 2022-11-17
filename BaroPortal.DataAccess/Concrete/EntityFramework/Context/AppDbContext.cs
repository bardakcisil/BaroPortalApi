using BaroPortal.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaroPortal.DataAccess.Concrete.EntityFramework.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Bulletin>? Bulletins { get; set; }
        public DbSet<Advert>? Adverts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-I2583PH\SQLEXPRESS;Database=BaroPortaltest;Trusted_Connection=True;"); //Hussain
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-I2583PH\SQLEXPRESS;Database=BaroPortaltest;Trusted_Connection=True;");// isil
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.LastName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.IdentityNumber).HasMaxLength(11).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.PasswordHash).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.PasswordSalt).IsRequired();

            modelBuilder.Entity<Advert>().ToTable("Adverts");
            modelBuilder.Entity<Advert>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
             modelBuilder.Entity<Advert>().Property(x => x.AdvertId).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertTypeName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertiserName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertiserSname).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertiserLwork).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.ConscriptionStatus).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertiserPhone).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advert>().Property(x => x.AdvertiserEmail).HasMaxLength(100).IsRequired();
           

        }





    }
}
