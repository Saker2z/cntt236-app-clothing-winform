using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
   public class don_dat_hang_web_DAL
    {
        QL_SHOP_DATADataContext data;
        public don_dat_hang_web_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
        public IQueryable getDonHangOnl(string trangThai)
        {
            // Kiểm tra nếu trangThai là null, trả về tất cả các đơn hàng
            var ds = from hd in data.don_dat_hang_webs
                     where trangThai == null || hd.trangThai == trangThai
                     select new
                     {
                         hd.id_don_hang,
                         hd.ho_ten,
                         hd.dia_chi,
                         hd.thoi_gian_dat,
                         hd.so_dien_thoai,
                         hd.gia_tien,
                         hd.trangThai
                     };

            return ds;
        }


        public bool updateTrangThaiGiaoHang(int maHD)
        {

            don_dat_hang_web hd = data.don_dat_hang_webs.Where(d => d.id_don_hang == maHD).FirstOrDefault();
            if (hd != null)
            {

                //Sua.code = km.code;
                hd.trangThai = "Đã giao cho đơn vị vận chuyển";

                //Sua.ma_nhan_vien = km.ma_nhan_vien;

                data.SubmitChanges();
                return true;
            }
            return false;
        }
    }
}
