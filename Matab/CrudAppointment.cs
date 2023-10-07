using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matab
{
    public class CrudAppointment : CrudBase<User>
    {
        

        public CrudAppointment(string connectionString) : base(connectionString)
        {
        }
       
        public override string Create()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AppointTable(Name,Date,Time,Insurance,Phone,Telephone) values(@Name,@Date,@Time,@Insurance,@Phone,@Telephone)";
                cmd.Parameters.AddWithValue("@Name", Variable.AppointName);
                cmd.Parameters.AddWithValue("@Date", Variable.AppointDate);
                cmd.Parameters.AddWithValue("@Time", Variable.AppointTime);
                cmd.Parameters.AddWithValue("@Insurance", Variable.AppointInsur);
                cmd.Parameters.AddWithValue("@Phone", Variable.AppointPhone);
                cmd.Parameters.AddWithValue("@Telephone", Variable.AppointTelephone);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "نوبت ثبت شد";
            }
        }

        public override void Delete()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from AppointTable where Id = @D";
                cmd.Parameters.AddWithValue("@D", Variable.DeleteIdAppoint);
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
                Variable.Appointments.Clear();
                adp.SelectCommand.CommandText = "select * from AppointTable";
                adp.Fill(Variable.Appointments, "AppointTable");
                con.Close();
            }
            
        }
        
        public override void Update()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE AppointTable SET Name = @Name, Date = @Date, Time = @Time, Insurance = @Insurance, Phone = @Phone, Telephone = @Telephone  WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Name", Variable.AppointNameEditEx);
                cmd.Parameters.AddWithValue("@Id", Variable.AppointIdEdit);
                cmd.Parameters.AddWithValue("@Date", Variable.AppointDateEditEx);
                cmd.Parameters.AddWithValue("@Time", Variable.AppointTimeEditEx);
                cmd.Parameters.AddWithValue("@Insurance", Variable.AppointInsurEditEx);
                cmd.Parameters.AddWithValue("@Phone", Variable.AppointPhoneEditEx);
                cmd.Parameters.AddWithValue("@Telephone", Variable.AppointTelephoneEditEx);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            
        }
    }
}
