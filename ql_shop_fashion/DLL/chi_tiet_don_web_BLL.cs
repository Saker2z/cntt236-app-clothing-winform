using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    
    public class chi_tiet_don_web_BLL
    {
        QL_SHOP_DATADataContext data = new QL_SHOP_DATADataContext();
        chi_tiet_don_web_DAL cthd = new chi_tiet_don_web_DAL();
        public chi_tiet_don_web_BLL()
        {

        }

        public IQueryable layChiTietDonHang(int maHD)
        {


            return cthd.layChiTietDonHang(maHD);
        }
    }
    
}
