
using QLSHOPFASHION.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*namespace BanHangThoiTrangMVC.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Products
        public ActionResult Index(string Searchtext, int? id)
        {
            *//*var items = db.Products.Where(x => x.IsActive).Take(12).ToList();*//*
            IEnumerable<Product> items = db.Products.OrderByDescending(x => x.Id);
            items = items.Where(x => x.IsActive).Take(12).ToList();
            *//*if (id != null)
            {
                items = items.Where(x => x.ProductCategoryId == id).ToList();
            }*//*
            if (!string.IsNullOrEmpty(Searchtext))
            {
                items = items.Where(x => x.Alias.Contains(Searchtext) || x.Title.Contains(Searchtext));
            }
            return View(items);
        }

        public ActionResult ProductCategory(string alias, int id)
        {
            var items = db.Products.Where(x => x.IsActive).Take(12).ToList();
            if (id > 0)
            {
                items = items.Where(x => x.ProductCategoryId == id).ToList();
            }
            var cate = db.ProductCategories.Find(id);
            if (cate != null)
            {
                ViewBag.CateName = cate.Title;
            }
            ViewBag.CateId = id;
            return View(items);
        }

        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.Products.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult Partial_ProductSale()
        {
            var items = db.Products.Where(x => x.IsSale && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        public ActionResult Detail(string alias, int id)
        {
            var item = db.Products.Find(id);
            if (item != null)
            {
                db.Products.Attach(item);
                item.ViewCount = item.ViewCount + 1;
                if(item.ViewCount == 1000)
                {
                    item.ViewCount = 0;
                }
                db.Entry(item).Property(x => x.ViewCount).IsModified = true;
                db.SaveChanges();
            }
            return View(item);
        }
    }
}*/


namespace BanHangThoiTrangMVC.Controllers
{
    public class ProductsController : Controller
    {

        private readonly QL_SHOP_FASHIONEntities5 db = new QL_SHOP_FASHIONEntities5();

        public ActionResult Index(string searchtext, int? page)
        {
            int pageSize = 12; // Số sản phẩm mỗi trang
            int currentPage = page ?? 1; // Trang hiện tại, mặc định là 1 nếu không truyền `page`

            // Lấy danh sách sản phẩm
            var query = db.san_pham.Where(x => x.so_luong > 0); // Chỉ lấy các sản phẩm còn tồn kho

            // Tìm kiếm sản phẩm theo từ khóa
            if (!string.IsNullOrEmpty(searchtext))
            {
                query = query.Where(x => x.ten_san_pham.Contains(searchtext));
            }

            // Tổng số sản phẩm sau khi lọc
            int totalItems = query.Count();

            // Lấy dữ liệu sản phẩm theo trang
            var products = query
                .OrderByDescending(x => x.ma_san_pham) // Sắp xếp giảm dần theo mã sản phẩm
                .Skip((currentPage - 1) * pageSize) // Bỏ qua các sản phẩm của trang trước
                .Take(pageSize) // Lấy sản phẩm của trang hiện tại
                .Select(x => new ProductViewModel
                {
                    Id = x.ma_san_pham,
                    Title = x.ten_san_pham,
                    Alias = x.ten_san_pham.Replace(" ", "-").ToLower(), // Alias từ tên sản phẩm
                    Description = x.mo_ta,
                    Image = db.hinh_anh_san_pham
                        .Where(img => img.ma_san_pham == x.ma_san_pham)
                        .Select(img => img.hinh_anh)
                        .FirstOrDefault() ?? "/Content/assets/images/product_1.png", // Lấy ảnh đầu tiên hoặc mặc định
                    Price = x.gia_binh_quan ?? 0,
                    PriceSale = x.giam_gia > 0
                        ? ((x.gia_binh_quan ?? 0) - (x.gia_binh_quan ?? 0) * (x.giam_gia ?? 0) / 100)
                        : (x.gia_binh_quan ?? 0),
                    IsSale = x.giam_gia > 0 ? 1 : 0
                })
                .ToList();

            // Gán dữ liệu phân trang vào ViewBag
            ViewBag.TotalItems = totalItems;
            ViewBag.CurrentPage = currentPage;
            ViewBag.PageSize = pageSize;
            ViewBag.Searchtext = searchtext;

            return View(products);
        }



