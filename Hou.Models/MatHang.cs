namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatHang
    {
        public MatHang()
        {
            this.ChiTietBans = new HashSet<ChiTietBan>();
            this.ChiTietNhaps = new HashSet<ChiTietNhap>();
        }
    
        public int PK_iMamathangID { get; set; }
        public int FK_iMaloaihangID { get; set; }
        public string sTenhang { get; set; }
        public decimal dGiaban { get; set; }
        public int iSoluong { get; set; }
        public string sDonvitinh { get; set; }
        public string sMavach { get; set; }
    
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }
        public virtual ICollection<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
    }
}
