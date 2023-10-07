using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Matab
{
    public class CrudLogin : CrudBase<User>
    {
        public CrudLogin(string connectionString) : base(connectionString)
        {
        }

        public override string Create()
        {
            throw new NotImplementedException();
        }


        public override void Read()

        {
            
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM UserTable WHERE UserName = @UserName AND Password = @Password AND Access = @Access";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.Parameters.AddWithValue("@UserName", Variable.userLogin);
                cmd.Parameters.AddWithValue("@Password", Variable.passwordLogin);
                cmd.Parameters.AddWithValue("@Access", Variable.accessLogin);

                Variable.L = (int)cmd.ExecuteScalar();
                con.Close();

                
            }
        }
        public override void Update()
        {
            throw new NotImplementedException();
        }
        public override void Delete()
        {
            throw new NotImplementedException();
        }
    }


}

