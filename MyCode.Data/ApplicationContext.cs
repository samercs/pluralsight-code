using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace MyCode.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<DataBindTest> DataBindTests { get; set; }
        public DbSet<HeaderUserInfo> HeaderUserInfos { get; set; }
        public ApplicationContext() : base()
        {
            
        }
    }
}
