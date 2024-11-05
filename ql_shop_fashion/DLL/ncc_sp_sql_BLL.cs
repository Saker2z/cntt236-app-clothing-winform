using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ncc_sp_sql_BLL
    {
        private nha_cung_cap_sp_sql_DAL sp;
        public ncc_sp_sql_BLL()
        {
            sp = new nha_cung_cap_sp_sql_DAL();
        }
        public IQueryable get_nccsp_by_id_sp(int id)
        {
            return sp.get_nccsp_by_id_sp(id);
        }
        public List<string> get_list_sp_by_id(int id)
        {
            return sp.get_list_sp_by_id(id);
        }
        public List<string> get_list_name_ncc_id_sp(int id)
        {
            return sp.get_list_name_ncc_id_sp(id);
        }
      
    }
}
