using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matab
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        CrudMainGrid crudMainGrid = new CrudMainGrid(AppConfig.ConnectionString);
        private void buttonX1_Click(object sender, EventArgs e)
        {
            new FormUsers().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            lblUser.Text = Variable.stru;
            if (lblUser.Text == "کاربر عادی")
            {
                buttonX1.Enabled = false;
                buttonX4.Enabled = false;
            }
            else
            {
                buttonX1.Enabled = true;
                buttonX4.Enabled = true;
            }


            var persianCalendar = new System.Globalization.PersianCalendar();
            lblDate.Text = $"{persianCalendar.GetYear(DateTime.Now)}/{persianCalendar.GetMonth(DateTime.Now):D2}/{persianCalendar.GetDayOfMonth(DateTime.Now):D2}";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday: lblDay.Text = "یکشنبه"; break;
                case DayOfWeek.Monday: lblDay.Text = "دوشنبه"; break;
                case DayOfWeek.Tuesday: lblDay.Text = "سه شنبه"; break;
                case DayOfWeek.Wednesday: lblDay.Text = "چهار شنبه"; break;
                case DayOfWeek.Thursday: lblDay.Text = "پنج شنبه"; break;
                case DayOfWeek.Friday: lblDay.Text = "جمعه"; break;
                case DayOfWeek.Saturday: lblDay.Text = "شنبه"; break;
            }
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            new FormSecretary().ShowDialog();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            new FormSetting().ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            new FormSecPay().ShowDialog();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            new FormPayRecordList().ShowDialog();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            new FormAppointment().ShowDialog();
        }

        private void analogClockControl1_ValueChanged(object sender, EventArgs e)
        {
            Variable.TodayTime = lblDate.Text;
            crudMainGrid.Read();
            GridViewMain.DataSource = null;
            GridViewMain.DataSource = Variable.TodayAppoint;
            GridViewMain.DataMember = "AppointTable";
            GridViewMain.ClearSelection();
        }
    }
}
