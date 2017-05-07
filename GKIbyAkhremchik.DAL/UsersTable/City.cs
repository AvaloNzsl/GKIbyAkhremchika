using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class City
    {
        public City()
        {
            gkiProfiles = new HashSet<gkiProfile>();
        }
        public virtual ICollection<gkiProfile> gkiProfiles { get; set; }

        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
