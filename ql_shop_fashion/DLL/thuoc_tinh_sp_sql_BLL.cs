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
        public IQueryable<product> get_all_ttsp_by_id(int id)
        {
            return sp.get_all_ttsp_by_id(id);
        }
    }
}
