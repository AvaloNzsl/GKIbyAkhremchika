using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.RolesTable
{
    public partial class AdminRole
    {
        public AdminRole()
        {
            gkiUsers = new HashSet<UsersTable.gkiUsers>();
        }
        public virtual ICollection<UsersTable.gkiUsers> gkiUsers { get; set; }
        
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
