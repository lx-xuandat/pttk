namespace App.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatHang
    {
        public MatHang()
        {
            this.ChiTietBan = new HashSet<ChiTietBan>();
            this.ChiTietNhap = new HashSet<ChiTietNhap>();
        }
    
        public int PK_iMamathangID { get; set; }
        public int FK_iMaloaihangID { get; set; }
        public string sTenhang { get; set; }
        public decimal dGiaban { get; set; }
        public int iSoluong { get; set; }
        public string sDonvitinh { get; set; }
        public string sMavach { get; set; }
    
        public virtual ICollection<ChiTietBan> ChiTietBan { get; set; }
        public virtual ICollection<ChiTietNhap> ChiTietNhap { get; set; }
        public virtual LoaiHang LoaiHang { get; set; }
    }
}
