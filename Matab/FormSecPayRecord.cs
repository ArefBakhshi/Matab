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
    public partial class FormSecPayRecord : Form
    {
        public FormSecPayRecord()
        {
            InitializeComponent();
        }
        CrudPayRecord crudPayRecord = new CrudPayRecord(AppConfig.ConnectionString);
        private void FormSecPayRecord_Load(object sender, EventArgs e)
        {
            textSecName.Text = Variable.SecPayRecordNameImport;
            textSecSalary.Text = Variable.SecPayRecordSalaryImport;
            textSecSalaryDate.Text =Convert.ToString( Variable.SecPayRecordSalaryDateImport);
            textSalaryPayDate.Text = Variable.SecPayRecordSalaryTodayImport;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (
        string.IsNullOrEmpty(textSalaryPayDate.Text) ||
        string.IsNullOrEmpty(textSecName.Text) ||
        string.IsNullOrEmpty(textSecSalary.Text) ||
        string.IsNullOrEmpty(textSecSalaryDate.Text) ||
        string.IsNullOrEmpty(textSecPayNum.Text))
            {
                MessageBox.Show(".لطفا اطلاعات مورد نیاز را وارد کنید");
                return;
            }
            Variable.PayRecordName = textSecName.Text;
            Variable.PayRecordSalary = textSecSalary.Text;
            Variable.PayRecordSalaryDate = textSecSalaryDate.Text;
            Variable.PayRecordSalaryPayDate = textSalaryPayDate.Text;
            Variable.PayRecordPayNum =textSecPayNum.Text;
            crudPayRecord.Create();

            this.Close();


        }


    }
}
