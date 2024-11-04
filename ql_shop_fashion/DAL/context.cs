using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DTO;



namespace DAL
{
    public class context : DbContext
    {
        public DbSet<chi_tiet_hoa_dons> chi_tiet_hoa_don { get; set; }
        public DbSet<chi_tiet_nhap_hangs> chi_tiet_nhap_hang { get; set; }
        public DbSet<danh_gia_san_phams> danh_gia_san_pham { get; set; }
        public DbSet<hinh_anh_san_phams> hinh_anh_san_pham { get; set; }
        public DbSet<hoa_dons> hoa_don { get; set; }
        public DbSet<key_stores> key_store { get; set; }
        public DbSet<khach_hangs> khach_hang { get; set; }
        public DbSet<khuyen_mais> khuyen_mai { get; set; }
        public DbSet<kich_thuocs> kich_thuoc { get; set; }
        public DbSet<loai_san_phams> loai_san_pham { get; set; }
        public DbSet<man_hinhs> man_hinh { get; set; }
        public DbSet<mau_sacs> mau_sac { get; set; }
        public DbSet<nha_cung_caps> nha_cung_cap { get; set; }
        public DbSet<nha_cung_cap_san_phams> nha_cung_cap_san_pham { get; set; }
        public DbSet<nhan_viens> nhan_vien { get; set; }
        public DbSet<nhap_hangs> nhap_hang { get; set; }
        public DbSet<nhom_loais> nhom_loai { get; set; }
        public DbSet<nhom_quyens> nhom_quyen { get; set; }
        public DbSet<nhom_quyen_quyens> nhom_quyen_quyen { get; set; }
        public DbSet<oauth_providers> oauth_provider { get; set; }
        public DbSet<phan_quyens> phan_quyen { get; set; }
        public DbSet<phuong_thuc_thanh_toans> phuong_thuc_thanh_toan { get; set; }
        public DbSet<quyen_truy_caps> quyen_truy_cap { get; set; }
        public DbSet<refresh_key_useds> refresh_key_used { get; set; }
        public DbSet<san_phams> san_pham { get; set; }
        public DbSet<tai_khoans> tai_khoan { get; set; }
        public DbSet<thong_tin_san_phams> thong_tin_san_pham { get; set; }
        public DbSet<thuoc_tinh_san_phams> thuoc_tinh_san_pham { get; set; }
        public DbSet<thuong_hieus> thuong_hieu { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(Properties.Resources.chuoiknoi);
        }
    }
}
