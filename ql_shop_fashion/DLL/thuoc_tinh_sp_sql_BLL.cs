using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{

    public class thuoc_tinh_sp_sql_BLL
    {
        private thuoc_tinh_sp_sql_DAL sp;
  
        public thuoc_tinh_sp_sql_BLL()
        {
            sp = new thuoc_tinh_sp_sql_DAL();
           

        }

        public List<product> get_all_ttsp_by_id(int masanpham)
        {
            return sp.get_all_ttsp_by_id(masanpham);
        }

        public bool updated_tt_sp(List<thuoc_tinh_san_pham> ttsp)
        {
            return sp.updated_tt_sp(ttsp);
        }
    }
}
