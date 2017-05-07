using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Model
{
    public class gkiTeacher
    {
        public int TeacherId { get; set; }

        public gkiUserModel gkiUser { get; set; }
        public int UserId { get; set; }

        public string DesciplineName { get; set; }
    }
}
