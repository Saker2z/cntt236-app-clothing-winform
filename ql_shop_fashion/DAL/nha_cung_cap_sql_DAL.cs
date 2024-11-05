using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public  class nha_cung_cap_sql_DAL
    {
        QL_SHOP_DATADataContext ncc;
        public nha_cung_cap_sql_DAL()
        {
            ncc = new QL_SHOP_DATADataContext();
        }
        public List<string> get_name_list_ncc()
        {
            var ds = from i in ncc.nha_cung_caps
                     select i.ten_nha_cung_cap;

            return ds.ToList();
        }
        public int get_id_ncc(string name)
        {
            var ds = from i in ncc.nha_cung_caps where i.ten_nha_cung_cap == name
                     select i.ma_nha_cung_cap;

            return ds.FirstOrDefault();
        }
    }
}
