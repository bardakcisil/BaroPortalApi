using BaroPortal.Entities.Concrete;
using BaroPortal.Entities.Concrete.Advertisement;
using BaroPortal.Entities.Concrete.Bildirimler;
using BaroPortal.Entities.Concrete.ContactUs;
using BaroPortal.Entities.Concrete.DigerUygulamalar;
using BaroPortal.Entities.Concrete.Duyurular;
using BaroPortal.Entities.Concrete.Etkinlikler;
using BaroPortal.Entities.Concrete.Haberler;
using BaroPortal.Entities.Concrete.Surveys;
using BaroPortal.Entities.Concrete.Uygulamalarımız;
using BaroPortal.Entities.Seeds;
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
        public DbSet<ContactUs>? ContactUs { get; set; }
        public DbSet<ContactUsTopic>? ContactUsTopics { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }
      public DbSet<BarSearch>? BarSearch { get; set; }
        public DbSet<Education>? Educations { get; set; }
        public DbSet<Advertisement>? Advertisements { get; set; }
        public DbSet<AdvType>? AdvertTypes { get; set; }

        public DbSet<Bildirimler>? Bildirimler { get; set; }
        public DbSet<Haberler>? Haberler { get; set; }
        public DbSet<Etkinlikler>? Etkinlikler { get; set; }
        public DbSet<Duyurular>? Duyurular { get; set; }

        public DbSet<Uygulamalarimiz>? Uygulamalarimiz { get; set; }

  

        public DbSet<Answers>? Answers { get; set; }
        public DbSet<Questions>? Questions { get; set; }
        public DbSet<Surveys>? Surveys { get; set; }

        public DbSet<SurveyOps> SurveyOps { get; set; }

        public DbSet<Court>? Court { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=baro_portal;Trusted_Connection=True;");// isil
       //optionsBuilder.UseSqlServer(@"Server=DESKTOP-I2583PH\SQLEXPRESS;Database=BaroPortalDb;Trusted_Connection=True;");// Hussain
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

            modelBuilder.Entity<ContactUs>().ToTable("ContactUs");
            modelBuilder.Entity<ContactUs>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();         
            modelBuilder.Entity<ContactUs>().Property(x => x.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<ContactUs>().Property(x => x.Surname).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<ContactUs>().Property(x => x.Message).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<ContactUs>().Property(x => x.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<ContactUs>().Property(x => x.CreateDate).IsRequired();

            modelBuilder.Entity<ContactUsTopic>().ToTable("ContactUsTopics");
            modelBuilder.Entity<ContactUsTopic>().HasMany<ContactUs>(x => x.ContactUs).WithOne(y => y.ContactUsTopic).HasForeignKey(y => y.TopicId);
            modelBuilder.Entity<ContactUsTopic>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<ContactUsTopic>().Property(x => x.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<ContactUsTopic>().Property(x => x.TopicId).IsRequired();
            modelBuilder.Entity<ContactUsTopic>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<ContactUsTopic>().HasData(ContactUsTopicSeed.advertType);


            modelBuilder.Entity<Announcement>().ToTable("Announcements");
            modelBuilder.Entity<Announcement>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Announcement>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Announcement>().Property(x => x.ImageData).HasColumnType("image");
            modelBuilder.Entity<Announcement>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Announcement>().Property(x => x.Detail).HasMaxLength(10000).IsRequired();


            modelBuilder.Entity<Education>().ToTable("Educations");
            modelBuilder.Entity<Education>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Education>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.Title).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.PdfFile).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.FileName).IsRequired();
            modelBuilder.Entity<Education>().Property(x => x.FileExtension);
            modelBuilder.Entity<Education>().Property(x => x.FilePath);
            modelBuilder.Entity<Education>().Property(x => x.FileSize);


            modelBuilder.Entity<Advertisement>().ToTable("Advertisements");
            modelBuilder.Entity<Advertisement>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Advertisement>().Property(x => x.AdvertId).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.Title).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.Description).HasMaxLength(10000).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.Advertiser).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.AdvertiserPhone).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.AdvertiserEmail).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Advertisement>().Property(x => x.CreateDate).IsRequired();


            modelBuilder.Entity<AdvType>().ToTable("AdvertTypes");
            modelBuilder.Entity<AdvType>().HasMany<Advertisement>(x => x.Advertisement).WithOne(y => y.AdvertType).HasForeignKey(y => y.TypeId);
            modelBuilder.Entity<AdvType>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<AdvType>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<AdvType>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<AdvType>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<AdvType>().HasData(AdvTypeSeed.advertType);

          modelBuilder.Entity<BarSearch>().ToTable("BarSearch");
            modelBuilder.Entity<BarSearch>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<BarSearch>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.Surname).IsRequired();
            modelBuilder.Entity<BarSearch>().Property(x => x.BaroNumber).IsRequired();
           // modelBuilder.Entity<BarSearch>().HasData(BarSearchSeed.barSearch);

            modelBuilder.Entity<Haberler>().ToTable("Haberler");
            modelBuilder.Entity<Haberler>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Haberler>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Haberler>().Property(x => x.Title).HasMaxLength(100);
            modelBuilder.Entity<Haberler>().Property(x => x.Detail).HasMaxLength(10000);
            modelBuilder.Entity<Haberler>().Property(x => x.ListImage).HasMaxLength(100);
            modelBuilder.Entity<Haberler>().Property(x => x.DetailImage).HasMaxLength(100);

            modelBuilder.Entity<Etkinlikler>().ToTable("Etkinlikler");
            modelBuilder.Entity<Etkinlikler>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Etkinlikler>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Etkinlikler>().Property(x => x.Title).HasMaxLength(100);
            modelBuilder.Entity<Etkinlikler>().Property(x => x.Detail).HasMaxLength(10000);
            modelBuilder.Entity<Etkinlikler>().Property(x => x.ListImage).HasMaxLength(100);
            modelBuilder.Entity<Etkinlikler>().Property(x => x.DetailImage).HasMaxLength(100);


            modelBuilder.Entity<Bildirimler>().ToTable("Bildirimler");
            modelBuilder.Entity<Bildirimler>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Bildirimler>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Bildirimler>().Property(x => x.Title).HasMaxLength(100);
            modelBuilder.Entity<Bildirimler>().Property(x => x.Detail).HasMaxLength(10000);
            modelBuilder.Entity<Bildirimler>().Property(x => x.ListImage).HasMaxLength(100);
            modelBuilder.Entity<Bildirimler>().Property(x => x.DetailImage).HasMaxLength(100);

            modelBuilder.Entity<Duyurular>().ToTable("Duyurular");
            modelBuilder.Entity<Duyurular>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Duyurular>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Duyurular>().Property(x => x.Title).HasMaxLength(100);
            modelBuilder.Entity<Duyurular>().Property(x => x.Detail).HasMaxLength(10000);
            modelBuilder.Entity<Duyurular>().Property(x => x.ListImage).HasMaxLength(100);
            modelBuilder.Entity<Duyurular>().Property(x => x.DetailImage).HasMaxLength(100);
            modelBuilder.Entity<Duyurular>().Property(x => x.PdfFile).IsRequired();
            modelBuilder.Entity<Duyurular>().Property(x => x.FileName).IsRequired();
            modelBuilder.Entity<Duyurular>().Property(x => x.FileExtension);
            modelBuilder.Entity<Duyurular>().Property(x => x.FilePath);
            modelBuilder.Entity<Duyurular>().Property(x => x.FileSize);

            modelBuilder.Entity<Uygulamalarimiz>().ToTable("Uygulamalarimiz");
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.Title).HasMaxLength(100);
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.ListImage).HasMaxLength(100);
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.Url).HasMaxLength(100);
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.Detail).HasMaxLength(10000);
            modelBuilder.Entity<Uygulamalarimiz>().Property(x => x.DetailImage).HasMaxLength(100);


            modelBuilder.Entity<Answers>().ToTable("Answers");
            modelBuilder.Entity<Answers>().HasMany<Questions>(x => x.Question).WithOne(y => y.Answer).HasForeignKey(y => y.AnswerId);
           modelBuilder.Entity<Answers>().HasMany<SurveyOps>(x => x.SurveyOp).WithOne(y => y.Answer).HasForeignKey(y => y.AnswerId);
            modelBuilder.Entity<Answers>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Answers>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Answers>().Property(x => x.AnswerId).HasMaxLength(100);
            modelBuilder.Entity<Answers>().Property(x => x.AnswerName).HasMaxLength(10000);
            modelBuilder.Entity<Answers>().HasData(AnswersSeed.answer);

            modelBuilder.Entity<Questions>().ToTable("Questions");
            modelBuilder.Entity<Questions>().HasMany<SurveyOps>(x => x.SurveyOp).WithOne(y => y.Question).HasForeignKey(y => y.QuestionId);
            modelBuilder.Entity<Questions>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Questions>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Questions>().Property(x => x.QuestionId).HasMaxLength(100);
            modelBuilder.Entity<Questions>().Property(x => x.QuestionTitle).HasMaxLength(10000);
            modelBuilder.Entity<Questions>().Property(x => x.QuestionDetail).HasMaxLength(10000);

            modelBuilder.Entity<Surveys>().ToTable("Surveys");
            modelBuilder.Entity<Surveys>().HasMany<Questions>(x => x.Question).WithOne(y => y.Survey).HasForeignKey(y => y.SurveyId);
            modelBuilder.Entity<Surveys>().HasMany<SurveyOps>(x => x.SurveyOp).WithOne(y => y.Survey).HasForeignKey(y => y.SurveyId);
            modelBuilder.Entity<Surveys>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Surveys>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Surveys>().Property(x => x.SurveyId).HasMaxLength(100);
            modelBuilder.Entity<Surveys>().Property(x => x.SurveyName).HasMaxLength(10000);


            modelBuilder.Entity<Court>().ToTable("Court");
            modelBuilder.Entity<Court>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<Court>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<Court>().Property(x => x.TypeId).IsRequired();
            modelBuilder.Entity<Court>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Court>().HasData(CourtSeed.court);

            modelBuilder.Entity<SurveyOps>().ToTable("SurveyOps");
            modelBuilder.Entity<SurveyOps>().Property(x => x.Id).UseIdentityColumn().ValueGeneratedOnAdd();
            modelBuilder.Entity<SurveyOps>().Property(x => x.CreateDate).IsRequired();
            modelBuilder.Entity<SurveyOps>().Property(x => x.QuestionTitle).HasMaxLength(10000);
            modelBuilder.Entity<SurveyOps>().Property(x => x.QuestionDetail).HasMaxLength(10000);







        }





    }
}
