﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class san_pham_sql_DAL
    {
        private QL_SHOP_DATADataContext data;
        public san_pham_sql_DAL()
        {
            data = new QL_SHOP_DATADataContext();
        }
        public int get_id_sp_by_name(string name)
        {
            var ds = from i in data.san_phams where i.ten_san_pham == name select i.ma_san_pham;
            return ds.FirstOrDefault();
        }
        public List<string> get_all_sp_name()
        {
            var ds = from i in data.san_phams  select i.ten_san_pham;
            return ds.ToList();
        }
        public string get_name_by_id(int id)
        {
            // Lấy tên sản phẩm dựa trên mã sản phẩm
            var ds = from i in data.san_phams
                     where i.ma_san_pham == id
                     select i.ten_san_pham;

            // Trả về tên sản phẩm đầu tiên hoặc null nếu không tìm thấy
            return ds.FirstOrDefault();
        }

    }
}