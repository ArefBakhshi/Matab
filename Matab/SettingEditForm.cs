using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matab
{
    public partial class SettingEditForm : Form
    {
        CrudSetting crudSetting = new CrudSetting(AppConfig.ConnectionString);
        public SettingEditForm()
        {
            InitializeComponent();
        }

        private void SettingEditForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            
            textMatabNameExport.Text = Variable.SettingMatabNameImport;
            textDoctorNameExport.Text= Variable.SettingDoctorNameImport;
            textTelephoneExport.Text = Variable.SettingTelephoneImport;
            textPhoneExport.Text = Variable.SettingPhoneImport;
            textAddressExport.Text = Variable.SettingAddressImport; 
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
            Variable.SettingMatabNameExport = textMatabNameExport.Text;
            Variable.SettingDoctorNameExport = textDoctorNameExport.Text;
            Variable.SettingTelephoneExport = textTelephoneExport.Text;
            Variable.SettingPhoneExport = textPhoneExport.Text;
            Variable.SettingAddressExport = textAddressExport.Text;
            crudSetting.Update();
            crudSetting.Read();
            this.Close();
            
        }

        
    }
}
