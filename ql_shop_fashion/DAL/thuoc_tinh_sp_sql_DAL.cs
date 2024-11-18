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

    }
}
