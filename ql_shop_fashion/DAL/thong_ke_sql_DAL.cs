using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class thong_ke_sql_DAL
    {
        QL_SHOP_DATADataContext data;
        public thong_ke_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }

        public List<hoa_don_DTO> GetHoaDon(DateTime? fromDate, DateTime? toDate)
        {
            return data.hoa_dons
                .Where(hd => (!fromDate.HasValue || hd.ngay_lap >= fromDate) &&
                             (!toDate.HasValue || hd.ngay_lap <= toDate))
                .Select(hd => new hoa_don_DTO
                {
                    MaHoaDon = hd.ma_hoa_don,
                    NgayLap = hd.ngay_lap.GetValueOrDefault(),
                    TongTien = hd.tong_tien.GetValueOrDefault(),
                    TongSoLuongMua = hd.tong_so_luong_mua.GetValueOrDefault()
                }).ToList();
        }

        public List<hoa_don_doi_tra_DTO> GetHoaDonDoiTra(DateTime? fromDate, DateTime? toDate)
        {
            return data.hoa_don_doi_tras
                .Where(hd => (!fromDate.HasValue || hd.ngay_doi_tra >= fromDate) &&
                             (!toDate.HasValue || hd.ngay_doi_tra <= toDate))
                .Select(hd => new hoa_don_doi_tra_DTO
                {
                    MaHoaDon = hd.ma_hoa_don,
                    NgayDoiTra = hd.ngay_doi_tra.GetValueOrDefault(),
                    TongTienHoan = hd.tien_hoan.GetValueOrDefault(),
                    TongSoLuongTra = hd.tong_so_luong.GetValueOrDefault()
                }).ToList();
        }
    }
}
