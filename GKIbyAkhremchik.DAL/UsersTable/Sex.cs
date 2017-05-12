using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class Sex
    {
        public Sex()
        {
            gkiProfiles = new HashSet<gkiProfiles>();
        }
        public virtual ICollection<gkiProfiles> gkiProfiles { get; set; }

        public int SexId { get; set; }
        public string SexName { get; set; }
    }
}
