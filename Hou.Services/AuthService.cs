using Hou.Models;
using Hou.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hou.Services
{
    public class AuthService
    {
        protected AuthRepository authRepository;
        public AuthService()
        {
            authRepository = new AuthRepository();
        }

        public NhanVien Login(NhanVien nhanVien)
        {
            return authRepository.Login(nhanVien);
        }
    }
}
