using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Bansim
{
    class NhanVienConnect
    { ClassConnection con = new ClassConnection();
        SqlCommand cmd = new SqlCommand();
        
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tb_NV";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
      

        public bool AddData(ClassNhanVien nv)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into  tb_NV values ('"+nv.Ma+ "',N'"+nv.Ten+"',N'"+nv.Gioitinh+"',N'"+nv.Diachi+"','"+nv.Sdt+"')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }


        public bool UpdateData(ClassNhanVien nv)
        {
            
            cmd.CommandText = "update tb_NV set TenNV= N'" + nv.Ten + "',GioiTinh=N'" + nv.Gioitinh + "',DiaChi=N'" + nv.Diachi + "',SDT='" + nv.Sdt + "' where MaNV='"+nv.Ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        public bool DelData(String ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete tb_NV where MaNV='"+ma+"'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

    }
}
