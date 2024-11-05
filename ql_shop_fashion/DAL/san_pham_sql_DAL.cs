using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class san_pham_sql_DAL
    {
        private QL_SHOP_DATADataContext data;
        public san_pham_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
    }
}
