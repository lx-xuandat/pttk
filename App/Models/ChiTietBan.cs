namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietBan
    {
        public int FK_iMahoadonbanID { get; set; }
        public int FK_iMamathangID { get; set; }
        public int iSoluong { get; set; }
        public decimal dGiaban { get; set; }
    
        public virtual HoaDonBan HoaDonBan { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}
