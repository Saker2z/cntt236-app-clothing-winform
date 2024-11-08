using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class nha_cung_cap_sp_sql_DAL
    {
        QL_SHOP_DATADataContext data;
        public nha_cung_cap_sp_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
       public IQueryable<dynamic> get_nccsp_by_id_sp(int id)
        {
            var ds = from i in data.nha_cung_cap_san_phams join k in data.nha_cung_caps on i.ma_nha_cung_cap equals k.ma_nha_cung_cap join ii in data.san_phams on i.ma_san_pham equals ii.ma_san_pham where i.ma_san_pham == id select new { k.ten_nha_cung_cap,ii.ten_san_pham,i.gia_cung_cap};
            return ds;
        }
        public List<string> get_list_sp_by_id(int id)
        {
            var dssp = from i in data.nha_cung_cap_san_phams
                       join k in data.san_phams on i.ma_san_pham equals k.ma_san_pham
                       where i.ma_nha_cung_cap == id
                       select k.ten_san_pham;

            return dssp.ToList();
        }
        public List<string> get_list_name_ncc_id_sp(int id)
        {
            var dssp = from i in data.nha_cung_cap_san_phams
                       join k in data.san_phams on i.ma_san_pham equals k.ma_san_pham
                       join ii  in data.nha_cung_caps on i.ma_nha_cung_cap equals ii.ma_nha_cung_cap
                       where i.ma_san_pham == id
                       select ii.ten_nha_cung_cap;

            return dssp.ToList();
        }
    }
}
