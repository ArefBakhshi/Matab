using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
namespace Matab
{

    public class CrudUserMng : CrudBase<User>
    {
        public CrudUserMng(string connectionString) : base(connectionString)
        {
        }
        

        public override string Create()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into UserTable(UserName,Password,Access) values(@UserName,@Password,@Access)";
                cmd.Parameters.AddWithValue("@UserName", Variable.UserMngUserName);
                cmd.Parameters.AddWithValue("@Password", Variable.UserMngPassword);
                cmd.Parameters.AddWithValue("@Access", Variable.UserMngAccess);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "ثبت کاربر انجام شد";
            }
        }



        public override void Read()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = con;
                con.Open();
                Variable.UserMngDs.Clear();
                adp.SelectCommand.CommandText = "select * from UserTable";
                adp.Fill(Variable.UserMngDs, "UserTable");
                con.Close();

            }
        }

        public override void Update()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE UserTable SET UserName = @UserName, Password = @Password, Access = @AccessLevel WHERE id = @id";
                cmd.Parameters.AddWithValue("@UserName", Variable.userEditExport);
                cmd.Parameters.AddWithValue("@Password", Variable.passwordEditExport);
                cmd.Parameters.AddWithValue("@AccessLevel", Variable.accessEditExport);
                cmd.Parameters.AddWithValue("@id", Variable.userIdEdit);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }

        public override void Delete()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from UserTable where Id = @N";
                cmd.Parameters.AddWithValue("@N", Variable.DeleteIdUser);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }        
    }
}
