namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public NhanVien()
        {
            this.HoaDonBans = new HashSet<HoaDonBan>();
            this.HoaDonNhaps = new HashSet<HoaDonNhap>();
        }
    
        public int PK_iManhanvienID { get; set; }
        public string sHoten { get; set; }
        public Nullable<System.DateTime> dNgaysinh { get; set; }
        public Nullable<bool> bGioitinh { get; set; }
        public string sSDT { get; set; }
        public string sEmail { get; set; }
        public string sDiachi { get; set; }
        public string sUser { get; set; }
        public string sPass { get; set; }
        public bool bQuyen { get; set; }
        public Nullable<int> fkRole { get; set; }
    
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual Role Role { get; set; }
    }
}
