using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DLL
{
    public class chi_tiet_nhap_sql_DLL
    {
        chi_tiet_nhap_sql_DAL dl;
        public chi_tiet_nhap_sql_DLL()
        {
            dl = new chi_tiet_nhap_sql_DAL();
        }
        public IQueryable get_sp_by_phieu_nhap(int id)
        {
            return dl.get_sp_by_phieu_nhap(id);
        }
        public List<string> get_list_sp_by_id(int id)
        {
            return dl.get_list_sp_by_id(id);
        }



    }
}
