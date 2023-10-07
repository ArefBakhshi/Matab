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
    public partial class FormSetting : Form
    {
        private bool excludeClearSelection = false;
        CrudSetting crudSetting = new CrudSetting(AppConfig.ConnectionString);
        public FormSetting()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            crudSetting.Read();
            GridViewSetting.DataSource = Variable.SettingDs;
            GridViewSetting.DataMember = "MatabTable";
            GridViewSetting.Columns[0].HeaderText = "کد";
            GridViewSetting.Columns[1].HeaderText = "نام مطب";
            GridViewSetting.Columns[2].HeaderText = "نام دکتر";
            GridViewSetting.Columns[3].HeaderText = "تلفن";
            GridViewSetting.Columns[4].HeaderText = "همراه";
            GridViewSetting.Columns[5].HeaderText = "ادرس";
            GridViewSetting.ClearSelection();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textAddress.Text) ||
        string.IsNullOrEmpty(textDoctorName.Text) ||
        string.IsNullOrEmpty(textSettingId.Text) ||
        string.IsNullOrEmpty(textPhone.Text) ||
        string.IsNullOrEmpty(textTelephone.Text) ||
        string.IsNullOrEmpty(textMatabName.Text))
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را وارد کنید");
                return;
            }

            Variable.SettingAddress = textAddress.Text;
            Variable.SettingDoctorName = textDoctorName.Text;
            Variable.SettingId = Convert.ToInt32(textSettingId.Text);
            Variable.SettingPhone = textPhone.Text;
            Variable.SettingTelephone = textTelephone.Text;
            Variable.SettingMatabName = textMatabName.Text;

            crudSetting.Create();
            crudSetting.Read();
            GridViewSetting.ClearSelection();
            textAddress.Text = string.Empty;
            textDoctorName.Text = string.Empty;
            textSettingId.Text = string.Empty;
            textPhone.Text = string.Empty;
            textTelephone.Text = string.Empty;
            textMatabName.Text = string.Empty; 
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            if (GridViewSetting.SelectedCells.Count > 0 ) {
                
                Variable.DeleteIdSetting = Convert.ToInt32(GridViewSetting.SelectedCells[0].Value);
                crudSetting.Delete();
                crudSetting.Read();
                GridViewSetting.ClearSelection();
                excludeClearSelection = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else { MessageBox.Show("قبل از حذف، لطفا مطب مورد نظر را انتخاب کنید"); }
            
            
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewSetting.ClearSelection();
            new SettingEditForm().ShowDialog();
            excludeClearSelection = false;
        }

        private void GridViewSetting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                Variable.SettingIdImport = Convert.ToInt32(GridViewSetting.Rows[e.RowIndex].Cells[0].Value);
                Variable.SettingMatabNameImport = GridViewSetting.Rows[e.RowIndex].Cells[1].Value.ToString();
                Variable.SettingDoctorNameImport = GridViewSetting.Rows[e.RowIndex].Cells[2].Value.ToString();
                Variable.SettingTelephoneImport = GridViewSetting.Rows[e.RowIndex].Cells[3].Value.ToString();
                Variable.SettingPhoneImport = GridViewSetting.Rows[e.RowIndex].Cells[4].Value.ToString();
                Variable.SettingAddressImport = GridViewSetting.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }


            
        private void GridViewSetting_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            if (!excludeClearSelection)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                
            }
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewSetting.ClearSelection();
        }

        private void textTelephone_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewSetting.ClearSelection();
        }
    }

    }

