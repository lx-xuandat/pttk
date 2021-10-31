namespace Hou.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Role
    {
        public Role()
        {
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public int PK_iRoleID { get; set; }
        public string sTen { get; set; }
    
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
