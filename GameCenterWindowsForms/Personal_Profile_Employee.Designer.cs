namespace GameCenterWindowsForms
{
    partial class Personal_Profile_Employee
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
            this.gbEmployee_Info = new System.Windows.Forms.GroupBox();
            this.tblltpnEmployee = new System.Windows.Forms.TableLayoutPanel();
            this.BtCancel = new System.Windows.Forms.Button();
            this.lblLohgin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfermPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfermPassword = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.dtpWorked_Hours = new System.Windows.Forms.DateTimePicker();
            this.lblWorked_Hours = new System.Windows.Forms.Label();
            this.lblEmployee_Enterence = new System.Windows.Forms.Label();
            this.lblEmployee_Middle_Name = new System.Windows.Forms.Label();
            this.lblEmpoyee_Name = new System.Windows.Forms.Label();
            this.lblEmployee_First_Name = new System.Windows.Forms.Label();
            this.gbEmployee_Info.SuspendLayout();
            this.tblltpnEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployee_Info
            // 
            this.gbEmployee_Info.Controls.Add(this.tblltpnEmployee);
            this.gbEmployee_Info.Controls.Add(this.dtpWorked_Hours);
            this.gbEmployee_Info.Controls.Add(this.lblWorked_Hours);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_Enterence);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_Middle_Name);
            this.gbEmployee_Info.Controls.Add(this.lblEmpoyee_Name);
            this.gbEmployee_Info.Controls.Add(this.lblEmployee_First_Name);
            this.gbEmployee_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEmployee_Info.Location = new System.Drawing.Point(0, 0);
            this.gbEmployee_Info.Name = "gbEmployee_Info";
            this.gbEmployee_Info.Size = new System.Drawing.Size(800, 450);
            this.gbEmployee_Info.TabIndex = 2;
            this.gbEmployee_Info.TabStop = false;
            this.gbEmployee_Info.Text = "Персональные данные";
            // 
            // tblltpnEmployee
            // 
            this.tblltpnEmployee.ColumnCount = 2;
            this.tblltpnEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnEmployee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnEmployee.Controls.Add(this.BtCancel, 0, 3);
            this.tblltpnEmployee.Controls.Add(this.lblLohgin, 0, 0);
            this.tblltpnEmployee.Controls.Add(this.lblPassword, 0, 1);
            this.tblltpnEmployee.Controls.Add(this.lblConfermPassword, 0, 2);
            this.tblltpnEmployee.Controls.Add(this.tbLogin, 1, 0);
            this.tblltpnEmployee.Controls.Add(this.tbPassword, 1, 1);
            this.tblltpnEmployee.Controls.Add(this.tbConfermPassword, 1, 2);
            this.tblltpnEmployee.Controls.Add(this.btSave, 0, 3);
            this.tblltpnEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblltpnEmployee.Location = new System.Drawing.Point(3, 125);
            this.tblltpnEmployee.Name = "tblltpnEmployee";
            this.tblltpnEmployee.RowCount = 4;
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblltpnEmployee.Size = new System.Drawing.Size(794, 322);
            this.tblltpnEmployee.TabIndex = 6;
            // 
            // BtCancel
            // 
            this.BtCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtCancel.Location = new System.Drawing.Point(400, 243);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(391, 76);
            this.BtCancel.TabIndex = 7;
            this.BtCancel.Text = "Закрыть";
            this.BtCancel.UseVisualStyleBackColor = true;
            // 
            // lblLohgin
            // 
            this.lblLohgin.AutoSize = true;
            this.lblLohgin.Location = new System.Drawing.Point(3, 0);
            this.lblLohgin.Name = "lblLohgin";
            this.lblLohgin.Size = new System.Drawing.Size(51, 17);
            this.lblLohgin.TabIndex = 0;
            this.lblLohgin.Text = "Логин:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 80);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль:";
            // 
            // lblConfermPassword
            // 
            this.lblConfermPassword.AutoSize = true;
            this.lblConfermPassword.Location = new System.Drawing.Point(3, 160);
            this.lblConfermPassword.Name = "lblConfermPassword";
            this.lblConfermPassword.Size = new System.Drawing.Size(149, 17);
            this.lblConfermPassword.TabIndex = 2;
            this.lblConfermPassword.Text = "Подтвердить пароль:";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(400, 3);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(391, 22);
            this.tbLogin.TabIndex = 3;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(400, 83);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(391, 22);
            this.tbPassword.TabIndex = 4;
            // 
            // tbConfermPassword
            // 
            this.tbConfermPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfermPassword.Location = new System.Drawing.Point(400, 163);
            this.tbConfermPassword.Name = "tbConfermPassword";
            this.tbConfermPassword.PasswordChar = '*';
            this.tbConfermPassword.Size = new System.Drawing.Size(391, 22);
            this.tbConfermPassword.TabIndex = 5;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(3, 243);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(391, 76);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // dtpWorked_Hours
            // 
            this.dtpWorked_Hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpWorked_Hours.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorked_Hours.Location = new System.Drawing.Point(3, 103);
            this.dtpWorked_Hours.Name = "dtpWorked_Hours";
            this.dtpWorked_Hours.Size = new System.Drawing.Size(794, 22);
            this.dtpWorked_Hours.TabIndex = 5;
            // 
            // lblWorked_Hours
            // 
            this.lblWorked_Hours.AutoSize = true;
            this.lblWorked_Hours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorked_Hours.Location = new System.Drawing.Point(3, 86);
            this.lblWorked_Hours.Name = "lblWorked_Hours";
            this.lblWorked_Hours.Size = new System.Drawing.Size(258, 17);
            this.lblWorked_Hours.TabIndex = 4;
            this.lblWorked_Hours.Text = "Количество отработанных часов: 0 ч.";
            // 
            // lblEmployee_Enterence
            // 
            this.lblEmployee_Enterence.AutoSize = true;
            this.lblEmployee_Enterence.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_Enterence.Location = new System.Drawing.Point(3, 69);
            this.lblEmployee_Enterence.Name = "lblEmployee_Enterence";
            this.lblEmployee_Enterence.Size = new System.Drawing.Size(117, 17);
            this.lblEmployee_Enterence.TabIndex = 3;
            this.lblEmployee_Enterence.Text = "Дата принятия: ";
            // 
            // lblEmployee_Middle_Name
            // 
            this.lblEmployee_Middle_Name.AutoSize = true;
            this.lblEmployee_Middle_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_Middle_Name.Location = new System.Drawing.Point(3, 52);
            this.lblEmployee_Middle_Name.Name = "lblEmployee_Middle_Name";
            this.lblEmployee_Middle_Name.Size = new System.Drawing.Size(79, 17);
            this.lblEmployee_Middle_Name.TabIndex = 2;
            this.lblEmployee_Middle_Name.Text = "Отчество: ";
            // 
            // lblEmpoyee_Name
            // 
            this.lblEmpoyee_Name.AutoSize = true;
            this.lblEmpoyee_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmpoyee_Name.Location = new System.Drawing.Point(3, 35);
            this.lblEmpoyee_Name.Name = "lblEmpoyee_Name";
            this.lblEmpoyee_Name.Size = new System.Drawing.Size(43, 17);
            this.lblEmpoyee_Name.TabIndex = 1;
            this.lblEmpoyee_Name.Text = "Имя: ";
            // 
            // lblEmployee_First_Name
            // 
            this.lblEmployee_First_Name.AutoSize = true;
            this.lblEmployee_First_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmployee_First_Name.Location = new System.Drawing.Point(3, 18);
            this.lblEmployee_First_Name.Name = "lblEmployee_First_Name";
            this.lblEmployee_First_Name.Size = new System.Drawing.Size(78, 17);
            this.lblEmployee_First_Name.TabIndex = 0;
            this.lblEmployee_First_Name.Text = "Фамилия: ";
            // 
            // Personal_Profile_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbEmployee_Info);
            this.Name = "Personal_Profile_Employee";
            this.Text = "Personal_Profile_Employee";
            this.gbEmployee_Info.ResumeLayout(false);
            this.gbEmployee_Info.PerformLayout();
            this.tblltpnEmployee.ResumeLayout(false);
            this.tblltpnEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployee_Info;
        private System.Windows.Forms.TableLayoutPanel tblltpnEmployee;
        private System.Windows.Forms.Label lblLohgin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfermPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfermPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dtpWorked_Hours;
        private System.Windows.Forms.Label lblWorked_Hours;
        private System.Windows.Forms.Label lblEmployee_Enterence;
        private System.Windows.Forms.Label lblEmployee_Middle_Name;
        private System.Windows.Forms.Label lblEmpoyee_Name;
        private System.Windows.Forms.Label lblEmployee_First_Name;
        private System.Windows.Forms.Button BtCancel;
    }
}