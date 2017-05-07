using GKIbyAkhremchik.DAL.UsersTable;
using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations.User
{
    public class LanguageEntityTypeConfiguration : EntityTypeConfiguration<Language>
    {
        public LanguageEntityTypeConfiguration()
        {
            HasMany(r => r.gkiProfiles).WithOptional(r => r.Language).HasForeignKey(r => r.LanguageId);
        }
    }
}
