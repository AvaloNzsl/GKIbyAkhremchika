using GKIbyAkhremchik.DAL.Configurations.User;
using GKIbyAkhremchik.DAL.UsersTable;

namespace GKIbyAkhremchik.DAL
{
    using Configurations;
    using Configurations.NewsContent;
    using RolesTable;
    using System.Data.Entity;

    public partial class GKIDbContext: DbContext
    {
        //Connect to the database using Entity Framework
        //data context is used - the output from the DbContext
        public GKIDbContext()
            : base("name=GKI_DataEntities")
        {
            //connection to the database GKI_DataEntities
            //the connection string is stored Web.config in the project
            //in the section configuration - where the connection string to the database is determined
        }
        public static GKIDbContext Create()
        {
            return new GKIDbContext();
        }

        public virtual DbSet<gkiUser> gkiUsers { get; set; }
        // --->>><<<---
        public virtual DbSet<gkiProfile> gkiProfiles { get; set; }
        // --->>><<<---
        public virtual DbSet<qCity> qCities { get; set; }
        public virtual DbSet<qLanguage> qLanguages { get; set; }
        public virtual DbSet<qSex> qSexes { get; set; }
        // --->>><<<---
        public virtual DbSet<gkiRole> gkiRoles { get; set; }
        // --->>><<<---
        public virtual DbSet<NewsSchool> SchoolNews { get; set; }
        public virtual DbSet<NewsArt> ArtNews { get; set; }
        public virtual DbSet<NewsMusical> MusicalNews { get; set; }
        public virtual DbSet<NewsEvent> EvemtNews { get; set; }
        // --->>><<<---
        public virtual DbSet<AlbumPhoto> AlbumPhotoes { get; set; }
        public virtual DbSet<GalleryVideo> GalleryVideos { get; set; }
        public virtual DbSet<GalleryPhoto> GalleryPhotoes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new RoleEntityTypeConfiguration());
            // --->>><<<---
            modelBuilder.Configurations.Add(new ProfileEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SexEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new LanguageEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new CityEntityTypeConfiguration());
            // --->>><<< ---
            modelBuilder.Configurations.Add(new GalleryPhotoEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new GalleryVideoEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new AlbumPhotoEntityTypeConfiguration());
        }
    }
}
