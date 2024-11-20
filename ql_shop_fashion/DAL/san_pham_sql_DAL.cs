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

        public List<san_pham_custom> get_all_sp_custom()
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

        public List<san_pham_DTO> get_all_sp_DTO()
        {
            var ds = from i in data.san_phams
                     select new san_pham_DTO
                     {
                         ma_san_pham = i.ma_san_pham,
                         ten_san_pham = i.ten_san_pham,
                         ma_loai = i.ma_loai ?? 0, // Sử dụng 0 làm giá trị mặc định nếu null
                         ma_thuong_hieu = i.ma_thuong_hieu ?? 0, // Sử dụng 0 làm giá trị mặc định nếu null
                         giam_gia = i.giam_gia ?? 0.0m, // Sử dụng 0.0 làm giá trị mặc định nếu null
                         so_luong_kich_thuoc = i.so_luong_kich_thuoc ?? 0,
                         so_luong_mau_sac = i.so_luong_mau_sac ?? 0,
                         so_luong = i.so_luong ?? 0,
                         slug = i.slug,
                         mo_ta = i.mo_ta,
                         gia_binh_quan = i.gia_binh_quan ?? 0.0m, // Sử dụng 0.0 làm giá trị mặc định nếu null
                         hinh_thuc_ban = i.hinh_thuc_ban
                     };
            return ds.ToList();
        }


        public List<san_pham_DTO> get_all_sp_dk(int masanpham)
        {
            var ds = from i in data.san_phams
                     where i.ma_san_pham == masanpham
                     select new san_pham_DTO
                     {
                         ma_san_pham = i.ma_san_pham,
                         ten_san_pham = i.ten_san_pham,
                         ma_loai = i.ma_loai ?? 0, // Sử dụng 0 làm giá trị mặc định nếu null
                         ma_thuong_hieu = i.ma_thuong_hieu ?? 0, // Sử dụng 0 làm giá trị mặc định nếu null
                         giam_gia = i.giam_gia ?? 0.0m, // Sử dụng 0.0 làm giá trị mặc định nếu null
                         so_luong_kich_thuoc = i.so_luong_kich_thuoc ?? 0,
                         so_luong_mau_sac = i.so_luong_mau_sac ?? 0,
                         so_luong = i.so_luong ?? 0,
                         slug = i.slug,
                         mo_ta = i.mo_ta,
                         gia_binh_quan = i.gia_binh_quan ?? 0.0m, // Sử dụng 0.0 làm giá trị mặc định nếu null
                         hinh_thuc_ban = i.hinh_thuc_ban
                     };
            return ds.ToList();
        }


        public san_pham GetProductDetailsById(int maSanPham)
        {
            return data.san_phams.FirstOrDefault(p => p.ma_san_pham == maSanPham);
        }


        public bool UpdateThumbnail(int maSanPham, string thumbnailPath)
        {
            try
            {
                var sanPham = data.san_phams.FirstOrDefault(sp => sp.ma_san_pham == maSanPham);
                if (sanPham != null)
                {
                    sanPham.thumbnail_image = thumbnailPath; // Cập nhật đường dẫn thumbnail
                    sanPham.updated_at = DateTime.Now; // Cập nhật thời gian
                    data.SubmitChanges(); // Lưu thay đổi
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }



        public bool AddSP(san_pham newSP)
        {
            try
            {
                data.san_phams.InsertOnSubmit(newSP);
                data.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateSP(san_pham updatedSP)
        {
            try
            {
                var sp = data.san_phams.SingleOrDefault(k => k.ma_san_pham == updatedSP.ma_san_pham);
                if (sp != null)
                {
                    sp.ten_san_pham = updatedSP.ten_san_pham;
                    sp.ma_loai = updatedSP.ma_loai;
                    sp.ma_thuong_hieu = updatedSP.ma_thuong_hieu;
                    sp.thumbnail_image = updatedSP.thumbnail_image;
                    sp.giam_gia = updatedSP.giam_gia;
                    sp.so_luong_kich_thuoc = updatedSP.so_luong_kich_thuoc;
                    sp.so_luong_mau_sac = updatedSP.so_luong_mau_sac;
                    sp.so_luong = updatedSP.so_luong;
                    sp.slug = updatedSP.slug;
                    sp.mo_ta = updatedSP.mo_ta;
                    sp.gia_binh_quan = updatedSP.gia_binh_quan;
                    sp.hinh_thuc_ban = updatedSP.hinh_thuc_ban;
                    data.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool DeleteSPById(int masp)
        {
            try
            {
                // Tìm thương hiệu theo ma_thuong_hieu
                var sp = data.san_phams
                    .FirstOrDefault(p => p.ma_san_pham == masp);

                if (sp != null)
                {
                    data.san_phams.DeleteOnSubmit(sp);
                    data.SubmitChanges();
                    return true;
                }
                else
                {
                    Console.WriteLine("Không tìm thấy sản phẩm với mã sản phẩm đã cho.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                Console.WriteLine("Lỗi trong quá trình xóa sản phẩm: " + ex.Message);
                return false;
            }
        }


        public bool SaveProducts(san_pham_DTO product)
        {
            try
            {
                var existingProduct = data.san_phams.FirstOrDefault(x => x.ma_san_pham == product.ma_san_pham);
                if (existingProduct != null)
                {
                    existingProduct.ten_san_pham = product.ten_san_pham;
                    existingProduct.ma_loai = product.ma_loai;
                    existingProduct.ma_thuong_hieu = product.ma_thuong_hieu;
                    existingProduct.giam_gia = product.giam_gia;
                    existingProduct.so_luong_kich_thuoc = product.so_luong_kich_thuoc;
                    existingProduct.so_luong_mau_sac = product.so_luong_mau_sac;
                    existingProduct.so_luong = product.so_luong;
                    existingProduct.slug = product.slug;
                    existingProduct.mo_ta = product.mo_ta;
                    existingProduct.gia_binh_quan = product.gia_binh_quan;
                    existingProduct.hinh_thuc_ban = product.hinh_thuc_ban;
                    existingProduct.thumbnail_image = product.thumbnail_image; // Lưu thumbnail
                    existingProduct.updated_at = DateTime.Now;

                    data.SubmitChanges();
                }
                else
                {
                    // Thêm sản phẩm mới nếu chưa tồn tại
                    var newProduct = new san_pham
                    {
                        ten_san_pham = product.ten_san_pham,
                        ma_loai = product.ma_loai,
                        ma_thuong_hieu = product.ma_thuong_hieu,
                        giam_gia = product.giam_gia,
                        so_luong_kich_thuoc = product.so_luong_kich_thuoc,
                        so_luong_mau_sac = product.so_luong_mau_sac,
                        so_luong = product.so_luong,
                        slug = product.slug,
                        mo_ta = product.mo_ta,
                        gia_binh_quan = product.gia_binh_quan,
                        hinh_thuc_ban = product.hinh_thuc_ban,
                        thumbnail_image = product.thumbnail_image, // Thêm thumbnail
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };

                    data.san_phams.InsertOnSubmit(newProduct);
                    data.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                // Log lỗi
                Console.WriteLine(ex.Message);
                return false;
            }
        }



    }
}
