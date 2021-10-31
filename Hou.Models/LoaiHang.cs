namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LoaiHang
    {
        public LoaiHang()
        {
            this.MatHangs = new HashSet<MatHang>();
        }
    
        public int PK_iMaloaihangID { get; set; }
        public string sTenloaihang { get; set; }
    
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}
