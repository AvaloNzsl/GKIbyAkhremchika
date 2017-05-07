using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GKIbyAkhremchik.ViewModel.Model
{
    public class gkiWorker
    {
        public int WorkerId { get; set; }

        public gkiUserModel gkiUser { get; set; }
        public int UserId { get; set; }

        public string ProfessionName { get; set; }
    }
}
