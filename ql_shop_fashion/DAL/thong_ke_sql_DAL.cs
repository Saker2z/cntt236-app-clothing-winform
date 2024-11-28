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


        public List<thong_ke_theo_ngay_DTO> GetDailySales(DateTime date)
        {
            return (from ct in data.chi_tiet_hoa_dons
                    join hd in data.hoa_dons on ct.ma_hoa_don equals hd.ma_hoa_don
                    where hd.ngay_lap != null && hd.ngay_lap.Value.Date == date.Date
                    group ct by ct.ma_thuoc_tinh into g
                    select new thong_ke_theo_ngay_DTO
                    {
                        ProductID = g.Key,
                        TotalQuantity = g.Sum(x => x.so_luong),
                        TotalRevenue = g.Sum(x => x.gia * x.so_luong),
                        TotalReturns = 0 // Logic đổi trả nếu cần
                    }).ToList();
        }





        public List<thong_ke_theo_thang_DTO> GetMonthlySales(int month, int year)
        {
            return data.chi_tiet_hoa_dons
                .Where(ct => data.hoa_dons.FirstOrDefault(h => h.ma_hoa_don == ct.ma_hoa_don).ngay_lap.HasValue &&
                             data.hoa_dons.FirstOrDefault(h => h.ma_hoa_don == ct.ma_hoa_don).ngay_lap.Value.Month == month &&
                             data.hoa_dons.FirstOrDefault(h => h.ma_hoa_don == ct.ma_hoa_don).ngay_lap.Value.Year == year)
                .GroupBy(ct => ct.ma_thuoc_tinh)
                .Select(g => new thong_ke_theo_thang_DTO
                {
                    ProductID = g.Key,
                    TotalQuantitySold = g.Sum(x => x.so_luong),
                    TotalRevenue = g.Sum(x => x.gia * x.so_luong),
                    TotalStocked = data.chi_tiet_nhap_hangs
                                    .Where(nh => nh.ma_san_pham == g.Key)
                                    .Sum(nh => (int?)nh.so_luong) ?? 0

                }).ToList();
        }

        public List<thong_ke_theo_nam_DTO> GetYearlySales(int year)
        {
            return data.chi_tiet_hoa_dons
                .Where(ct => data.hoa_dons.FirstOrDefault(h => h.ma_hoa_don == ct.ma_hoa_don).ngay_lap.HasValue &&
                             data.hoa_dons.FirstOrDefault(h => h.ma_hoa_don == ct.ma_hoa_don).ngay_lap.Value.Year == year)
                .GroupBy(ct => ct.ma_thuoc_tinh)
                .Select(g => new thong_ke_theo_nam_DTO
                {
                    ProductID = g.Key,
                    TotalQuantitySold = g.Sum(x => x.so_luong),
                    TotalRevenue = g.Sum(x => x.gia * x.so_luong),
                    TotalStocked = data.chi_tiet_nhap_hangs
                                    .Where(nh => nh.ma_san_pham == g.Key)
                                    .Sum(nh => (int?)nh.so_luong) ?? 0

                }).ToList();
        }

    }
}
