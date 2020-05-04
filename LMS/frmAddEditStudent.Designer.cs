﻿namespace LMS
{
    partial class frmAddEditStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditStudent));
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblValues = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.lblID = new System.Windows.Forms.Label();
            this.gunaLinePanel3 = new Guna.UI.WinForms.GunaLinePanel();
            this.cboYear = new Syncfusion.WinForms.ListView.SfComboBox();
            this.cboCourse = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFname = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLname = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLinePanel2 = new Guna.UI.WinForms.GunaLinePanel();
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.studImage = new Guna.UI.WinForms.GunaPictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMale = new Guna.UI.WinForms.GunaRadioButton();
            this.rbFemale = new Guna.UI.WinForms.GunaRadioButton();
            this.btnChoose = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudNo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLinePanel4 = new Guna.UI.WinForms.GunaLinePanel();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.popupNotifier = new Tulpep.NotificationWindow.PopupNotifier();
            this.gunaLinePanel1.SuspendLayout();
            this.gunaLinePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCourse)).BeginInit();
            this.gunaLinePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gunaLinePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.lblValues);
            this.gunaLinePanel1.Controls.Add(this.btnUpdate);
            this.gunaLinePanel1.Controls.Add(this.btnSave);
            this.gunaLinePanel1.Controls.Add(this.lblID);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel3);
            this.gunaLinePanel1.Controls.Add(this.panel1);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel2);
            this.gunaLinePanel1.Controls.Add(this.gunaLinePanel4);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.SystemColors.HotTrack;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(559, 559);
            this.gunaLinePanel1.TabIndex = 1;
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValues.Location = new System.Drawing.Point(64, 533);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(16, 17);
            this.lblValues.TabIndex = 3;
            this.lblValues.Text = "0";
            this.lblValues.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(350, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 7;
            this.btnUpdate.Size = new System.Drawing.Size(97, 29);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(450, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 7;
            this.btnSave.Size = new System.Drawing.Size(97, 29);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(26, 528);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 33;
            this.lblID.Visible = false;
            // 
            // gunaLinePanel3
            // 
            this.gunaLinePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel3.Controls.Add(this.cboYear);
            this.gunaLinePanel3.Controls.Add(this.cboCourse);
            this.gunaLinePanel3.Controls.Add(this.label4);
            this.gunaLinePanel3.Controls.Add(this.label3);
            this.gunaLinePanel3.Controls.Add(this.txtFname);
            this.gunaLinePanel3.Controls.Add(this.label11);
            this.gunaLinePanel3.Controls.Add(this.txtAddress);
            this.gunaLinePanel3.Controls.Add(this.label8);
            this.gunaLinePanel3.Controls.Add(this.txtEmail);
            this.gunaLinePanel3.Controls.Add(this.label9);
            this.gunaLinePanel3.Controls.Add(this.txtContact);
            this.gunaLinePanel3.Controls.Add(this.label7);
            this.gunaLinePanel3.Controls.Add(this.label5);
            this.gunaLinePanel3.Controls.Add(this.txtLname);
            this.gunaLinePanel3.LineBottom = 2;
            this.gunaLinePanel3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel3.Location = new System.Drawing.Point(12, 251);
            this.gunaLinePanel3.Name = "gunaLinePanel3";
            this.gunaLinePanel3.Size = new System.Drawing.Size(535, 242);
            this.gunaLinePanel3.TabIndex = 30;
            // 
            // cboYear
            // 
            this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboYear.BackColor = System.Drawing.Color.Gainsboro;
            this.cboYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboYear.Location = new System.Drawing.Point(282, 87);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(234, 26);
            this.cboYear.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboYear.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Gainsboro;
            this.cboYear.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.cboYear.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboYear.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboYear.Style.EditorStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboYear.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboYear.TabIndex = 5;
            // 
            // cboCourse
            // 
            this.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCourse.BackColor = System.Drawing.Color.Gainsboro;
            this.cboCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cboCourse.Location = new System.Drawing.Point(20, 87);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(234, 26);
            this.cboCourse.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboCourse.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.Gainsboro;
            this.cboCourse.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.Gainsboro;
            this.cboCourse.Style.EditorStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.cboCourse.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboCourse.Style.EditorStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.cboCourse.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboCourse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label4.Location = new System.Drawing.Point(280, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "First Name *";
            // 
            // txtFname
            // 
            this.txtFname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFname.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtFname.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtFname.BorderSize = 1;
            this.txtFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFname.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtFname.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtFname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFname.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtFname.Location = new System.Drawing.Point(20, 36);
            this.txtFname.Name = "txtFname";
            this.txtFname.PasswordChar = '\0';
            this.txtFname.SelectedText = "";
            this.txtFname.Size = new System.Drawing.Size(234, 25);
            this.txtFname.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label11.Location = new System.Drawing.Point(20, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAddress.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.BorderSize = 1;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtAddress.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtAddress.Location = new System.Drawing.Point(20, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(496, 25);
            this.txtAddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label8.Location = new System.Drawing.Point(282, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtEmail.Location = new System.Drawing.Point(282, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(234, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label9.Location = new System.Drawing.Point(19, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Phone Number";
            // 
            // txtContact
            // 
            this.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtContact.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtContact.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtContact.BorderSize = 1;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtContact.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtContact.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtContact.Location = new System.Drawing.Point(19, 138);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(234, 25);
            this.txtContact.TabIndex = 6;
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label7.Location = new System.Drawing.Point(19, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Course";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label5.Location = new System.Drawing.Point(282, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Last Name *";
            // 
            // txtLname
            // 
            this.txtLname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLname.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtLname.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtLname.BorderSize = 1;
            this.txtLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLname.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtLname.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtLname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLname.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtLname.Location = new System.Drawing.Point(282, 36);
            this.txtLname.Name = "txtLname";
            this.txtLname.PasswordChar = '\0';
            this.txtLname.SelectedText = "";
            this.txtLname.Size = new System.Drawing.Size(234, 25);
            this.txtLname.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 7);
            this.panel1.TabIndex = 26;
            // 
            // gunaLinePanel2
            // 
            this.gunaLinePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel2.Controls.Add(this.lblLibrarian);
            this.gunaLinePanel2.Controls.Add(this.studImage);
            this.gunaLinePanel2.Controls.Add(this.groupBox1);
            this.gunaLinePanel2.Controls.Add(this.btnChoose);
            this.gunaLinePanel2.Controls.Add(this.label2);
            this.gunaLinePanel2.Controls.Add(this.txtStudNo);
            this.gunaLinePanel2.LineBottom = 2;
            this.gunaLinePanel2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel2.Location = new System.Drawing.Point(12, 68);
            this.gunaLinePanel2.Name = "gunaLinePanel2";
            this.gunaLinePanel2.Size = new System.Drawing.Size(535, 177);
            this.gunaLinePanel2.TabIndex = 28;
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrarian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblLibrarian.Location = new System.Drawing.Point(335, 33);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(0, 13);
            this.lblLibrarian.TabIndex = 11;
            this.lblLibrarian.Visible = false;
            // 
            // studImage
            // 
            this.studImage.BackColor = System.Drawing.Color.White;
            this.studImage.BaseColor = System.Drawing.Color.Gainsboro;
            this.studImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studImage.Image = ((System.Drawing.Image)(resources.GetObject("studImage.Image")));
            this.studImage.Location = new System.Drawing.Point(33, 10);
            this.studImage.Name = "studImage";
            this.studImage.Size = new System.Drawing.Size(120, 120);
            this.studImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studImage.TabIndex = 10;
            this.studImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Location = new System.Drawing.Point(196, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Gender ";
            // 
            // rbMale
            // 
            this.rbMale.BaseColor = System.Drawing.SystemColors.Control;
            this.rbMale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbMale.CheckedOnColor = System.Drawing.SystemColors.HotTrack;
            this.rbMale.FillColor = System.Drawing.Color.White;
            this.rbMale.Location = new System.Drawing.Point(17, 23);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(54, 20);
            this.rbMale.TabIndex = 7;
            this.rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            this.rbFemale.BaseColor = System.Drawing.SystemColors.Control;
            this.rbFemale.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbFemale.CheckedOnColor = System.Drawing.SystemColors.HotTrack;
            this.rbFemale.FillColor = System.Drawing.Color.White;
            this.rbFemale.Location = new System.Drawing.Point(93, 23);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(68, 20);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Text = "Female";
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChoose.AnimationHoverSpeed = 0.07F;
            this.btnChoose.AnimationSpeed = 0.03F;
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BaseColor = System.Drawing.Color.Gainsboro;
            this.btnChoose.BorderColor = System.Drawing.Color.Black;
            this.btnChoose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChoose.FocusedColor = System.Drawing.Color.Empty;
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.btnChoose.Image = null;
            this.btnChoose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoose.Location = new System.Drawing.Point(31, 137);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(85)))));
            this.btnChoose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoose.OnHoverImage = null;
            this.btnChoose.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoose.Radius = 14;
            this.btnChoose.Size = new System.Drawing.Size(125, 29);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Choose Photo";
            this.btnChoose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(196, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Number *";
            // 
            // txtStudNo
            // 
            this.txtStudNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStudNo.BaseColor = System.Drawing.Color.Gainsboro;
            this.txtStudNo.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtStudNo.BorderSize = 1;
            this.txtStudNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStudNo.FocusedBaseColor = System.Drawing.Color.Gainsboro;
            this.txtStudNo.FocusedBorderColor = System.Drawing.SystemColors.HotTrack;
            this.txtStudNo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStudNo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtStudNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.txtStudNo.Location = new System.Drawing.Point(196, 49);
            this.txtStudNo.Name = "txtStudNo";
            this.txtStudNo.PasswordChar = '\0';
            this.txtStudNo.SelectedText = "";
            this.txtStudNo.Size = new System.Drawing.Size(301, 26);
            this.txtStudNo.TabIndex = 1;
            // 
            // gunaLinePanel4
            // 
            this.gunaLinePanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel4.Controls.Add(this.btnBack);
            this.gunaLinePanel4.Controls.Add(this.lblTitle);
            this.gunaLinePanel4.LineBottom = 2;
            this.gunaLinePanel4.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaLinePanel4.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel4.Location = new System.Drawing.Point(12, 16);
            this.gunaLinePanel4.Name = "gunaLinePanel4";
            this.gunaLinePanel4.Size = new System.Drawing.Size(535, 46);
            this.gunaLinePanel4.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = global::LMS.Properties.Resources.left_30px;
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(17, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 2;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(58)))));
            this.lblTitle.Location = new System.Drawing.Point(48, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(202, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Student Details";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // popupNotifier
            // 
            this.popupNotifier.BodyColor = System.Drawing.Color.White;
            this.popupNotifier.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.popupNotifier.ButtonBorderColor = System.Drawing.SystemColors.HotTrack;
            this.popupNotifier.ButtonHoverColor = System.Drawing.SystemColors.HotTrack;
            this.popupNotifier.ContentFont = new System.Drawing.Font("Tahoma", 10F);
            this.popupNotifier.ContentPadding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.popupNotifier.ContentText = null;
            this.popupNotifier.GradientPower = 0;
            this.popupNotifier.HeaderColor = System.Drawing.SystemColors.HotTrack;
            this.popupNotifier.HeaderHeight = 10;
            this.popupNotifier.Image = global::LMS.Properties.Resources.jungkook;
            this.popupNotifier.ImagePadding = new System.Windows.Forms.Padding(10, 12, 0, 0);
            this.popupNotifier.ImageSize = new System.Drawing.Size(70, 70);
            this.popupNotifier.IsRightToLeft = false;
            this.popupNotifier.OptionsMenu = null;
            this.popupNotifier.ShowGrip = false;
            this.popupNotifier.Size = new System.Drawing.Size(400, 100);
            this.popupNotifier.TitleColor = System.Drawing.Color.Transparent;
            this.popupNotifier.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            this.popupNotifier.TitleText = null;
            // 
            // frmAddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 559);
            this.Controls.Add(this.gunaLinePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddEditStudent";
            this.Load += new System.EventHandler(this.FrmAddEditStudent_Load);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.gunaLinePanel3.ResumeLayout(false);
            this.gunaLinePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCourse)).EndInit();
            this.gunaLinePanel2.ResumeLayout(false);
            this.gunaLinePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gunaLinePanel4.ResumeLayout(false);
            this.gunaLinePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        public System.Windows.Forms.Label lblID;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel3;
        public System.Windows.Forms.Label label11;
        public Guna.UI.WinForms.GunaTextBox txtAddress;
        public System.Windows.Forms.Label label8;
        public Guna.UI.WinForms.GunaTextBox txtEmail;
        public System.Windows.Forms.Label label9;
        public Guna.UI.WinForms.GunaTextBox txtContact;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaTextBox txtLname;
        public System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel2;
        public Guna.UI.WinForms.GunaButton btnChoose;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox txtStudNo;
        public Guna.UI.WinForms.GunaLinePanel gunaLinePanel4;
        public Bunifu.Framework.UI.BunifuImageButton btnBack;
        public System.Windows.Forms.Label lblTitle;
        public Guna.UI.WinForms.GunaButton btnUpdate;
        public Guna.UI.WinForms.GunaButton btnSave;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox txtFname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public Guna.UI.WinForms.GunaPictureBox studImage;
        public Guna.UI.WinForms.GunaRadioButton rbFemale;
        public Guna.UI.WinForms.GunaRadioButton rbMale;
        private System.Windows.Forms.Label lblValues;
        private Tulpep.NotificationWindow.PopupNotifier popupNotifier;
        public System.Windows.Forms.Label lblLibrarian;
        public Syncfusion.WinForms.ListView.SfComboBox cboYear;
        public Syncfusion.WinForms.ListView.SfComboBox cboCourse;
    }
}