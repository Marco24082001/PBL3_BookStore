//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHI_TIET_HOA_DON_NHAP
    {
        public int ID { get; set; }
        public string MaDonNhap { get; set; }
        public string MaSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        public virtual HOA_DON_NHAP HOA_DON_NHAP { get; set; }
        public virtual SACH SACH { get; set; }
    }
}
