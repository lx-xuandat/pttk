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
    
    public partial class HoaDonBan
    {
        public HoaDonBan()
        {
            this.ChiTietBan = new HashSet<ChiTietBan>();
        }
    
        public int PK_iMahoadonbanID { get; set; }
        public int FK_iManhanvienID { get; set; }
        public System.DateTime dNgaythang { get; set; }
    
        public virtual ICollection<ChiTietBan> ChiTietBan { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}