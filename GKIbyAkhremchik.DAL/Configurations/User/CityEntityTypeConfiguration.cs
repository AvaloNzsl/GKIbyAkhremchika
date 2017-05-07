using GKIbyAkhremchik.DAL.UsersTable;
using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.User
{
    public class CityEntityTypeConfiguration : EntityTypeConfiguration<City>
    {
        public CityEntityTypeConfiguration()
        {
            HasMany(r => r.gkiProfiles).WithOptional(r => r.City).HasForeignKey(r => r.CityId);
        }
    }
}
