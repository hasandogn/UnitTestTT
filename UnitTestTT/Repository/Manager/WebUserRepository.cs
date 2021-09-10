using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Data;
using UnitTestTT.Repository.Interfaces;

namespace UnitTestTT.Repository.Manager
{
    public class WebUserRepository : IWebUserRepository
    {
        protected readonly GlobalContext _globalContext;

        public WebUserRepository(GlobalContext globalContext)
        {
            _globalContext = globalContext;
        }

        public WebUser GetWebUserById(int id)
        {
            return _globalContext.WebUsers.FirstorDefault();
        }

        public List<WebUser> GetWebUsers()
        {
            throw new NotImplementedException();
        }
    }
}
