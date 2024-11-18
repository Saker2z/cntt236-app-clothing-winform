using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class thuoc_tinh_sp_sql_DAL
    {
        private QL_SHOP_DATADataContext qldata;

        public thuoc_tinh_sp_sql_DAL()
        {
            qldata = new QL_SHOP_DATADataContext();

        }
        public List<product> get_all_ttsp_by_id(int mathuoctinh)
        {
            var ds = (from ttsp in qldata.thuoc_tinh_san_phams
                                   where ttsp.ma_thuoc_tinh == mathuoctinh
                                   select new product
                                   {
                                       ma_thuoc_tinh = ttsp.ma_thuoc_tinh,
                                       ma_san_pham = (int)ttsp.ma_san_pham,
                                       ma_kich_thuoc = (int)ttsp.ma_kich_thuoc,
                                       ma_mau_sac = (int)ttsp.ma_mau_sac,
                                       so_luong_ton = ttsp.so_luong_ton
                                   }).ToList();
            return ds;
        }




        public bool updated_tt_sp(List<thuoc_tinh_san_pham> ttsp)
        {
            try
            {
                // Kiểm tra nếu danh sách thuộc tính sản phẩm là rỗng
                if (ttsp == null || ttsp.Count == 0)
                    return false;

                // Lặp qua từng thuộc tính sản phẩm trong danh sách
                foreach (var item in ttsp)
                {
                    // Lấy đối tượng thuộc tính sản phẩm từ cơ sở dữ liệu dựa trên mã thuộc tính (ma_thuoc_tinh)
                    var existingTtSp = qldata.thuoc_tinh_san_phams
                                            .FirstOrDefault(t => t.ma_thuoc_tinh == item.ma_thuoc_tinh);

                    // Nếu thuộc tính tồn tại, cập nhật giá trị của nó
                    if (existingTtSp != null)
                    {
                        existingTtSp.so_luong_ton = existingTtSp.so_luong_ton + item.so_luong_ton;

                    }
                    else
                    {
                        // Nếu thuộc tính không tồn tại, thêm mới vào cơ sở dữ liệu
                        qldata.thuoc_tinh_san_phams.InsertOnSubmit(item);
                    }
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                qldata.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật thuộc tính sản phẩm: " + ex.Message);
                return false;
            }
        }


        //////////////////////////
        /// <summary>
        public IQueryable get_all_tt_SanPham()
        {


            var ttsp = from sp in qldata.san_phams
                       join thuocTinhSanPham in qldata.thuoc_tinh_san_phams on sp.ma_san_pham equals thuocTinhSanPham.ma_san_pham
                       join mau in qldata.mau_sacs on thuocTinhSanPham.ma_mau_sac equals mau.ma_mau_sac
                       join kt in qldata.kich_thuocs on thuocTinhSanPham.ma_kich_thuoc equals kt.ma_kich_thuoc
                       orderby thuocTinhSanPham.ma_thuoc_tinh ascending
                       select new
                       {
                           thuocTinhSanPham.ma_thuoc_tinh,
                           //sp.ma_san_pham,
                           sp.ten_san_pham,
                           thuocTinhSanPham.ma_kich_thuoc,
                           thuocTinhSanPham.ma_mau_sac,
                           kt.ten_kich_thuoc,
                           mau.ten_mau_sac,
                           thuocTinhSanPham.gia_ban,
                           GiaGiam = sp.giam_gia,
                           thuocTinhSanPham.so_luong_ton
                       };

            return ttsp;
        }

        public List<tem_gia> Get_SP_INGIA()
        {
            var ttsp = from sp in qldata.san_phams
                       join thuocTinhSanPham in qldata.thuoc_tinh_san_phams on sp.ma_san_pham equals thuocTinhSanPham.ma_san_pham
                       join mau in qldata.mau_sacs on thuocTinhSanPham.ma_mau_sac equals mau.ma_mau_sac
                       join kt in qldata.kich_thuocs on thuocTinhSanPham.ma_kich_thuoc equals kt.ma_kich_thuoc
                       orderby thuocTinhSanPham.ma_thuoc_tinh ascending
                       select new
                       {
                           thuocTinhSanPham.ma_thuoc_tinh,
                           //sp.ma_san_pham,
                           sp.ten_san_pham,
                           thuocTinhSanPham.ma_kich_thuoc,
                           thuocTinhSanPham.ma_mau_sac,
                           kt.ten_kich_thuoc,
                           mau.ten_mau_sac,
                           thuocTinhSanPham.gia_ban,
                           GiaGiam = thuocTinhSanPham.gia_ban - sp.giam_gia * thuocTinhSanPham.gia_ban / 100,
                           thuocTinhSanPham.so_luong_ton
                       };

            List<tem_gia> intem = new List<tem_gia>();
            tem_gia bc;
            foreach (var item in ttsp)
            {
                bc = new tem_gia();
                bc.MaSP = item.ma_thuoc_tinh;
                bc.TenSP = item.ten_san_pham;
                bc.TenKT = item.ten_kich_thuoc;
                bc.TenMau = item.ten_mau_sac;
                bc.GiaBan = item.gia_ban;
                bc.GiaGiam = (decimal)item.GiaGiam;
                bc.So_tem = 0;
                intem.Add(bc);
            }
            return intem;
        }

        public IQueryable getKichThuocBangTenSanPham(string tenSP)
        {
            var ttsp = from thuocTinhSanPham in qldata.thuoc_tinh_san_phams
                       join kt in qldata.kich_thuocs on thuocTinhSanPham.ma_kich_thuoc equals kt.ma_kich_thuoc
                       join sp in qldata.san_phams on thuocTinhSanPham.ma_san_pham equals sp.ma_san_pham
                       where sp.ten_san_pham == tenSP
                       select new
                       {
                           kt.ma_kich_thuoc,
                           kt.ten_kich_thuoc
                       };

            return ttsp;
        }

        public IQueryable getMausacBangTenSanPham(int maSP)
        {
            var ttsp = from thuocTinhSanPham in qldata.thuoc_tinh_san_phams
                       join ms in qldata.mau_sacs on thuocTinhSanPham.ma_mau_sac equals ms.ma_mau_sac
                       join sp in qldata.san_phams on thuocTinhSanPham.ma_san_pham equals sp.ma_san_pham
                       where thuocTinhSanPham.ma_thuoc_tinh == maSP
                       select new
                       {
                           ms.ma_mau_sac,
                           ms.ten_mau_sac
                       };

            return ttsp;
        }

        public IQueryable getMauSacTheoKichThuoc(string maKichThuoc, string maTT)
        {
            var ttsp = from thuocTinhSanPham in qldata.thuoc_tinh_san_phams
                       join mau in qldata.mau_sacs on thuocTinhSanPham.ma_mau_sac equals mau.ma_mau_sac
                       join kt in qldata.kich_thuocs on thuocTinhSanPham.ma_kich_thuoc equals kt.ma_kich_thuoc
                       where kt.ma_kich_thuoc == int.Parse(maKichThuoc)
                       && thuocTinhSanPham.ma_thuoc_tinh == int.Parse(maTT)

                       select new
                       {
                           thuocTinhSanPham.ma_kich_thuoc,
                           thuocTinhSanPham.ma_mau_sac,
                           kt.ten_kich_thuoc,
                           mau.ten_mau_sac,

                           thuocTinhSanPham.gia_ban,

                           thuocTinhSanPham.so_luong_ton
                       };

            return ttsp;
        }

        public int getSoLuongTon_MaThuocTinh(string maTT)
        {
            // Thực hiện truy vấn để lấy số lượng tồn của sản phẩm với mã thuộc tính
            var ttsp = (from thuocTinhSanPham in qldata.thuoc_tinh_san_phams
                        where thuocTinhSanPham.ma_thuoc_tinh == int.Parse(maTT)
                        select thuocTinhSanPham.so_luong_ton).FirstOrDefault();

            // Kiểm tra nếu kết quả là null, trả về 0 hoặc giá trị mặc định
            return ttsp ?? 0;
        }

        public CTHD get_tt_SanPham_CTHD(string ma)
        {
            var ttsp = (from sp in qldata.san_phams
                        join thuocTinhSanPham in qldata.thuoc_tinh_san_phams on sp.ma_san_pham equals thuocTinhSanPham.ma_san_pham
                        orderby thuocTinhSanPham.ma_thuoc_tinh ascending
                        where thuocTinhSanPham.ma_thuoc_tinh == int.Parse(ma)
                        select new
                        {
                            thuocTinhSanPham.ma_thuoc_tinh,
                            sp.ten_san_pham,
                            thuocTinhSanPham.gia_ban,
                            GiaGiam = sp.giam_gia
                        }).FirstOrDefault();

            if (ttsp != null)
            {
                return new CTHD(ttsp.ma_thuoc_tinh, ttsp.ten_san_pham, ttsp.gia_ban, ttsp.GiaGiam);
            }
            else
            {
                return null; // Or handle the case where no matching product is found
            }
        }
       
    }
}
