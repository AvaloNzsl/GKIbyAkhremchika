using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Model
{
    public class gkiParent
    { 
        public int ParentId { get; set; }

        public gkiUserModel gkiUser { get; set; }
        public int UserId { get; set; }

        public string WorkName { get; set; }

        public Nullable<int> StudentId { get; set; }
        public gkiStudent gkiStudent { get; set; }
    }
}
