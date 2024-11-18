using System;
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
        public List<san_pham_custom> get_all_sp()
        {
            var ds = from i in data.san_phams
                     select new san_pham_custom
                     {
                         ma_san_pham = i.ma_san_pham,
                         ten_san_pham = i.ten_san_pham,
                         gia_binh_quan = i.gia_binh_quan
                     };
            return ds.ToList();
        }
        public List<san_pham> GetAllSanPham()
        {
            try
            {
                // Query to get all products from the san_phams table
                List<san_pham> productList = data.san_phams.ToList();
                return productList;
            }
            catch (Exception ex)
            {
                // Log the exception and return an empty list if there is an error
                Console.WriteLine("Error retrieving product list: " + ex.Message);
                return new List<san_pham>(); // Return an empty list if an error occurs
            }
        }



    }
}
