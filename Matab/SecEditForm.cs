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
    public partial class SecEditForm : Form
    {
        CrudSec crudSec = new CrudSec(AppConfig.ConnectionString);
        public SecEditForm()
        {
            InitializeComponent();
        }

        private void SecEditForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textSecNameEdit.Text = Variable.SecNameImport;
            textSecPhoneEdit.Text = Variable.SecPhoneImport;
            textSecSalaryEdit.Text = Variable.SecSalaryImport;
            textSecPayDateEdit.Text = Variable.SecSalaryDateImport;
            textSecExplanationEdit.Text = Variable.SecExplanationImport;
        }
        private void buttonUpdateEdit_Click(object sender, EventArgs e)
        {
            Variable.SecNameExport = textSecNameEdit.Text;
            Variable.SecPhoneExport = textSecPhoneEdit.Text;
            Variable.SecSalaryExport = textSecSalaryEdit.Text;
            Variable.SecSalaryDateExport = textSecPayDateEdit.Text;
            Variable.SecExplanationExport = textSecExplanationEdit.Text;
            crudSec.Update();
            crudSec.Read();
            this.Close();
        }

        
    }
}
