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
    
    public partial class don_dat_hang_web
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public don_dat_hang_web()
        {
            this.chi_tiet_don_web = new HashSet<chi_tiet_don_web>();
        }
    
        public int id_don_hang { get; set; }
        public string ho_ten { get; set; }
        public string dia_chi { get; set; }
        public Nullable<System.DateTime> thoi_gian_dat { get; set; }
        public string so_dien_thoai { get; set; }
        public string ten_san_pham { get; set; }
        public int so_luong { get; set; }
        public decimal gia_tien { get; set; }
        public string ghi_chu { get; set; }
        public string trangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_don_web> chi_tiet_don_web { get; set; }
    }
}
