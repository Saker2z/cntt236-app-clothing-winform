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
    
    public partial class hinh_anh_san_pham
    {
        public int ma_hinh_anh { get; set; }
        public Nullable<int> ma_san_pham { get; set; }
        public string hinh_anh { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    
        public virtual san_pham san_pham { get; set; }
        public virtual san_pham san_pham1 { get; set; }
    }
}