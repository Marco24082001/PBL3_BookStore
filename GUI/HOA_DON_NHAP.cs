//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL3
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOA_DON_NHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOA_DON_NHAP()
        {
            this.CHI_TIET_HOA_DON_NHAP = new HashSet<CHI_TIET_HOA_DON_NHAP>();
        }
    
        public int MaDonNhap { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_HOA_DON_NHAP> CHI_TIET_HOA_DON_NHAP { get; set; }
    }
}
