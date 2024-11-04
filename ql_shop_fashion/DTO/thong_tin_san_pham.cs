using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class thong_tin_san_phams
    {
        public int ma_san_pham { get; set; }
        public string key_attribute { get; set; }
        public string value_attribute { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;
    }

}