        // Phương thức lấy các danh mục sản phẩm (cho sidebar)
        public ActionResult MenuLeft()
        {
            var categories = db.loai_san_pham
                .Select(c => new
                {
                    c.ma_loai,
                    c.ten_loai
                })
                .ToList();

            return PartialView(categories);
        }

        // Phương thức làm mới dữ liệu (ví dụ khi lọc giá hoặc danh mục)
        public ActionResult Refresh()
        {
            // Lấy tất cả sản phẩm nổi bật
            var featuredProducts = db.san_pham
                .Where(p => p.hinh_thuc_ban == 1 && p.so_luong > 0)
                .Take(12)
                .Select(p => new ProductViewModel
                {
                    Id = p.ma_san_pham,
                    Title = p.ten_san_pham,
                    Image = db.hinh_anh_san_pham
                        .Where(img => img.ma_san_pham == p.ma_san_pham)
                        .Select(img => img.hinh_anh)
                        .FirstOrDefault(),
                    Price = p.gia_binh_quan ?? 0,
                    PriceSale = p.giam_gia > 0
                        ? ((p.gia_binh_quan ?? 0) - (p.gia_binh_quan ?? 0) * (p.giam_gia ?? 0) / 100)
                        : (p.gia_binh_quan ?? 0),
                    IsSale = p.giam_gia > 0 ? 1 : 0
                })
                .ToList();

            return PartialView(featuredProducts);
        }



        public ActionResult ProductCategory(string alias, int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home"); // Nếu không có id, chuyển hướng về trang chủ
            }

            // Lấy danh sách các loại sản phẩm (ma_loai) thuộc nhóm loại (ma_nhom_loai)
            var categoryIds = db.loai_san_pham
                .Where(x => x.ma_nhom_loai == id)
                .Select(x => x.ma_loai)
                .ToList();

            if (!categoryIds.Any())
            {
                return HttpNotFound(); // Trả về 404 nếu không tìm thấy loại sản phẩm nào thuộc nhóm loại
            }

            // Lấy thông tin nhóm loại
            var groupCategory = db.nhom_loai.FirstOrDefault(x => x.ma_nhom_loai == id);
            if (groupCategory == null)
            {
                return HttpNotFound(); // Trả về 404 nếu không tìm thấy nhóm loại
            }

            // Truy xuất danh sách sản phẩm theo danh sách ma_loai
            var products = db.san_pham
                    .Where(p => categoryIds.Contains((int)p.ma_loai) && p.so_luong > 0)
                    .Select(p => new ProductViewModel
                    {
                        Id = p.ma_san_pham,
                        Title = p.ten_san_pham,
                        Alias = db.loai_san_pham
                                    .Where(l => l.ma_loai == p.ma_loai)
                                    .Select(l => l.ten_loai.Replace(" ", "-").ToLower())
                                    .FirstOrDefault(), // Lấy alias từ tên loại sản phẩm
                        Description = p.mo_ta,
                        Image = db.hinh_anh_san_pham
                                    .Where(img => img.ma_san_pham == p.ma_san_pham)
                                    .Select(img => img.hinh_anh)
                                    .FirstOrDefault(),
                        Price = p.gia_binh_quan ?? 0,
                        PriceSale = p.giam_gia > 0
                                    ? ((p.gia_binh_quan ?? 0) - (p.gia_binh_quan ?? 0) * (p.giam_gia ?? 0) / 100)
                                    : (p.gia_binh_quan ?? 0),
                        IsSale = p.giam_gia > 0 ? 1 : 0
                    })
                    .ToList();


            // Gán thông tin nhóm loại vào ViewBag để hiển thị trong View
            ViewBag.CateName = groupCategory.ten_nhom_loai;
            ViewBag.CateId = groupCategory.ma_nhom_loai;

            return View(products);
        }



