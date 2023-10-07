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
    public partial class FormAppointEdit : Form
    {
        public FormAppointEdit()
        {
            InitializeComponent();
        }
        CrudAppointment crudAppointment = new CrudAppointment(AppConfig.ConnectionString);

        private void FormAppointEdit_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textAppointNameEdit.Text = Variable.AppointNameEdit;
            textAppointDateEdit.Text = Variable.AppointDateEdit;
            textAppointInsurEdit.Text = Variable.AppointInsurEdit;
            textAppointTimeEdit.Text = Variable.AppointTimeEdit;    
            textAppointPhoneEdit.Text = Variable.AppointPhoneEdit;
            textAppointTelePhoneEdit.Text = Variable.AppointTelephoneEdit;

        }
        
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (
        string.IsNullOrEmpty(textAppointDateEdit.Text) ||
        string.IsNullOrEmpty(textAppointInsurEdit.Text) ||
        string.IsNullOrEmpty(textAppointNameEdit.Text) ||
        string.IsNullOrEmpty(textAppointTimeEdit.Text) ||
        string.IsNullOrEmpty(textAppointPhoneEdit.Text) ||
        string.IsNullOrEmpty(textAppointTelePhoneEdit.Text))
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را درست وارد کنید");
                return;
            }
            Variable.AppointNameEditEx = textAppointNameEdit.Text;
            Variable.AppointDateEditEx = textAppointDateEdit.Text ;
            Variable.AppointTimeEditEx = textAppointTimeEdit.Text;
            Variable.AppointInsurEditEx = textAppointInsurEdit.Text;
            Variable.AppointPhoneEditEx = textAppointPhoneEdit.Text;
            Variable.AppointTelephoneEditEx = textAppointTelePhoneEdit.Text;
            crudAppointment.Update();
            crudAppointment.Read();
            this.Close();
        }
    }
}
