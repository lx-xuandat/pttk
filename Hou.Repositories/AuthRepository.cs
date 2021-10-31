using Hou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hou.Repositories
{
    public class AuthRepository : SQLEXPRESS
    {
        public NhanVien Login(NhanVien nhanVien)
        {
            return new NhanVien()
            {
                sUser = "Luu Xuan Dat"
            };
        }

        public NhanVien register(NhanVien nhanvien)
        {
            NhanVien result = null;
            return result;
        }

        public NhanVien confirmPassword(NhanVien nhanvien)
        {
            NhanVien result = null;
            return result;
        }
    }
}
