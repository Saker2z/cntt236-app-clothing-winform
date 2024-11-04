using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class hinh_anh_san_phams
    {
        public int ma_hinh_anh { get; set; }
        public int ma_san_pham { get; set; }
        public string hinh_anh { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;
    }

}
