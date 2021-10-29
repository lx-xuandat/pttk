using App.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class AuthRepository : SQLEXPRESS
    {
        public NhanVien login(NhanVien nhanvien)
        {
            string query = "sp_auth_login";
            #region PARAMETER
            SqlParameter[] sqlParameters =
            {
                new SqlParameter()
                {
                    ParameterName="@username",
                    DbType = DbType.String,
                    Value = nhanvien.sUser
                },
                new SqlParameter()
                {
                    ParameterName="@password",
                    DbType = DbType.String,
                    Value = nhanvien.sPass
                }
            };
            #endregion
            DataTable kq = this.GetData(query, sqlParameters);
            if (kq.Rows.Count != 0 && kq != null)
            {
                NhanVien nv = new NhanVien();
                /*nv.Username = kq.Rows[0]["Username"].ToString();
                nv.Password = kq.Rows[0]["Password"].ToString();
                nv.MaNhanVien = int.Parse(kq.Rows[0]["MaNhanVien"].ToString());
                nv.HoTen = kq.Rows[0]["HoTen"].ToString();
                nv.GioiTinh = bool.Parse(kq.Rows[0]["GioiTinh"].ToString());
                nv.NgaySinh = kq.Rows[0]["NgaySinh"].ToString();
                nv.SDT = kq.Rows[0]["SDT"].ToString();
                nv.Role = kq.Rows[0]["Role"].ToString();*/
                return nv;
            }
            return null;
        }
    }
}
