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
    }
}
