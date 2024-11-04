using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class chi_tiet_nhap_hangs
    {
        public int ma_nhap_hang { get; set; } // Mã nhập hàng
        public int ma_san_pham { get; set; } // Mã sản phẩm
        public int so_luong { get; set; } // Số lượng
        public decimal gia_nhap { get; set; } // Giá nhập
        public DateTime created_at { get; set; } = DateTime.Now; // Thời gian tạo
        public DateTime updated_at { get; set; } = DateTime.Now; // Thời gian cập nhật
    }
}
