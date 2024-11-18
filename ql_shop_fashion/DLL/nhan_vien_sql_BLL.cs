using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class nhan_vien_sql_BLL
    {
        private nhan_vien_sql_DAL nv_dal;
        public nhan_vien_sql_BLL()
        {
            nv_dal = new nhan_vien_sql_DAL();
        }
        public bool add_nv_tk_user(nhan_vien a, string tenNhomQuyen)
        {
            return nv_dal.add_nv_tk_user(a, tenNhomQuyen);
        }
        public List<nhan_vien> GetNhanVienTheoQuyen(string quyen)
        {
            return nv_dal.GetNhanVienTheoQuyen(quyen);
        }
        public bool UpdateNhanVien(nhan_vien updatedNhanVien)
        {
            return nv_dal.UpdateNhanVien(updatedNhanVien);
        }
        public bool DeleteNhanVien(int maNhanVien)
        {
            return nv_dal.DeleteNhanVien(maNhanVien);
        }
    }
}
