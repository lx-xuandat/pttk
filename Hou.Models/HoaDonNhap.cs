namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonNhap
    {
        public HoaDonNhap()
        {
            this.ChiTietNhaps = new HashSet<ChiTietNhap>();
        }
    
        public int PK_iMahoadonnhapID { get; set; }
        public int FK_iManhacungcapID { get; set; }
        public int FK_iManhanvienID { get; set; }
        public System.DateTime dNgaythang { get; set; }
    
        public virtual ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
