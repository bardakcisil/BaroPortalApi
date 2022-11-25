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
        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<Advert>? Adverts { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }
        public DbSet<Event>? Events  { get; set; }
        public DbSet<BarSearch>? BarSearch { get; set; }
        public DbSet<New>? News { get; set; }
        public DbSet<Education>? Educations { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BaroPortal;Trusted_Connection=True;");// isil
             optionsBuilder.UseSqlServer(@"Server=DESKTOP-I2583PH\SQLEXPRESS;Database=BaroPortaltest;Trusted_Connection=True;");// Hussain
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

            modelBuilder.Entity<New>().ToTable("News");
            modelBuilder.Entity<New>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<New>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<New>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<New>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<New>().Property(x => x.image).IsRequired();

            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<Event>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Event>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Event>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Event>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<Event>().Property(x => x.image).IsRequired();

            modelBuilder.Entity<Announcement>().ToTable("Announcements");
            modelBuilder.Entity<Announcement>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Announcement>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Announcement>().Property(x => x.ImageData).HasColumnType("image");
            modelBuilder.Entity<Announcement>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Announcement>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();

            modelBuilder.Entity<Notification>().ToTable("Notifications");
            modelBuilder.Entity<Notification>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Notification>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Notification>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Notification>().Property(x => x.Detail).HasMaxLength(10000000).IsRequired();

            modelBuilder.Entity<Education>().ToTable("Educations");
            modelBuilder.Entity<Education>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Education>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.PdfFile).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.FileName).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.FileExtension);
            modelBuilder.Entity<Education>().Property(x => x.FilePath);
            modelBuilder.Entity<Education>().Property(x => x.FileSize);


            modelBuilder.Entity<BarSearch>().ToTable("BarSearch");
            modelBuilder.Entity<BarSearch>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<BarSearch>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.Surname).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.BaroNumber).IsRequired();
            
        }





    }
}
