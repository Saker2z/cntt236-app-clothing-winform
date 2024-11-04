using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace DLL
{
    public class san_pham_DLL
    {
       
        private san_pham_DAL San_Pham_DAL;
        public san_pham_DLL()
        {
            San_Pham_DAL = new san_pham_DAL(new context());
        }
        public List<san_phams> GetAllSanPham()
        {
            return San_Pham_DAL.GetAllSanPham();
        }

    }
}
