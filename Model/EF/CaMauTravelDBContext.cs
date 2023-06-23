using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model.EF
{
    public partial class CaMauTravelDBContext : DbContext
    {
        public CaMauTravelDBContext()
            : base("name=CaMauTravelDBContext")
        {
        }

        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategory> NewsCategories { get; set; }
        public virtual DbSet<Oder> Oders { get; set; }
        public virtual DbSet<OderDetail> OderDetails { get; set; }
        public virtual DbSet<PlaceType> PlaceTypes { get; set; }
        public virtual DbSet<Touri> Touris { get; set; }
        public virtual DbSet<TourisAttrDetail> TourisAttrDetails { get; set; }
        public virtual DbSet<TouristAttraction> TouristAttractions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<Account>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<News>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<NewsCategory>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<NewsCategory>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<Oder>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<OderDetail>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PlaceType>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<PlaceType>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<Touri>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Touri>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Touri>()
                .Property(e => e.PromotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Touri>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Touri>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();

            modelBuilder.Entity<TourisAttrDetail>()
                .HasMany(e => e.Touris)
                .WithOptional(e => e.TourisAttrDetail)
                .HasForeignKey(e => e.TourisDetailID);

            modelBuilder.Entity<TouristAttraction>()
                .Property(e => e.MetaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TouristAttraction>()
                .Property(e => e.MetaDescription)
                .IsFixedLength();
        }
    }
}
