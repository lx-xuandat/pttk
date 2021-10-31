namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.HoaDonNhaps = new HashSet<HoaDonNhap>();
        }
    
        public int PK_iManhacungcapID { get; set; }
        public string sTennhacungcap { get; set; }
        public string sSDT { get; set; }
        public string sDiachi { get; set; }
    
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
    }
}
