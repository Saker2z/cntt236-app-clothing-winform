//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLSHOPFASHION.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class san_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public san_pham()
        {
            this.chi_tiet_nhap_hang = new HashSet<chi_tiet_nhap_hang>();
            this.hinh_anh_san_pham = new HashSet<hinh_anh_san_pham>();
            this.hinh_anh_san_pham1 = new HashSet<hinh_anh_san_pham>();
            this.nha_cung_cap_san_pham = new HashSet<nha_cung_cap_san_pham>();
            this.thong_tin_san_pham = new HashSet<thong_tin_san_pham>();
            this.thuoc_tinh_san_pham = new HashSet<thuoc_tinh_san_pham>();
        }
    
        public int ma_san_pham { get; set; }
        public string ten_san_pham { get; set; }
        public Nullable<int> ma_loai { get; set; }
        public Nullable<int> ma_thuong_hieu { get; set; }
        public Nullable<decimal> giam_gia { get; set; }
        public Nullable<int> so_luong_kich_thuoc { get; set; }
        public Nullable<int> so_luong_mau_sac { get; set; }
        public Nullable<int> so_luong { get; set; }
        public string mo_ta { get; set; }
        public Nullable<decimal> gia_binh_quan { get; set; }
        public int hinh_thuc_ban { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_nhap_hang> chi_tiet_nhap_hang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hinh_anh_san_pham> hinh_anh_san_pham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hinh_anh_san_pham> hinh_anh_san_pham1 { get; set; }
        public virtual loai_san_pham loai_san_pham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nha_cung_cap_san_pham> nha_cung_cap_san_pham { get; set; }
        public virtual thuong_hieu thuong_hieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thong_tin_san_pham> thong_tin_san_pham { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thuoc_tinh_san_pham> thuoc_tinh_san_pham { get; set; }
    }
}