        // Hiển thị danh sách sản phẩm nổi bật
        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.san_pham
                .Where(sp => sp.hinh_thuc_ban == 1 && sp.so_luong > 0) // Điều kiện hiển thị
                .Join(db.loai_san_pham, sp => sp.ma_loai, lsp => lsp.ma_loai, (sp, lsp) => new { sp, lsp }) // Kết nối bảng loai_san_pham
                .Join(db.nhom_loai, temp => temp.lsp.ma_nhom_loai, nl => nl.ma_nhom_loai, (temp, nl) => new { temp.sp, temp.lsp, nl }) // Kết nối bảng nhom_loai
                .Select(x => new ProductViewModel
                {
                    Id = x.sp.ma_san_pham,
                    Title = x.sp.ten_san_pham,
                    Alias = x.nl.ten_nhom_loai.Replace(" ", "-").ToLower(), // Lấy tên nhóm loại và chuyển thành alias
                    Description = x.sp.mo_ta,
                    Image = db.hinh_anh_san_pham
                        .Where(img => img.ma_san_pham == x.sp.ma_san_pham)
                        .OrderByDescending(img => img.ma_hinh_anh) // Lấy ảnh đầu tiên
                        .Select(img => img.hinh_anh)
                        .FirstOrDefault(),
                    Price = x.sp.gia_binh_quan ?? 0,
                    PriceSale = x.sp.giam_gia > 0
                        ? ((x.sp.gia_binh_quan ?? 0) - ((x.sp.gia_binh_quan ?? 0) * (x.sp.giam_gia ?? 0) / 100))
                        : (x.sp.gia_binh_quan ?? 0),
                    Quantity = x.sp.so_luong ?? 0,
                    IsSale = x.sp.giam_gia > 0 ? 1 : 0,
                    CategoryId = x.lsp.ma_nhom_loai ?? 0 // Ánh xạ loại sản phẩm chính xác dựa trên nhóm loại
                })
                .ToList();

