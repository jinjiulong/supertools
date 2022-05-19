using SuperTools.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupeTools.Service
{

    public class CustomerService
    {
        private ToolsDbContext _db;
        public CustomerService(ToolsDbContext db)
        {
            _db = db;
        }
    }
}
