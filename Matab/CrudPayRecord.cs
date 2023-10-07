using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public class CrudPayRecord : CrudBase<User>
    {
        public CrudPayRecord(string connectionString) : base(connectionString)
        {
        }
        public override string Create()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into RecordTable(Name,Salary,SalaryDate,SalaryPayDate,PayNum) values(@Name,@Salary,@SalaryDate,@SalaryPayDate,@PayNum)";
                
                cmd.Parameters.AddWithValue("@Name", Variable.PayRecordName);
                cmd.Parameters.AddWithValue("@Salary", Variable.PayRecordSalary);
                cmd.Parameters.AddWithValue("@SalaryDate", Variable.PayRecordSalaryDate);
                cmd.Parameters.AddWithValue("@SalaryPayDate", Variable.PayRecordSalaryPayDate);
                cmd.Parameters.AddWithValue("@PayNum", Variable.PayRecordPayNum);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "اطلاعات مطب ثبت شد";
            }
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override void Read()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
