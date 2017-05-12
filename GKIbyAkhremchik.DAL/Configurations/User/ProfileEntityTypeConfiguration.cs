using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.User
{
    public class ProfileEntityTypeConfiguration : EntityTypeConfiguration<gkiProfile>
    {
        public ProfileEntityTypeConfiguration()
        {
            HasMany(r => r.gkiUsers).WithRequired(r => r.gkiProfile).HasForeignKey(r => r.ProfileId);
        }
    }
}
