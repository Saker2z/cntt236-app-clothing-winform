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
    
    public partial class kich_thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kich_thuoc()
        {
            this.thuoc_tinh_san_pham = new HashSet<thuoc_tinh_san_pham>();
        }
    
        public int ma_kich_thuoc { get; set; }
        public string ten_kich_thuoc { get; set; }
        public decimal phu_phi_size { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thuoc_tinh_san_pham> thuoc_tinh_san_pham { get; set; }
    }
}