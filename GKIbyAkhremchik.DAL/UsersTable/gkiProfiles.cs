using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class gkiProfiles
    {
        public gkiProfiles()
        {
            gkiUsers = new HashSet<gkiUsers>();
        }
        public virtual ICollection<gkiUsers> gkiUsers { get; set; }

        public int ProfileId { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public decimal Mobile { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string About { get; set; }
        public string Activity { get; set; }

        public int LanguageId { get; set; }
        public int CityId { get; set; }
        public int SexId { get; set; }

        public virtual Language Language { get; set; }
        public virtual City     City { get; set; }
        public virtual Sex      Sex { get; set; }
    }
}
