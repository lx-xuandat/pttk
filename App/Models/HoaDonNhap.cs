//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            this.ChiTietNhap = new HashSet<ChiTietNhap>();
        }
    
        public int PK_iMahoadonnhapID { get; set; }
        public int FK_iManhacungcapID { get; set; }
        public int FK_iManhanvienID { get; set; }
        public System.DateTime dNgaythang { get; set; }
    
        public virtual ICollection<ChiTietNhap> ChiTietNhap { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
