using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public class CrudMainGrid : CrudBase<User>
    {
        public CrudMainGrid(string connectionString) : base(connectionString)
        {
        }

        public override string Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = con;
                Variable.TodayAppoint.Clear();
                con.Open();
                adp.SelectCommand.CommandText = $"SELECT * FROM AppointTable WHERE Date LIKE '{Variable.TodayTime}'";
                adp.Fill(Variable.TodayAppoint, "AppointTable");
                con.Close();
                
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
