using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public class CrudSecPay : CrudBase<User>
    {
        public CrudSecPay(string connectionString) : base(connectionString)
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
                Variable.SecDs.Clear();
                con.Open();
                adp.SelectCommand.CommandText = "select * from SecTable";
                adp.Fill(Variable.SecDs, "SecTable");
                con.Close();
            }
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