            return PartialView(items);
        }




        // Hiển thị danh sách sản phẩm khuyến mãi
        public ActionResult Partial_ProductSale()
        {
            // Giả sử giam_gia > 0 là sản phẩm đang có khuyến mãi
            var items = db.san_pham.Where(x => x.giam_gia > 0 && x.so_luong > 0).Take(12).ToList();
            return PartialView(items);
        }

        // Chi tiết sản phẩm
        public ActionResult Detail(string alias, int id)
        {
            // Lấy thông tin chi tiết sản phẩm
            var product = db.san_pham
                .Where(sp => sp.ma_san_pham == id)
                .Join(db.loai_san_pham, sp => sp.ma_loai, lsp => lsp.ma_loai, (sp, lsp) => new { sp, lsp }) // Kết nối bảng loai_san_pham
                .Join(db.nhom_loai, temp => temp.lsp.ma_nhom_loai, nl => nl.ma_nhom_loai, (temp, nl) => new { temp.sp, temp.lsp, nl }) // Kết nối bảng nhom_loai
                .Select(x => new ProductViewModel
                {
                    Id = x.sp.ma_san_pham,
                    Title = x.sp.ten_san_pham,
                    Alias = x.nl.ten_nhom_loai.Replace(" ", "-").ToLower(),
                    Description = x.sp.mo_ta,
                    Image = db.hinh_anh_san_pham
                        .Where(img => img.ma_san_pham == x.sp.ma_san_pham)
                        .OrderByDescending(img => img.ma_hinh_anh)
                        .Select(img => img.hinh_anh)
                        .FirstOrDefault(),
                    Price = x.sp.gia_binh_quan ?? 0,
                    PriceSale = x.sp.giam_gia > 0
                        ? ((x.sp.gia_binh_quan ?? 0) - ((x.sp.gia_binh_quan ?? 0) * (x.sp.giam_gia ?? 0) / 100))
                        : (x.sp.gia_binh_quan ?? 0),
                    Quantity = x.sp.so_luong ?? 0,
                    IsSale = x.sp.giam_gia > 0 ? 1 : 0,
                    CategoryId = x.lsp.ma_nhom_loai ?? 0,
                    CategoryName = x.nl.ten_nhom_loai,
                    ViewCount = x.sp.so_luong_mau_sac ?? 0,
                    ProductImages = db.hinh_anh_san_pham
                        .Where(img => img.ma_san_pham == x.sp.ma_san_pham)
                        .Select(img => new ProductImageViewModel
                        {
                            Image = img.hinh_anh,
                            IsDefault = false // Bạn có thể xác định hình ảnh mặc định theo điều kiện nếu cần
                        })
                        .ToList(),
                    Colors = db.mau_sac
                        .Join(db.thuoc_tinh_san_pham.Where(tt => tt.ma_san_pham == x.sp.ma_san_pham),
                              ms => ms.ma_mau_sac,
                              tt => tt.ma_mau_sac,
                              (ms, tt) => new ColorViewModel
                              {
                                  Id = ms.ma_mau_sac,
                                  Name = ms.ten_mau_sac,
                                  AdditionalPrice = ms.phu_phi_mausac
                              })
                        .Distinct()
                        .ToList(),
                    /* Sizes = db.kich_thuoc
                         .Join(db.thuoc_tinh_san_pham.Where(tt => tt.ma_san_pham == x.sp.ma_san_pham),
                               kt => kt.ma_kich_thuoc,
                               tt => tt.ma_kich_thuoc,
                               (kt, tt) => new SizeViewModel
                               {
                                   Id = kt.ma_kich_thuoc,
                                   Name = kt.ten_kich_thuoc,
                                   AdditionalPrice = kt.phu_phi_size ,
                                   QuantityInStock = (int)tt.so_luong_ton 
                               })
                         .Distinct()
                         .ToList()*/
                })
                .FirstOrDefault();

            if (product == null)
            {
                return HttpNotFound();
            }

            // Cập nhật lượt xem
            var productToUpdate = db.san_pham.Find(id);
            if (productToUpdate != null)
            {
                productToUpdate.so_luong_mau_sac = (productToUpdate.so_luong_mau_sac ?? 0) + 1;
                db.Entry(productToUpdate).Property(x => x.so_luong_mau_sac).IsModified = true;
                db.SaveChanges();
            }

            return View(product);
        }


        [HttpGet]
        public JsonResult GetSizesByColor(int productId, int colorId)
        {
            var sizes = db.kich_thuoc
                .Join(db.thuoc_tinh_san_pham.Where(tt => tt.ma_san_pham == productId && tt.ma_mau_sac == colorId),
                      kt => kt.ma_kich_thuoc,
                      tt => tt.ma_kich_thuoc,
                      (kt, tt) => new
                      {
                          Id = kt.ma_kich_thuoc,
                          Name = kt.ten_kich_thuoc,
                          AdditionalPrice = kt.phu_phi_size,
                          QuantityInStock = tt.so_luong_ton
                      })
                .ToList();

            return Json(sizes, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetPrice(int productId, int colorId, int sizeId)
        {
            var price = db.thuoc_tinh_san_pham
                .Where(tt => tt.ma_san_pham == productId && tt.ma_mau_sac == colorId && tt.ma_kich_thuoc == sizeId)
                .Select(tt => tt.gia_ban)
                .FirstOrDefault();

            return Json(price, JsonRequestBehavior.AllowGet);
        }





    }


    // ViewModel bổ sung để hiển thị chi tiết sản phẩm
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PriceSale { get; set; }
        public int Quantity { get; set; }
        public int IsSale { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public int ViewCount { get; set; }
        public List<ProductImageViewModel> ProductImages { get; set; }

        public List<ColorViewModel> Colors { get; set; }
        /*   public List<SizeViewModel> Sizes { get; set; }*/
    }

    public class ProductImageViewModel
    {
        public string Image { get; set; }
        public bool IsDefault { get; set; }
    }

    public class ColorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AdditionalPrice { get; set; }
    }

    public class SizeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AdditionalPrice { get; set; }
        public int QuantityInStock { get; set; }

    }

}