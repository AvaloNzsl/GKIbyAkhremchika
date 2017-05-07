using System.Collections.Generic;
using System.Linq;

namespace GKIbyAkhremchik.DAL.Context
{
    public class UserContext
    {
        private GKIDbContext _contextUser;
        public UserContext()
        {
            _contextUser = new GKIDbContext();
        }
        public UserContext(GKIDbContext contextUser)
        {
            _contextUser = contextUser;
        }

        public IEnumerable<gkiUser> GetAllUsers()
        {
            return _contextUser.gkiUsers.ToList();
            //var getUser = from gU in _contextUser.gkiUsers
            //              select gU;
            //return getUser;
        }
        public IEnumerable<gkiProfile> GetAllProfiles()
        {
            return _contextUser.gkiProfiles.ToList();
        }

    }
}
