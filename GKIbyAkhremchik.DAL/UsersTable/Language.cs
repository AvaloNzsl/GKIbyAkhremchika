using System.Collections.Generic;

namespace GKIbyAkhremchik.DAL.UsersTable
{
    public partial class Language
    {
        public Language()
        {
            gkiProfiles = new HashSet<gkiProfile>();
        }
        public virtual ICollection<gkiProfile> gkiProfiles { get; set; }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
