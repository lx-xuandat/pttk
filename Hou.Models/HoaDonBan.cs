namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDonBan
    {
        public HoaDonBan()
        {
            this.ChiTietBans = new HashSet<ChiTietBan>();
        }
    
        public int PK_iMahoadonbanID { get; set; }
        public int FK_iManhanvienID { get; set; }
        public System.DateTime dNgaythang { get; set; }
    
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
