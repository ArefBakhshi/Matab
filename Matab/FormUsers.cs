using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Matab
{
    public partial class FormUsers : Form
    {
        
        CrudUserMng crudUserMng = new CrudUserMng(AppConfig.ConnectionString);
        

        public FormUsers()
        {
            InitializeComponent();
        }






        private bool excludeClearSelection = false;

        private void FormUsers_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            crudUserMng.Read();
            GridViewUsers.DataSource = Variable.UserMngDs;
            GridViewUsers.DataMember = "UserTable";
            GridViewUsers.Columns[0].HeaderText = "شناسه";
            GridViewUsers.Columns[1].HeaderText = "نام کاربری";
            GridViewUsers.Columns[2].HeaderText = "رمز عبور";
            GridViewUsers.Columns[3].HeaderText = "سطح دسترسی";
            GridViewUsers.ClearSelection();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (
        string.IsNullOrEmpty(textUserName.Text) ||
        string.IsNullOrEmpty(textPassword.Text) ||
        string.IsNullOrEmpty(cmbAccess.Text) )
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را وارد کنید");
                return;
            }
            Variable.UserMngUserName = textUserName.Text;
            Variable.UserMngPassword = textPassword.Text;
            Variable.UserMngAccess = cmbAccess.Text;
            crudUserMng.Create();
            crudUserMng.Read();
            GridViewUsers.ClearSelection();
            MessageBox.Show("ثبت کاربر انجام شد");
            textUserName.Text = string.Empty;
            textPassword.Text = string.Empty;
            cmbAccess.Text = string.Empty;



        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            if (GridViewUsers.SelectedCells.Count > 0)
            {
                Variable.DeleteIdUser = Convert.ToInt32(GridViewUsers.SelectedCells[0].Value);
                crudUserMng.Delete();
                crudUserMng.Read();
                GridViewUsers.ClearSelection();

                MessageBox.Show("حذف کاربر انجام شد");
            }
            else { MessageBox.Show("قبل از حذف، لطفا منشی مورد نظر را انتخاب کنید"); }
        }

        private void GridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                buttonX3.Enabled = true;
                buttonX1.Enabled = true;
                Variable.userEditImport = GridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                Variable.passwordEditImport = GridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                Variable.accessEditImport = GridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                Variable.userIdEdit = GridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                


            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            new FormUserEdit().ShowDialog();
            GridViewUsers.ClearSelection();
        }

        private void GridViewUsers_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!excludeClearSelection)
            {
                buttonX3.Enabled = true;
                buttonX1.Enabled = true;

            }
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {
            buttonX3.Enabled = false;
            buttonX1.Enabled = false;
            GridViewUsers.ClearSelection();
        }
    }
}
