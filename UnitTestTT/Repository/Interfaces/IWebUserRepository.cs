using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestTT.Data;

namespace UnitTestTT.Repository.Interfaces
{
    public interface IWebUserRepository
    {
        List<WebUser> GetWebUsers();
        WebUser GetWebUserById(int Id);
    }
}
