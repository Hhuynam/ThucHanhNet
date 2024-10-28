using System;
using System.Data;
using System.Data.SqlClient;

namespace DLL_K215480106063
{

    public class sqlserver
    {
        private const string SP = "SP_API";
        public string cnstr;
        public string get_json(string action, SqlCommand cmd)
        {
            using (SqlConnection conn = new SqlConnection(cnstr))
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SP;
                cmd.Parameters.Add("action", SqlDbType.NVarChar, 50).Value = action;
                object result = cmd.ExecuteScalar();
                return (string)result;
            }
        }

        public string Them_MaSinhVien(string MaSinhVien)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Parameters.Add("MaSinhVien", SqlDbType.NVarChar, 50).Value = MaSinhVien;
                string json = get_json("Them_MaSinhVien", cmd);
                return json;
            }
        }
        public string Them_HoTen(string HoTen)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Parameters.Add("HoTen", SqlDbType.NVarChar, 50).Value = HoTen;
                string json = get_json("Them_HoTen", cmd);
                return json;
            }
        }
        public string Them_Lop(string HoTen)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                //cmd.Parameters.Add("Lop", SqlDbType.NVarChar, 50).Value = Lop;
                string json = get_json("Them_Lop", cmd);
                return json;
            }
        }
    }
}

