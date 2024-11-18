using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class san_pham_sql_BLL
    {
        private san_pham_sql_DAL sp_;
        public san_pham_sql_BLL()
        {
            sp_ = new san_pham_sql_DAL();
        }
        public int get_id_sp_by_name(string name)
        {
            return sp_.get_id_sp_by_name(name);
        }
        public List<string> get_sp_all_name()
        {
            return sp_.get_all_sp_name();
        }
        public string get_name_by_id(int id)
        {
            return sp_.get_name_by_id(id);
        }
        public List<san_pham_custom> get_all_sp()
        {
            return sp_.get_all_sp();
        }

        public List<san_pham> GetAllSanPham()
        {
            return sp_.GetAllSanPham();
        }

    }
}
