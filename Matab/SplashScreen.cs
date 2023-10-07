﻿using System;
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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            // Stop the timer
            timer1.Stop();

            // Hide the splash screen form
            this.Hide();

            // Open the login form
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        
    }
}
