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
    
    public partial class nhan_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nhan_vien()
        {
            this.hoa_don = new HashSet<hoa_don>();
            this.hoa_don_doi_tra = new HashSet<hoa_don_doi_tra>();
            this.khuyen_mai = new HashSet<khuyen_mai>();
            this.nhap_hang = new HashSet<nhap_hang>();
        }
    
        public int ma_nhan_vien { get; set; }
        public string ten_nhan_vien { get; set; }
        public string chuc_vu { get; set; }
        public string sdt { get; set; }
        public string dia_chi { get; set; }
        public Nullable<System.DateTime> ngay_vao_lam { get; set; }
        public Nullable<int> tai_khoan_id { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don> hoa_don { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don_doi_tra> hoa_don_doi_tra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khuyen_mai> khuyen_mai { get; set; }
        public virtual tai_khoan tai_khoan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhap_hang> nhap_hang { get; set; }
    }
}
