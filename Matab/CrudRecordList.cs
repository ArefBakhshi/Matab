using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public class CrudRecordList : CrudBase<User>
    {
        public CrudRecordList(string connectionString) : base(connectionString)
        { }



        public override string Create()
        {
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from RecordTable where Id = @D";
                cmd.Parameters.AddWithValue("@D", Variable.DeleteIdRecord);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
                
                Variable.RecordListDs.Clear();
                adp.SelectCommand.CommandText = "select * from RecordTable";
                adp.Fill(Variable.RecordListDs, "RecordTable");
                con.Close();
            }
        }

        public override void Update()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {

                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = new SqlCommand();
                adp.SelectCommand.Connection = con;
                con.Open();
                Variable.RecordListDs = new DataSet();
                Variable.RecordListDs.Clear();
                adp.SelectCommand.CommandText = "select * from RecordTable where Name like '%' + @Name +'%'";
                adp.SelectCommand.Parameters.AddWithValue("@Name", Variable.NameSearch);
                
                adp.Fill(Variable.RecordListDs, "RecordTable");
                con.Close();
            }
        }
    }
    

}
