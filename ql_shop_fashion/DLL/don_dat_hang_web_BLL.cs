using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
   public class don_dat_hang_web_BLL
    {
        QL_SHOP_DATADataContext data = new QL_SHOP_DATADataContext();
        don_dat_hang_web_DAL hd = new don_dat_hang_web_DAL();
        public IQueryable getDonHangOnl(string tt)
        {

            return hd.getDonHangOnl(tt);
        }

        public bool updateTrangThaiGiaoHang(int maHD)
        {

           
            return hd.updateTrangThaiGiaoHang(maHD);
        }
    }
}
