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
    public partial class FormSecPay : Form
    {
        
        public FormSecPay()
        {
            InitializeComponent();
        }
        private bool excludeClearSelection = true;
        CrudSecPay crudSecPay = new CrudSecPay(AppConfig.ConnectionString);
        private void FormSecPay_Load(object sender, EventArgs e)
        {

            MaximizeBox = false;
            LblDate.Text = $"{new System.Globalization.PersianCalendar().GetYear(DateTime.Now)}/{new System.Globalization.PersianCalendar().GetMonth(DateTime.Now)}/{new System.Globalization.PersianCalendar().GetDayOfMonth(DateTime.Now)}";
            crudSecPay.Read();
            GridViewSecPay.DataSource = Variable.SecDs;
            GridViewSecPay.DataMember = "SecTable";
            GridViewSecPay.Columns[0].HeaderText = "کد";
            GridViewSecPay.Columns[1].HeaderText = "نام و نام خانوادگی";
            GridViewSecPay.Columns[2].HeaderText = "حقوق";
            GridViewSecPay.Columns[3].HeaderText = "موعد پرداخت حقوق";
            GridViewSecPay.Columns[4].HeaderText = "همراه";
            GridViewSecPay.Columns[5].HeaderText = "توضیحات";
            GridViewSecPay.ClearSelection();
        }

        

        
            

        

        private void GridViewSecPay_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (excludeClearSelection)
            {
                buttonPay.Enabled = true;
                
                
                
            }
            else {
                GridViewSecPay.ClearSelection();
                buttonPay.Enabled = false;
            }
            

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            GridViewSecPay.ClearSelection();
            new FormSecPayRecord().ShowDialog();
            
        }

        private void GridViewSecPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
            Variable.SecPayRecordNameImport = Convert.ToString(GridViewSecPay.Rows[e.RowIndex].Cells[1].Value);
            Variable.SecPayRecordSalaryImport = Convert.ToString(GridViewSecPay.Rows[e.RowIndex].Cells[2].Value);
            Variable.SecPayRecordSalaryDateImport = Convert.ToString( GridViewSecPay.Rows[e.RowIndex].Cells[3].Value);
            Variable.SecPayRecordSalaryTodayImport = $"{new System.Globalization.PersianCalendar().GetYear(DateTime.Now)}/{new System.Globalization.PersianCalendar().GetMonth(DateTime.Now)}/{new System.Globalization.PersianCalendar().GetDayOfMonth(DateTime.Now)}"; ;
            buttonPay.Enabled = true;
            }
        }

        private void FormSecPay_Click(object sender, EventArgs e)
        {
            buttonPay.Enabled = false;
            GridViewSecPay.ClearSelection();
        }
    }

}

