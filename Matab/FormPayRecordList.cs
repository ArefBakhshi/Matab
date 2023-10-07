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
    public partial class FormPayRecordList : Form
    {
        public FormPayRecordList()
        {
            InitializeComponent();
        }
        private bool excludeClearSelection = false;

        CrudRecordList crudRecordList = new CrudRecordList(AppConfig.ConnectionString);

        private void FormPayRecordList_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            crudRecordList.Read();
            GridViewRecordList.DataSource = Variable.RecordListDs;
            GridViewRecordList.DataMember = "RecordTable";
            GridViewRecordList.Columns[0].HeaderText = "کد";
            GridViewRecordList.Columns[1].HeaderText = "نام و نام خانوادگی";
            GridViewRecordList.Columns[2].HeaderText = "حقوق";
            GridViewRecordList.Columns[3].HeaderText = "موعد پرداخت حقوق";
            GridViewRecordList.Columns[4].HeaderText = "همراه";
            GridViewRecordList.Columns[5].HeaderText = "توضیحات";
            GridViewRecordList.ClearSelection();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Variable.NameSearch = textBox2.Text;
            crudRecordList.Update();
            GridViewRecordList.DataSource = Variable.RecordListDs;
            GridViewRecordList.DataMember = "RecordTable";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            excludeClearSelection = true;
            if (GridViewRecordList.SelectedCells.Count > 0)
            {
                Variable.DeleteIdSec = Convert.ToInt32(GridViewRecordList.SelectedCells[0].Value);
                crudRecordList.Delete();
                crudRecordList.Read();
                GridViewRecordList.ClearSelection();
                excludeClearSelection = false;                
                buttonDelete.Enabled = false;
            }
            else { MessageBox.Show("قبل از حذف، لطفا منشی مورد نظر را انتخاب کنید"); }



        }

        private void GridViewRecordList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Variable.DeleteIdRecord = Convert.ToInt32(GridViewRecordList.SelectedCells[0].Value);
                buttonDelete.Enabled = true;
            }
        }

        private void GridViewRecordList_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (!excludeClearSelection)
            {
                buttonDelete.Enabled = true;

            }
        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {
            
            buttonDelete.Enabled = false;
            GridViewRecordList.ClearSelection();
        }
    }
}
