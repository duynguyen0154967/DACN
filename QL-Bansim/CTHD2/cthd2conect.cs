using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_Bansim.CTHD2
{
    class cthd2conect
    {

        ClassConnection con = new ClassConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select *from tb_CTHD";
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


       
        

   

        public bool DelData(String ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete tb_CTHD where MaHD='" + ma + "'";
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
        //public bool S(String ma)
        //{
        //    DataTable dt = new DataTable();
        //    cmd.CommandText = "select * from tb_CTHD where MaHD='" + ma + "'";
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Connection = con.Connection;
        //    try
        //    {
        //        con.OpenConn();
        //        cmd.ExecuteNonQuery();
        //        con.CloseConn();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        string mex = ex.Message;
        //        cmd.Dispose();
        //        con.CloseConn();
        //    }
        //    return false;
        //}
    }
}
