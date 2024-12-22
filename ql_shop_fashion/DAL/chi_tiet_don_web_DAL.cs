using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class chi_tiet_don_web_DAL
    {
        QL_SHOP_DATADataContext data = new QL_SHOP_DATADataContext();
        public chi_tiet_don_web_DAL()
        {

        }
        public IQueryable layChiTietDonHang(int maHD)
        {
            var ttsp = from hd in data.don_dat_hang_webs
                       join cthd in data.chi_tiet_don_webs on hd.id_don_hang equals cthd.id_don_hang
                       join thuoc_tinh in data.thuoc_tinh_san_phams on cthd.ma_thuoc_tinh equals thuoc_tinh.ma_thuoc_tinh
                       join sp in data.san_phams on thuoc_tinh.ma_san_pham equals sp.ma_san_pham
                       where hd.id_don_hang == maHD
                       select new ChiTietHoaDon
                       {
                           ma_thuoc_tinh = cthd.ma_thuoc_tinh,
                           ten_san_pham = sp.ten_san_pham,
                           so_luong = cthd.so_luong,
                           gia = cthd.gia,
                           thanh_tien = (decimal)cthd.thanh_tien,
                       };

            return ttsp;
        }
    }
}
