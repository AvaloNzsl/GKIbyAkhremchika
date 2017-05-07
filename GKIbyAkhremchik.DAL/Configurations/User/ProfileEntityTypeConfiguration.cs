using GKIbyAkhremchik.DAL.UsersTable;
using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.User
{
    public class ProfileEntityTypeConfiguration : EntityTypeConfiguration<UsersTable.gkiProfile>
    {
        public ProfileEntityTypeConfiguration()
        {
            HasMany(r => r.gkiUsers).WithRequired(r => r.gkiProfiles).HasForeignKey(r => r.ProfileId);
        }
    }
}
