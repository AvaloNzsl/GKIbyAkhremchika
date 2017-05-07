using GKIbyAkhremchik.DAL.UsersTable;
using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.User
{
    public class SexEntityTypeConfiguration : EntityTypeConfiguration<Sex>
    {
        public SexEntityTypeConfiguration()
        {
            HasMany(r => r.gkiProfiles).WithOptional(r => r.Sex).HasForeignKey(r => r.SexId);
        }
    }
}
