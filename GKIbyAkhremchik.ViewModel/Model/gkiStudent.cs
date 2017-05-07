using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Model
{
    public class gkiStudent
    {

        public int StudentId { get; set; }

        public gkiUserModel gkiUser { get; set; }
        public int UserId { get; set; }

        public string GroupName { get; set; }

        public List<gkiParent> gkiParents { get; set; }

    }
}
