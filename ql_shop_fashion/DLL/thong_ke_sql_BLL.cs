using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class thong_ke_sql_BLL
    {
        private thong_ke_sql_DAL thongKeDAL;

        public thong_ke_sql_BLL()
        {
            thongKeDAL = new thong_ke_sql_DAL();
        }

        public List<hoa_don_DTO> ThongKeHoaDon(DateTime? fromDate, DateTime? toDate)
        {
            return thongKeDAL.GetHoaDon(fromDate, toDate);
        }

        public List<hoa_don_doi_tra_DTO> ThongKeHoaDonDoiTra(DateTime? fromDate, DateTime? toDate)
        {
            return thongKeDAL.GetHoaDonDoiTra(fromDate, toDate);
        }
    }
}
