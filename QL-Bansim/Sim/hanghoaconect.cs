using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Bansim
{
    class hanghoaconect
    {
        ClassConnection con = new ClassConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tb_sim";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public DataTable GetData(string dieukien)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_sim " + dieukien;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }



        public bool AddData(Classhanghoa hh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into  tb_sim values ('" + hh.Ma + "',N'" + hh.Ten + "',N'" + hh.SO + "',N'" + hh.LOAI + "','" + hh.DONGIA + "')";
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
       


        public bool UpdateData(Classhanghoa hh)
        {
            cmd.CommandText = "update tb_sim set TenNhaMang= N'" + hh.Ten + "',SDTSim=N'" + hh.SO + "',Loai=N'" + hh.LOAI + "',DonGia='" + hh.DONGIA + "' where MaSim='" + hh.Ma + "'";
            
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
            cmd.CommandText = "delete tb_sim where MaSim='" + ma + "'";
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
