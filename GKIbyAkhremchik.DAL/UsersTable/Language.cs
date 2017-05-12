using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class Language
    {
        public Language()
        {
            gkiProfiles = new HashSet<gkiProfiles>();
        }
        public virtual ICollection<gkiProfiles> gkiProfiles { get; set; }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
