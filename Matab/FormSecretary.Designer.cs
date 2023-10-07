namespace Matab
{
    partial class FormSecretary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecretary));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.GridViewSec = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.buttonUpdate = new DevComponents.DotNetBar.ButtonX();
            this.buttonDelete = new DevComponents.DotNetBar.ButtonX();
            this.buttonCreate = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.maskedSecSalaryDate = new System.Windows.Forms.MaskedTextBox();
            this.textSecSalary = new System.Windows.Forms.TextBox();
            this.integerSecId = new DevComponents.Editors.IntegerInput();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.textSecExplanation = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.Label();
            this.textSecPhone = new System.Windows.Forms.TextBox();
            this.DoctorNameSetting = new System.Windows.Forms.Label();
            this.textSecName = new System.Windows.Forms.TextBox();
            this.MatabNameSetting = new System.Windows.Forms.Label();
            this.IdSetting = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSec)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerSecId)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.groupPanel3);
            this.groupPanel1.Controls.Add(this.groupPanel4);
            this.groupPanel1.Controls.Add(this.groupPanel2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(979, 730);
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
            this.groupPanel1.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.GridViewSec);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.Location = new System.Drawing.Point(6, 234);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(961, 404);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 7;
            // 
            // GridViewSec
            // 
            this.GridViewSec.AllowUserToAddRows = false;
            this.GridViewSec.AllowUserToDeleteRows = false;
            this.GridViewSec.AllowUserToResizeColumns = false;
            this.GridViewSec.AllowUserToResizeRows = false;
            this.GridViewSec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewSec.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "خالی";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewSec.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewSec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.GridViewSec.Location = new System.Drawing.Point(0, 0);
            this.GridViewSec.MultiSelect = false;
            this.GridViewSec.Name = "GridViewSec";
            this.GridViewSec.ReadOnly = true;
            this.GridViewSec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewSec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewSec.RowHeadersWidth = 51;
            this.GridViewSec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridViewSec.RowTemplate.Height = 24;
            this.GridViewSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewSec.Size = new System.Drawing.Size(955, 398);
            this.GridViewSec.TabIndex = 0;
            this.GridViewSec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSec_CellClick);
            this.GridViewSec.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewSec_RowLeave);
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.buttonUpdate);
            this.groupPanel4.Controls.Add(this.buttonDelete);
            this.groupPanel4.Controls.Add(this.buttonCreate);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Location = new System.Drawing.Point(6, 644);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(961, 77);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 8;
            this.groupPanel4.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonUpdate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.Image")));
            this.buttonUpdate.Location = new System.Drawing.Point(403, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonUpdate.Size = new System.Drawing.Size(159, 62);
            this.buttonUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "ویرایش";
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(138, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonDelete.Size = new System.Drawing.Size(159, 62);
            this.buttonDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonCreate.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreate.Image")));
            this.buttonCreate.Location = new System.Drawing.Point(668, 4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(20);
            this.buttonCreate.Size = new System.Drawing.Size(159, 62);
            this.buttonCreate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "ذخیره";
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.maskedSecSalaryDate);
            this.groupPanel2.Controls.Add(this.textSecSalary);
            this.groupPanel2.Controls.Add(this.integerSecId);
            this.groupPanel2.Controls.Add(this.Address);
            this.groupPanel2.Controls.Add(this.Phone);
            this.groupPanel2.Controls.Add(this.textSecExplanation);
            this.groupPanel2.Controls.Add(this.Telephone);
            this.groupPanel2.Controls.Add(this.textSecPhone);
            this.groupPanel2.Controls.Add(this.DoctorNameSetting);
            this.groupPanel2.Controls.Add(this.textSecName);
            this.groupPanel2.Controls.Add(this.MatabNameSetting);
            this.groupPanel2.Controls.Add(this.IdSetting);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(6, 2);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(961, 229);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 6;
            this.groupPanel2.Text = "اطلاعات منشی";
            this.groupPanel2.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // maskedSecSalaryDate
            // 
            this.maskedSecSalaryDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedSecSalaryDate.Location = new System.Drawing.Point(533, 161);
            this.maskedSecSalaryDate.Mask = " ####/##/##";
            this.maskedSecSalaryDate.Name = "maskedSecSalaryDate";
            this.maskedSecSalaryDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.maskedSecSalaryDate.Size = new System.Drawing.Size(270, 32);
            this.maskedSecSalaryDate.TabIndex = 3;
            this.maskedSecSalaryDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedSecSalaryDate.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // textSecSalary
            // 
            this.textSecSalary.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecSalary.Location = new System.Drawing.Point(533, 109);
            this.textSecSalary.Name = "textSecSalary";
            this.textSecSalary.Size = new System.Drawing.Size(270, 32);
            this.textSecSalary.TabIndex = 2;
            this.textSecSalary.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // integerSecId
            // 
            // 
            // 
            // 
            this.integerSecId.BackgroundStyle.Class = "DateTimeInputBackground";
            this.integerSecId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.integerSecId.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.integerSecId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integerSecId.Location = new System.Drawing.Point(533, 5);
            this.integerSecId.Name = "integerSecId";
            this.integerSecId.Size = new System.Drawing.Size(270, 32);
            this.integerSecId.TabIndex = 0;
            this.integerSecId.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(426, 57);
            this.Address.Name = "Address";
            this.Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Address.Size = new System.Drawing.Size(88, 24);
            this.Address.TabIndex = 10;
            this.Address.Text = "توضیحات :";
            this.Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Address.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.BackColor = System.Drawing.Color.Transparent;
            this.Phone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(823, 112);
            this.Phone.Name = "Phone";
            this.Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phone.Size = new System.Drawing.Size(94, 24);
            this.Phone.TabIndex = 9;
            this.Phone.Text = "مبلغ حقوق :";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Phone.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // textSecExplanation
            // 
            this.textSecExplanation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecExplanation.Location = new System.Drawing.Point(25, 54);
            this.textSecExplanation.Multiline = true;
            this.textSecExplanation.Name = "textSecExplanation";
            this.textSecExplanation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textSecExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSecExplanation.Size = new System.Drawing.Size(381, 131);
            this.textSecExplanation.TabIndex = 5;
            this.textSecExplanation.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.BackColor = System.Drawing.Color.Transparent;
            this.Telephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telephone.Location = new System.Drawing.Point(426, 13);
            this.Telephone.Name = "Telephone";
            this.Telephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Telephone.Size = new System.Drawing.Size(56, 24);
            this.Telephone.TabIndex = 7;
            this.Telephone.Text = "همراه :";
            this.Telephone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Telephone.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // textSecPhone
            // 
            this.textSecPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecPhone.Location = new System.Drawing.Point(136, 10);
            this.textSecPhone.Name = "textSecPhone";
            this.textSecPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textSecPhone.Size = new System.Drawing.Size(270, 32);
            this.textSecPhone.TabIndex = 4;
            this.textSecPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSecPhone.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // DoctorNameSetting
            // 
            this.DoctorNameSetting.AutoSize = true;
            this.DoctorNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.DoctorNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorNameSetting.Location = new System.Drawing.Point(823, 165);
            this.DoctorNameSetting.Name = "DoctorNameSetting";
            this.DoctorNameSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DoctorNameSetting.Size = new System.Drawing.Size(113, 24);
            this.DoctorNameSetting.TabIndex = 5;
            this.DoctorNameSetting.Text = "تاریخ پرداخت :";
            this.DoctorNameSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DoctorNameSetting.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // textSecName
            // 
            this.textSecName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSecName.Location = new System.Drawing.Point(533, 54);
            this.textSecName.Name = "textSecName";
            this.textSecName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textSecName.Size = new System.Drawing.Size(270, 32);
            this.textSecName.TabIndex = 1;
            this.textSecName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textSecName.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // MatabNameSetting
            // 
            this.MatabNameSetting.AutoSize = true;
            this.MatabNameSetting.BackColor = System.Drawing.Color.Transparent;
            this.MatabNameSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatabNameSetting.Location = new System.Drawing.Point(823, 59);
            this.MatabNameSetting.Name = "MatabNameSetting";
            this.MatabNameSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MatabNameSetting.Size = new System.Drawing.Size(113, 24);
            this.MatabNameSetting.TabIndex = 1;
            this.MatabNameSetting.Text = "نام و خانوادگی :";
            this.MatabNameSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MatabNameSetting.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // IdSetting
            // 
            this.IdSetting.AutoSize = true;
            this.IdSetting.BackColor = System.Drawing.Color.Transparent;
            this.IdSetting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSetting.Location = new System.Drawing.Point(823, 11);
            this.IdSetting.Name = "IdSetting";
            this.IdSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IdSetting.Size = new System.Drawing.Size(39, 24);
            this.IdSetting.TabIndex = 0;
            this.IdSetting.Text = "کد :";
            this.IdSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdSetting.Click += new System.EventHandler(this.maskedSecSalaryDate_Click);
            // 
            // FormSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 730);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSecretary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منشی";
            this.Load += new System.EventHandler(this.FormSecretary_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewSec)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.integerSecId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX GridViewSec;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.ButtonX buttonUpdate;
        private DevComponents.DotNetBar.ButtonX buttonDelete;
        private DevComponents.DotNetBar.ButtonX buttonCreate;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.Label Address;
        public System.Windows.Forms.TextBox textSecExplanation;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Telephone;
        public System.Windows.Forms.TextBox textSecPhone;
        private System.Windows.Forms.Label DoctorNameSetting;
        public System.Windows.Forms.TextBox textSecName;
        private System.Windows.Forms.Label MatabNameSetting;
        private System.Windows.Forms.Label IdSetting;
        private DevComponents.Editors.IntegerInput integerSecId;
        private System.Windows.Forms.TextBox textSecSalary;
        private System.Windows.Forms.MaskedTextBox maskedSecSalaryDate;
    }
}