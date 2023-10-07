using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Matab
{

    public class CrudSec : CrudBase<User>
    {
        public CrudSec(string connectionString) : base(connectionString)
        {
        }

        public override string Create()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into SecTable(Id,SecName,SecSalary,SecSalaryDate,SecPhone,SecExplanation) values(@Id,@SecName,@SecSalary,@SecSalaryDate,@SecPhone,@SecExplanation)";
                cmd.Parameters.AddWithValue("@Id", Variable.SecId);
                cmd.Parameters.AddWithValue("@SecName", Variable.SecName);
                cmd.Parameters.AddWithValue("@SecSalary", Variable.SecSalary);
                cmd.Parameters.AddWithValue("@SecSalaryDate", Variable.SecSalaryDate);
                cmd.Parameters.AddWithValue("@SecPhone", Variable.SecPhone);
                cmd.Parameters.AddWithValue("@SecExplanation", Variable.SecExplanation);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "اطلاعات منشی ثبت شد";
            }
        }

        public override void Delete()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from SecTable where Id = @D";
                cmd.Parameters.AddWithValue("@D", Variable.DeleteIdSec);
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
                Variable.SecDs.Clear();
                con.Open();
                adp.SelectCommand.CommandText = "select * from SecTable";
                adp.Fill(Variable.SecDs, "SecTable");
                con.Close();
            }
        }

        public override void Update()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE SecTable SET SecName = @SecName, SecSalary = @SecSalary, SecPhone = @SecPhone, SecSalaryDate = @SecSalaryDate, SecExplanation = @SecExplanation  WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Variable.SecIdEdit);
                cmd.Parameters.AddWithValue("@SecName", Variable.SecNameExport);
                cmd.Parameters.AddWithValue("@SecSalary", Variable.SecSalaryExport);
                cmd.Parameters.AddWithValue("@SecPhone", Variable.SecPhoneExport);
                cmd.Parameters.AddWithValue("@SecSalaryDate", Variable.SecSalaryDateExport);
                cmd.Parameters.AddWithValue("@SecExplanation", Variable.SecExplanationExport);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
