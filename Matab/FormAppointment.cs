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
    public partial class FormAppointment : Form
    {
        public FormAppointment()
        {
            InitializeComponent();
        }
        CrudAppointment crudAppointment = new CrudAppointment(AppConfig.ConnectionString);
        private bool excludeClearSelection = false;

        private void FormAppointment_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            crudAppointment.Read();
            GridViewAppoint.DataSource = Variable.Appointments;
            GridViewAppoint.DataMember = "AppointTable";
            GridViewAppoint.Columns[0].HeaderText = "ردیف";
            GridViewAppoint.Columns[1].HeaderText = "نام و نام خانوادگی";
            GridViewAppoint.Columns[2].HeaderText = "تاریخ";
            GridViewAppoint.Columns[3].HeaderText = "زمان";
            GridViewAppoint.Columns[4].HeaderText = "بیمه";
            GridViewAppoint.Columns[5].HeaderText = "تلفن ثابت";
            GridViewAppoint.Columns[6].HeaderText = "تلفن همراه";
            GridViewAppoint.ClearSelection();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (
        string.IsNullOrEmpty(textAppointName.Text) ||
        string.IsNullOrEmpty(textAppointPhone.Text) ||
        string.IsNullOrEmpty(textAppointDate.Text) ||
        string.IsNullOrEmpty(textAppointTime.Text) ||
        string.IsNullOrEmpty(textAppointInsur.Text) ||
        string.IsNullOrEmpty(textAppointTelePhone.Text))
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را وارد کنید");
                return;
            }
            Variable.AppointName = textAppointName.Text;
            Variable.AppointDate = textAppointDate.Text;
            Variable.AppointTime = textAppointTime.Text;
            Variable.AppointInsur = textAppointInsur.Text;
            Variable.AppointTelephone = textAppointTelePhone.Text;
            Variable.AppointPhone = textAppointPhone.Text;
            crudAppointment.Create();
            crudAppointment.Read();
            GridViewAppoint.ClearSelection();
            textAppointName.Text = string.Empty;
            textAppointDate.Text = string.Empty;
            textAppointTime.Text = string.Empty;
            textAppointInsur.Text = string.Empty;
            textAppointTelePhone.Text = string.Empty;
            textAppointPhone.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            if (GridViewAppoint.SelectedCells.Count > 0)
            {
                Variable.DeleteIdAppoint = Convert.ToInt32(GridViewAppoint.SelectedCells[0].Value);
                crudAppointment.Delete();
                crudAppointment.Read();
                GridViewAppoint.ClearSelection();
                excludeClearSelection = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else { MessageBox.Show("قبل از حذف، لطفا نوبت مورد نظر را انتخاب کنید"); }
        }

        private void GridViewAppoint_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                Variable.AppointIdEdit =Convert.ToInt32( GridViewAppoint.Rows[e.RowIndex].Cells[0].Value);
                Variable.AppointNameEdit = GridViewAppoint.Rows[e.RowIndex].Cells[1].Value.ToString();
                Variable.AppointDateEdit = GridViewAppoint.Rows[e.RowIndex].Cells[2].Value.ToString();
                Variable.AppointTimeEdit = GridViewAppoint.Rows[e.RowIndex].Cells[3].Value.ToString();
                Variable.AppointInsurEdit = GridViewAppoint.Rows[e.RowIndex].Cells[4].Value.ToString();
                Variable.AppointPhoneEdit = GridViewAppoint.Rows[e.RowIndex].Cells[5].Value.ToString();
                Variable.AppointTelephoneEdit = GridViewAppoint.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void GridViewAppoint_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!excludeClearSelection)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewAppoint.ClearSelection();
        }

        private void textAppointTime_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewAppoint.ClearSelection();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewAppoint.ClearSelection();            
            new FormAppointEdit().ShowDialog();
            excludeClearSelection = false;
        }
    }
}
