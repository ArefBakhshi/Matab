using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Matab
{
    public class CrudSetting : CrudBase<User>
    {
        public CrudSetting(string connectionString) : base(connectionString)
        {
        }
        public override string Create()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into MatabTable(Id,MatabName,DoctorName,Telephone,Phone,Address) values(@Id,@MatabName,@DoctorName,@Telephone,@Phone,@Address)";
                cmd.Parameters.AddWithValue("@Id",Variable.SettingId);
                cmd.Parameters.AddWithValue("@MatabName",Variable.SettingMatabName);
                cmd.Parameters.AddWithValue("@DoctorName",Variable.SettingDoctorName);
                cmd.Parameters.AddWithValue("@Telephone",Variable.SettingTelephone);
                cmd.Parameters.AddWithValue("@Phone",Variable.SettingPhone);
                cmd.Parameters.AddWithValue("@Address",Variable.SettingAddress);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "اطلاعات مطب ثبت شد";
            }
        }

        public override void Delete()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandText = "delete from MatabTable where Id = @D";
                cmd.Parameters.AddWithValue("@D", Variable.DeleteIdSetting);
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
                Variable.SettingDs.Clear();
                con.Open();
                adp.SelectCommand.CommandText = "select * from MatabTable";
                adp.Fill(Variable.SettingDs, "MatabTable");
                con.Close();
            }
        }

        public override void Update()
        {
            using (SqlConnection con = new SqlConnection(AppConfig.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE MatabTable SET MatabName = @MatabName, DoctorName = @DoctorName, Telephone = @Telephone, Phone = @Phone, Address = @Address  WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Variable.SettingIdImport);
                cmd.Parameters.AddWithValue("@MatabName", Variable.SettingMatabNameExport);
                cmd.Parameters.AddWithValue("@DoctorName", Variable.SettingDoctorNameExport);
                cmd.Parameters.AddWithValue("@Telephone", Variable.SettingTelephoneExport);
                cmd.Parameters.AddWithValue("@Phone", Variable.SettingPhoneExport);
                cmd.Parameters.AddWithValue("@Address", Variable.SettingAddressExport);
                con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
            }
        }
    }
}
