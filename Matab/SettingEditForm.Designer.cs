namespace Matab
{
    partial class SettingEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.Address = new System.Windows.Forms.Label();
            this.textAddressExport = new System.Windows.Forms.TextBox();
            this.textPhoneExport = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.textTelephoneExport = new System.Windows.Forms.TextBox();
            this.textDoctorNameExport = new System.Windows.Forms.TextBox();
            this.DoctorNameSetting = new System.Windows.Forms.Label();
            this.textMatabNameExport = new System.Windows.Forms.TextBox();
            this.MatabNameSetting = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.Address);
            this.groupPanel1.Controls.Add(this.textAddressExport);
            this.groupPanel1.Controls.Add(this.textPhoneExport);
            this.groupPanel1.Controls.Add(this.Phone);
            this.groupPanel1.Controls.Add(this.Telephone);
            this.groupPanel1.Controls.Add(this.textTelephoneExport);
            this.groupPanel1.Controls.Add(this.textDoctorNameExport);
            this.groupPanel1.Controls.Add(this.DoctorNameSetting);
            this.groupPanel1.Controls.Add(this.textMatabNameExport);
            this.groupPanel1.Controls.Add(this.MatabNameSetting);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(491, 430);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(9, 359);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(467, 51);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "ویرایش";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(380, 216);
            this.Address.Name = "Address";
            this.Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Address.Size = new System.Drawing.Size(60, 24);
            this.Address.TabIndex = 22;
            this.Address.Text = " ادرس :";
            this.Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textAddressExport
            // 
            this.textAddressExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddressExport.Location = new System.Drawing.Point(21, 215);
            this.textAddressExport.Multiline = true;
            this.textAddressExport.Name = "textAddressExport";
            this.textAddressExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textAddressExport.Size = new System.Drawing.Size(346, 121);
            this.textAddressExport.TabIndex = 4;
            // 
            // textPhoneExport
            // 
            this.textPhoneExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneExport.Location = new System.Drawing.Point(123, 162);
            this.textPhoneExport.Name = "textPhoneExport";
            this.textPhoneExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textPhoneExport.Size = new System.Drawing.Size(244, 32);
            this.textPhoneExport.TabIndex = 3;
            this.textPhoneExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(379, 165);
            this.Phone.Name = "Phone";
            this.Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phone.Size = new System.Drawing.Size(61, 24);
            this.Phone.TabIndex = 21;
            this.Phone.Text = " همراه :";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.BackColor = System.Drawing.Color.Transparent;
            this.Telephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(380, 115);
            this.Telephone.Name = "Telephone";
            this.Telephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Telephone.Size = new System.Drawing.Size(49, 24);
            this.Telephone.TabIndex = 19;
            this.Telephone.Text = "تلفن :";
            this.Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textTelephoneExport
            // 
            this.textTelephoneExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelephoneExport.Location = new System.Drawing.Point(123, 114);
            this.textTelephoneExport.Name = "textTelephoneExport";
            this.textTelephoneExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textTelephoneExport.Size = new System.Drawing.Size(244, 32);
            this.textTelephoneExport.TabIndex = 2;
            this.textTelephoneExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDoctorNameExport
            // 
            this.textDoctorNameExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDoctorNameExport.Location = new System.Drawing.Point(123, 69);
            this.textDoctorNameExport.Name = "textDoctorNameExport";
            this.textDoctorNameExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textDoctorNameExport.Size = new System.Drawing.Size(244, 32);
            this.textDoctorNameExport.TabIndex = 1;
            this.textDoctorNameExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DoctorNameSetting
            // 
            this.DoctorNameSetting.AutoSize = true;
            this.DoctorNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.DoctorNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameSetting.Location = new System.Drawing.Point(380, 70);
            this.DoctorNameSetting.Name = "DoctorNameSetting";
            this.DoctorNameSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoctorNameSetting.Size = new System.Drawing.Size(86, 24);
            this.DoctorNameSetting.TabIndex = 17;
            this.DoctorNameSetting.Text = "نام پزشک :";
            this.DoctorNameSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textMatabNameExport
            // 
            this.textMatabNameExport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMatabNameExport.Location = new System.Drawing.Point(123, 22);
            this.textMatabNameExport.Name = "textMatabNameExport";
            this.textMatabNameExport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textMatabNameExport.Size = new System.Drawing.Size(244, 32);
            this.textMatabNameExport.TabIndex = 0;
            this.textMatabNameExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatabNameSetting
            // 
            this.MatabNameSetting.AutoSize = true;
            this.MatabNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.MatabNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatabNameSetting.Location = new System.Drawing.Point(380, 23);
            this.MatabNameSetting.Name = "MatabNameSetting";
            this.MatabNameSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MatabNameSetting.Size = new System.Drawing.Size(81, 24);
            this.MatabNameSetting.TabIndex = 14;
            this.MatabNameSetting.Text = "نام مطب :";
            this.MatabNameSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 430);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingEditForm";
            this.Load += new System.EventHandler(this.SettingEditForm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label Address;
        public System.Windows.Forms.TextBox textAddressExport;
        public System.Windows.Forms.TextBox textPhoneExport;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Telephone;
        public System.Windows.Forms.TextBox textTelephoneExport;
        public System.Windows.Forms.TextBox textDoctorNameExport;
        private System.Windows.Forms.Label DoctorNameSetting;
        public System.Windows.Forms.TextBox textMatabNameExport;
        private System.Windows.Forms.Label MatabNameSetting;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}