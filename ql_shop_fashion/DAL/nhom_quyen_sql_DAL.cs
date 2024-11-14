using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class nhom_quyen_sql_DAL
    {
        private QL_SHOP_DATADataContext data;
        public nhom_quyen_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
        public List<string> load_ccb(string role)
        {
            if (role.Equals("Admin"))
            {
                // Nếu role là Admin, xuất tất cả các tên nhóm quyền
                var ds = from i in data.nhom_quyens select i.ten_nhom;
                return ds.ToList();
            }
            else
            {
                var ds = from i in data.nhom_quyens
                         where i.ten_nhom != "Admin" && i.ten_nhom != "Quản lí"
                         select i.ten_nhom;
                return ds.ToList();
            }
        }

    }
}
