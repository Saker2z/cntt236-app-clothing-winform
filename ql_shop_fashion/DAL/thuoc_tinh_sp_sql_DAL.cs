using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class thuoc_tinh_sp_sql_DAL
    {
        private QL_SHOP_DATADataContext qldata;
       
        public thuoc_tinh_sp_sql_DAL()
        {
            qldata = new QL_SHOP_DATADataContext();
           
        }
        public IQueryable<product> get_all_ttsp_by_id(int id)
        {
            var dssp = from i in qldata.thuoc_tinh_san_phams
                       join k in qldata.san_phams on i.ma_san_pham equals k.ma_san_pham
                       join e in qldata.kich_thuocs on i.ma_kich_thuoc equals e.ma_kich_thuoc
                       join o in qldata.mau_sacs on i.ma_mau_sac equals o.ma_mau_sac
                       where k.ma_san_pham == id
                       select new product
                       {
                           ma_thuoc_tinh = i.ma_thuoc_tinh,
                           ten_san_pham = k.ten_san_pham,
                           ten_kich_thuoc = e.ten_kich_thuoc,
                           ten_mau_sac = o.ten_mau_sac,
                           so_luong_ton = i.so_luong_ton
                       };

            return dssp;
        }
    }
}
