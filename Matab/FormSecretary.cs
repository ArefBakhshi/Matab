using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Matab
{
    public partial class FormSecretary : Form
    {
        private bool excludeClearSelection = false;
        CrudSec crudSec = new CrudSec(AppConfig.ConnectionString);
        public FormSecretary()
        {
            InitializeComponent();
        }
        

        private void FormSecretary_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            crudSec.Read();
            GridViewSec.DataSource = Variable.SecDs;
            GridViewSec.DataMember = "SecTable";
            GridViewSec.Columns[0].HeaderText = "کد";
            GridViewSec.Columns[1].HeaderText = "نام و نام خانوادگی";
            GridViewSec.Columns[2].HeaderText = "حقوق";
            GridViewSec.Columns[3].HeaderText = "موعد پرداخت حقوق";
            GridViewSec.Columns[4].HeaderText = "همراه";
            GridViewSec.Columns[5].HeaderText = "توضیحات";
            GridViewSec.ClearSelection();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (
        string.IsNullOrEmpty(textSecName.Text) ||
        string.IsNullOrEmpty(integerSecId.Text) ||
        string.IsNullOrEmpty(textSecPhone.Text) ||
        string.IsNullOrEmpty(textSecSalary.Text) ||
        string.IsNullOrEmpty(maskedSecSalaryDate.Text))
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را وارد کنید");
                return;
            }

            Variable.SecExplanation = textSecExplanation.Text;
            Variable.SecName = textSecName.Text;
            Variable.SecId = Convert.ToInt32(integerSecId.Text);
            Variable.SecPhone = textSecPhone.Text;
            Variable.SecSalary = textSecSalary.Text;
            Variable.SecSalaryDate = maskedSecSalaryDate.Text;
          
            crudSec.Create();
            crudSec.Read();
            GridViewSec.ClearSelection();
            textSecName.Text = string.Empty;
            integerSecId.Text = string.Empty;
            textSecPhone.Text = string.Empty;
            textSecSalary.Text = string.Empty;
            maskedSecSalaryDate.Text = string.Empty;
            textSecExplanation.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            if (GridViewSec.SelectedCells.Count > 0)
            {

                Variable.DeleteIdSec = Convert.ToInt32(GridViewSec.SelectedCells[0].Value);
                crudSec.Delete();
                crudSec.Read();
                GridViewSec.ClearSelection();
                excludeClearSelection = false;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
            }
            else { MessageBox.Show("قبل از حذف، لطفا منشی مورد نظر را انتخاب کنید"); }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewSec.ClearSelection();
            new SecEditForm().ShowDialog();
            excludeClearSelection = false;
            
        }

        

        private void GridViewSec_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!excludeClearSelection)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;

            }
        }

        private void GridViewSec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                buttonUpdate.Enabled = true;
                buttonDelete.Enabled = true;
                Variable.SecIdEdit = Convert.ToInt32(GridViewSec.Rows[e.RowIndex].Cells[0].Value);
                Variable.SecNameImport = GridViewSec.Rows[e.RowIndex].Cells[1].Value.ToString();
                Variable.SecSalaryImport = GridViewSec.Rows[e.RowIndex].Cells[2].Value.ToString();
                Variable.SecSalaryDateImport = GridViewSec.Rows[e.RowIndex].Cells[3].Value.ToString();
                Variable.SecPhoneImport = GridViewSec.Rows[e.RowIndex].Cells[4].Value.ToString();
                Variable.SecExplanationImport = GridViewSec.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void maskedSecSalaryDate_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            GridViewSec.ClearSelection();
        }
    }
}
