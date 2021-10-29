using App.Models;
using App.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services
{
    public class AuthService
    {
        protected AuthRepository authRepository;

        public AuthService()
        {
            authRepository = new AuthRepository();
        }

        public NhanVien login(NhanVien nhanvien)
        {
            return authRepository.login(nhanvien);
        }
    }
}
