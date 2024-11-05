using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class nhap_hang_sql_DAL
    {
        QL_SHOP_DATADataContext data;
        public nhap_hang_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
        public IQueryable get_all_nhap_hang()
        {
            var ds = from i in data.nhap_hangs
                    
                    
                     select new
                     {
                         i.ma_nhap_hang,
                         i.ngay_nhap,
                         i.tong_gia_tien,
                        
                         i.ghi_chu,
                         i.trang_thai,
                         i.tong_so_luong,
                         
                     };
            return ds;
        }
        public IQueryable<dynamic> get_nhap_hang_by_id(int maNhapHang)
        {
            var nhapHang = from i in data.nhap_hangs
                           join ncc in data.nha_cung_caps on i.ma_nha_cung_cap equals ncc.ma_nha_cung_cap
                           join nv in data.nhan_viens on i.ma_nhan_vien equals nv.ma_nhan_vien
                           where i.ma_nhap_hang == maNhapHang
                           select new
                           {
                               i.ma_nhap_hang,
                               i.ngay_nhap,
                               i.tong_gia_tien,

                               i.ghi_chu,
                               i.trang_thai,
                               i.tong_so_luong,
                               ncc.ten_nha_cung_cap, // giả sử bạn muốn lấy tên nhà cung cấp
                               nv.ten_nhan_vien      // giả sử bạn muốn lấy tên nhân viên
                           };
            return nhapHang;
        }


    }
}
