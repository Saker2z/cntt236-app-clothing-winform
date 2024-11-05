using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class san_pham_sql_BLL
    {
        private san_pham_sql_DAL sp_;
        public san_pham_sql_BLL()
        {
            sp_ = new san_pham_sql_DAL();
        }
        public int get_id_sp_by_name(string name)
        {
            return sp_.get_id_sp_by_name(name);
        }
        public List<string> get_sp_all_name()
        {
            return sp_.get_all_sp_name();
        }
        
    }
}
