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
    public partial class FormUserEdit : Form
    {
        CrudUserMng crudUserMng = new CrudUserMng(AppConfig.ConnectionString);
        public FormUserEdit()
        {
            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            textUserEdit.Text = Variable.userEditImport;
            textPasswordEdit.Text = Variable.passwordEditImport;
            cmbAccessEdit.Text = Variable.accessEditImport;
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Variable.userEditExport = textUserEdit.Text;
            Variable.passwordEditExport = textPasswordEdit.Text;
            Variable.accessEditExport = cmbAccessEdit.Text;
            crudUserMng.Update();
            crudUserMng.Read();
            this.Close();
        }
    }
}