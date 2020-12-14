using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Bansim
{
    class Khachhangconect
    {
        ClassConnection con = new ClassConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tb_KH";
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


        public bool AddData(ClassKhachhang kh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into  tb_KH values ('" + kh.Ma + "',N'" + kh.Ten + "',N'" + kh.Gioitinh + "',N'" + kh.Diachi + "','" + kh.Sdt + "')";
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


        public bool UpdateData(ClassKhachhang kh)
        {

            cmd.CommandText = "update tb_KH set TenKH= N'" + kh.Ten + "',GioiTinh=N'" + kh.Gioitinh + "',DiaChi=N'" + kh.Diachi + "',SDT='" + kh.Sdt + "' where MaKH='" + kh.Ma + "'";
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
            cmd.CommandText = "delete tb_KH where MaKH='" + ma + "'";
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

