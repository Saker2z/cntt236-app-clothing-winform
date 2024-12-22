using BanHangThoiTrangMVC.Models;
using QLSHOPFASHION.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace QLSHOPFASHION.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly QL_SHOP_FASHIONEntities5 db = new QL_SHOP_FASHIONEntities5();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partial_Item_Cart()
        {
            return PartialView("Partial_Item_Cart");
        }


        [HttpPost]
        public JsonResult PlaceOrder(string hoTen, string diaChi, string soDienThoai, List<CartItem> cart)
        {
            try
            {
                // Kiểm tra đầu vào
                if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(soDienThoai) || cart == null || !cart.Any())
                {
                    return Json(new { success = false, message = "Thông tin không hợp lệ!" });
                }

                // Tạo đối tượng đại diện cho đơn đặt hàng web
                var order = new don_dat_hang_web
                {
                    ho_ten = hoTen,
                    dia_chi = diaChi,
                    ten_san_pham = "không có",
                    so_luong = 1,
                    gia_tien = 1,
                    thoi_gian_dat = DateTime.Now,
                    so_dien_thoai = soDienThoai,
                    ghi_chu = "Không có",
                    trangThai = "Chưa duyệt"
                };

                // Thêm đơn đặt hàng vào database
                db.don_dat_hang_web.Add(order);
                db.SaveChanges();
                // Duyệt qua từng sản phẩm trong giỏ hàng
                foreach (var item in cart)
                {
                    // Bỏ qua nếu sản phẩm không hợp lệ
                    if (item == null || string.IsNullOrEmpty(item.TenSanPham) || item.SoLuong <= 0)
                    {
                        continue;
                    }

                    // Chuyển List<string> GhiChu thành chuỗi (nếu không null)
                    string ghiChu = item.GhiChu != null ? string.Join("; ", item.GhiChu) : "";
                   
                    var matches = Regex.Matches(ghiChu, @"\d+").Cast<Match>().Select(m => m.Value).ToList();

                    // Kiểm tra có đủ 3 số không
                    if (matches.Count < 3)
                    {
                        continue;
                    }

                    // Lấy 3 số liên tiếp đầu tiên (nếu có đủ)
                    string firstNumber = matches.ElementAtOrDefault(0);
                    string secondNumber = matches.ElementAtOrDefault(1);
                    string thirdNumber = matches.ElementAtOrDefault(2);
                    int masp = int.Parse(firstNumber);
                    int mamau = int.Parse(secondNumber);
                    int masize = int.Parse(thirdNumber);

                    var sp = (from i in db.thuoc_tinh_san_pham
                              where i.ma_san_pham == masp && i.ma_mau_sac == mamau && i.ma_kich_thuoc == masize
                              select i.ma_thuoc_tinh).FirstOrDefault();

                    if (sp == null)
                    {
                        continue; // Không tìm thấy sản phẩm, bỏ qua
                    }

                    var gias = (from i in db.thuoc_tinh_san_pham
                                where i.ma_thuoc_tinh == sp
                                select i.gia_ban).FirstOrDefault();

                    // Tạo đối tượng chi tiết đơn đặt hàng
                    var orderDetail = new chi_tiet_don_web
                    {
                        id_don_hang = order.id_don_hang, // Liên kết với đơn đặt hàng
                        ma_thuoc_tinh = sp,
                        so_luong = item.SoLuong,
                        thanh_tien = (item.SoLuong * (gias ?? 0)), // Tính thanh tiền từ số lượng và giá
                        gia = gias ?? 0
                    };

                    // Thêm chi tiết đơn đặt hàng vào database
                    db.chi_tiet_don_web.Add(orderDetail);
                }

                // Lưu tất cả các thay đổi vào database
                db.SaveChanges();

                return Json(new { success = true, message = "Đặt hàng thành công!" });
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lưu đơn hàng: " + ex.Message);
                return Json(new { success = false, message = "Có lỗi xảy ra, vui lòng thử lại sau!" });
            }
        }





    }



    // Định nghĩa model tạm cho CartItem
    public class CartItem
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTien { get; set; }

        public List<string> GhiChu { get; set; } // Ghi chú là List<string>

    }
}


