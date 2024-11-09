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
        public string get_name_by_id(int id)
        {
            var ds = from i in ncc.nha_cung_caps
                     where i.ma_nha_cung_cap == id
                     select i.ten_nha_cung_cap;

            return ds.FirstOrDefault();
        }
        public List<nha_cung_cap> get_all_ncc()
        {
            // Truy vấn dữ liệu dưới dạng kiểu ẩn danh trước
            var dsncc = from i in ncc.nha_cung_caps
                        select new
                        {
                            i.ma_nha_cung_cap,
                            i.ten_nha_cung_cap,
                            i.dia_chi,
                            i.dien_thoai
                        };

            // Chuyển đổi từ kiểu ẩn danh sang danh sách các đối tượng `nha_cung_cap`
            var result = dsncc.AsEnumerable()
                              .Select(i => new nha_cung_cap
                              {
                                  ma_nha_cung_cap = i.ma_nha_cung_cap,
                                  ten_nha_cung_cap = i.ten_nha_cung_cap,
                                  dia_chi = i.dia_chi,
                                  dien_thoai = i.dien_thoai
                              }).ToList();

            return result;
        }



    }
}
