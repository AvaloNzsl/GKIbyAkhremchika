using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Model
{
    public class gkiProfileModel
    {
        public int ProfileId { get; set; }
        public string Avatar { get; set; }
        public string Thumb { get; set; }
        public Nullable<decimal> Mobile { get; set; }
        public Nullable<int> Year { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Day { get; set; }
        public string About { get; set; }
        public string Activity { get; set; }

        public Nullable<int> LanguageId { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> SexId { get; set; }
    }
}
