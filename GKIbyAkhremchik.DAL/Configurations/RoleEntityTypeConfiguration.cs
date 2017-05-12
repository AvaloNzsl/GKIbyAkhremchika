using GKIbyAkhremchik.DAL.RolesTable;
using System.Data.Entity.ModelConfiguration;

namespace GKIbyAkhremchik.DAL.Configurations
{
    public class RoleEntityTypeConfiguration : EntityTypeConfiguration<AdminRole>
    {
        public RoleEntityTypeConfiguration()
        {
            HasMany(r => r.gkiUsers).WithRequired(r => r.gkiRole).HasForeignKey(r => r.RoleId);
        }
    }
}
