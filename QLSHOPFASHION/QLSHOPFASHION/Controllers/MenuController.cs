using QLSHOPFASHION.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace BanHangThoiTrangMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly QL_SHOP_FASHIONEntities5 db = new QL_SHOP_FASHIONEntities5();

        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        // Lấy danh sách nhóm loại sản phẩm (MenuTop) với thứ tự sắp xếp
        public ActionResult MenuTop()
        {
            var items = (from nhomLoai in db.nhom_loai
                         orderby nhomLoai.created_at
                         select nhomLoai).ToList();
            return PartialView("_MenuTop", items);
        }

        // Lấy danh sách loại sản phẩm (MenuProductCategory)
        /*    public ActionResult MenuProductCategory()
            {
                var items = (from loaiSanPham in db.loai_san_pham
                             select loaiSanPham).ToList();
                return PartialView("_MenuProductCategory", items);
            }*/

        public ActionResult MenuProductCategory()
        {
            System.Diagnostics.Debug.WriteLine("MenuCategory is running...");

            // Danh sách các hình ảnh theo chu kỳ
            var imageList = new List<string>
                {
                    "/Content/assets/images/banner_4.jpg",
                    "/Content/assets/images/banner_5.jpg",
                    "/Content/assets/images/banner_6.jpg",
                    "/Content/assets/images/banner_7.jpg",
                    "/Content/assets/images/banner_8.jpg",
                    "/Content/assets/images/banner_9.jpg",
                    "/Content/assets/images/banner_10.jpg",
                    "/Content/assets/images/banner_17.jpg",
                    "/Content/assets/images/banner_11.jpg",
                    "/Content/assets/images/banner_12.jpg",
                    "/Content/assets/images/banner_13.jpg",
                    "/Content/assets/images/banner_14.jpg",
                    "/Content/assets/images/banner_15.jpg",
                    "/Content/assets/images/banner_16.jpg",
                    "/Content/assets/images/banner_18.jpg",

                };

            // Lấy toàn bộ dữ liệu từ bảng nhom_loai và chuyển về bộ nhớ
            var nhomLoai = db.nhom_loai.ToList();

            // Áp dụng logic xử lý hình ảnh và alias
            var items = nhomLoai
                .Select((loaiSanPham, index) => new ProductCategoryViewModel
                {
                    Id = loaiSanPham.ma_nhom_loai,
                    Title = loaiSanPham.ten_nhom_loai,
                    Alias = loaiSanPham.ten_nhom_loai.Replace(" ", "-").ToLower(), // Tạo alias
                    Icon = imageList[index % imageList.Count] // Lấy hình ảnh theo chu kỳ
                }).ToList();

            return PartialView("_MenuProductCategory", items);
        }





        // Menu bên trái, có thể lọc theo mã loại nếu truyền ID
        public ActionResult MenuLeft(int? id)
        {
            var items = (from loaiSanPham in db.loai_san_pham
                         select loaiSanPham).ToList();
            if (id != null)
            {
                ViewBag.CateId = id;
            }
            return PartialView("_MenuLeft", items);
        }

        // Menu cho sản phẩm mới về (MenuArrivals)
        public ActionResult MenuArrivals()
        {


            /* var items = (from sanPham in db.san_pham
                          orderby sanPham.created_at descending
                          select sanPham).Take(10).ToList(); // Lấy 10 sản phẩm mới nhất*/
            var nhomLoai = db.nhom_loai.ToList(); // Chuyển sang danh sách trong bộ nhớ

            var imageList = new List<string>
            {
                    "/Content/assets/images/banner_4.jpg",
                    "/Content/assets/images/banner_5.jpg",
                    "/Content/assets/images/banner_6.jpg",
                    "/Content/assets/images/banner_7.jpg",
                    "/Content/assets/images/banner_8.jpg",
                    "/Content/assets/images/banner_9.jpg",
                    "/Content/assets/images/banner_10.jpg",
                    "/Content/assets/images/banner_17.jpg",
                    "/Content/assets/images/banner_11.jpg",
                    "/Content/assets/images/banner_12.jpg",
                    "/Content/assets/images/banner_13.jpg",
                    "/Content/assets/images/banner_14.jpg",
                    "/Content/assets/images/banner_15.jpg",
                    "/Content/assets/images/banner_16.jpg",
                    "/Content/assets/images/banner_18.jpg",
            };

            // Áp dụng logic gán hình ảnh
            var items = nhomLoai
             .Select((loaiSanPham, index) => new ProductCategoryViewModel
             {
                 Id = loaiSanPham.ma_nhom_loai,
                 Title = loaiSanPham.ten_nhom_loai,
                 Alias = $"category-{loaiSanPham.ma_nhom_loai}", // Sửa lại để Alias đồng bộ với `data-filter`
                 Icon = imageList[index % imageList.Count] // Lấy hình ảnh theo chu kỳ
             }).ToList();




            return PartialView("_MenuArrivals", items);
        }


    }

    // ViewModel để đóng gói dữ liệu gửi sang View
    public class ProductCategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Icon { get; set; }
    }
}
