using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class san_pham_DAL
    {
        private readonly context _context;

        public san_pham_DAL(context context)
        {
            _context = context;
        }

        // Thêm sản phẩm mới
        public void AddSanPham(san_phams sanPham)
        {
            _context.san_pham.Add(sanPham);
            _context.SaveChanges();
        }

        // Lấy tất cả sản phẩm
        public List<san_phams> GetAllSanPham()
        {
            return _context.san_pham.ToList();
        }

        // Lấy sản phẩm theo ID
        public san_phams GetSanPhamById(int id)
        {
            return _context.san_pham.Find(id);
        }

        // Cập nhật sản phẩm
        public void UpdateSanPham(san_phams sanPham)
        {
            _context.san_pham.Update(sanPham);
            _context.SaveChanges();
        }

        // Xóa sản phẩm
        public void DeleteSanPham(int id)
        {
            var sanPham = _context.san_pham.Find(id);
            if (sanPham != null)
            {
                _context.san_pham.Remove(sanPham);
                _context.SaveChanges();
            }
        }
    }

}
