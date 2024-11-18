using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class nhom_quyen_sql_BLL
    {
        private nhom_quyen_sql_DAL quyen_dal;
        public nhom_quyen_sql_BLL()
        {
            quyen_dal = new nhom_quyen_sql_DAL();

        }
        public List<string> load_ccb(string role)
        {
            return quyen_dal.load_ccb(role);
        }
    }
}
