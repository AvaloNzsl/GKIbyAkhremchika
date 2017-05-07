using GKIbyAkhremchik.DAL.Configurations.User;
using GKIbyAkhremchik.DAL.UsersTable;

namespace GKIbyAkhremchik.DAL
{
    using Configurations;
    using RolesTable;
    using System.Data.Entity;

    public partial class GKIDbContext: DbContext
    {
        public GKIDbContext()
            : base("name=GKI_DataEntities")
        {
        }
        public static GKIDbContext Create()
        {
            return new GKIDbContext();
        }

        public virtual DbSet<gkiUser> gkiUsers { get; set; }
        // --->>><<<---
        public virtual DbSet<gkiProfile> gkiProfiles { get; set; }
        // --->>><<<---
        public virtual DbSet<City> qCities { get; set; }
        public virtual DbSet<Language> qLanguages { get; set; }
        public virtual DbSet<Sex> qSexes { get; set; }
        // --->>><<<---
        public virtual DbSet<AdminRole> gkiRole { get; set; }
        // --->>><<<---
        public virtual DbSet<NewsSchool> SchoolNews { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new RoleEntityTypeConfiguration());
            // --->>><<<---
            modelBuilder.Configurations.Add(new ProfileEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new SexEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new LanguageEntityTypeConfiguration());
            modelBuilder.Configurations.Add(new CityEntityTypeConfiguration());
            // --->>><<<---

        }
    }
}
