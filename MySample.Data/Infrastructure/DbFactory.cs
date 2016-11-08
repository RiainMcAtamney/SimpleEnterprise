using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample.Data.Infrastructure
{
    public class DbFactory: IDbFactory
    {
        MySampleContext dbContext;

        public MySampleContext Init()
        {
            return dbContext ?? (dbContext = new MySampleContext());
        }
        
    }
}
