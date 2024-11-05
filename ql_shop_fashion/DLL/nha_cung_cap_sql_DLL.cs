using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DLL
{
   public  class nha_cung_cap_sql_DLL
    {
        nha_cung_cap_sql_DAL ncc;
        public nha_cung_cap_sql_DLL()
        {
            ncc = new nha_cung_cap_sql_DAL();
        }
        public List<string> get_ncc_list_name()
        {
            return ncc.get_name_list_ncc();
        }
        public int get_id_ncc(string name)
        {
            return ncc.get_id_ncc(name);
        }
    }
}
