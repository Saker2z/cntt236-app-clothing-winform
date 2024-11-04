using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class quyen_truy_caps
    {
        public int id_quyen { get; set; } // ID của quyền truy cập
        public string ten_quyen { get; set; } // Tên của quyền truy cập
        public string value { get; set; } // Giá trị quyền
        public string mo_ta { get; set; } // Mô tả quyền truy cập
        public DateTime create_at { get; set; } = DateTime.Now; // Thời điểm tạo bản ghi
        public DateTime update_at { get; set; } = DateTime.Now; // Thời điểm cập nhật bản ghi
    }
}
