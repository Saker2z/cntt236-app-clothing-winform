﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class kich_thuocs
    {
        public int ma_kich_thuoc { get; set; }
        public string ten_kich_thuoc { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at { get; set; } = DateTime.Now;
    }
}
