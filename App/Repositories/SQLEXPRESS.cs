using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class SQLEXPRESS
    {
        protected string sCnn = ConfigurationManager.ConnectionStrings["Context"].ConnectionString;

        public DataTable GetData(string query, SqlParameter[] sqlParameters = null)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(sCnn))
                {
                    using (SqlCommand cmd = new SqlCommand(query, cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (sqlParameters != null)
                        {
                            cmd.Parameters.AddRange(sqlParameters);
                        }
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable tbl = new DataTable();
                            da.Fill(tbl);
                            return tbl;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public int ExecuteNonQuery(string query, SqlParameter[] sqlParameters = null)
        {
            int x = 0;

            try
            {

                using (SqlConnection cnn = new SqlConnection(sCnn))
                {
                    cnn.Open();
                    if (cnn.State == ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            if (sqlParameters != null)
                            {
                                cmd.Parameters.AddRange(sqlParameters);
                            }
                            x = cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            return x;

        }

        /// <summary>
        /// Trả về mã tự tăng của bản ghi trong bảng được insert 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        public int ExcuteInsertWithParameterOutput(string query, SqlParameter[] sqlParameters)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(sCnn))
                {
                    cnn.Open();
                    if (cnn.State == ConnectionState.Open)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, cnn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddRange(sqlParameters);
                            cmd.ExecuteNonQuery();
                            return int.Parse(cmd.Parameters[0].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw (e);
            }
            return 0;
        }
    }
}
