using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestTT.Data
{
    public class GlobalContext
    {
        public GlobalContext(DbContextOptions<GlobalContext> options): base(options)
        {

        }
    }
}
