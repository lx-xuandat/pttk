namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietNhap
    {
        public int FK_iMahoadonnhapID { get; set; }
        public int FK_iMathangID { get; set; }
        public int iSoluong { get; set; }
        public decimal dGianhap { get; set; }
    
        public virtual HoaDonNhap HoaDonNhap { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}
