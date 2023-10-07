using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace Matab
{
    public partial class FormLogin : Form
    {
        CrudLogin crudLogin = new CrudLogin(AppConfig.ConnectionString);
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = (Local);initial catalog = Matab; integrated security = true");
        SqlCommand cmd = new SqlCommand();
        DataSet ds = new DataSet();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine("Current Path: " + currentPath);
            Variable.userLogin = textUserName.Text;
            Variable.passwordLogin = textPassword.Text;
            Variable.accessLogin = cmbAccess.Text;
            crudLogin.Read();
            if (Variable.L == 1)
            {
                if (Variable.accessLogin == "Admin") { Variable.stru = "مدیر"; }
                else { Variable.stru = "کاربر عادی"; }
                FormMain form1 = new FormMain();
                form1.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده با کاربران موجود مطابقت ندارد");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
