namespace GameCenterWindowsForms
{
    partial class Personal_Profile_Klient
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
            this.gbKlient_Personal = new System.Windows.Forms.GroupBox();
            this.tbctrlKlient = new System.Windows.Forms.TabControl();
            this.tbpgKlientChekcHistory = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonИзмегнитьЗаказ = new System.Windows.Forms.Button();
            this.buttonДобавитьЗаказ = new System.Windows.Forms.Button();
            this.buttonУдалитьЗаказ = new System.Windows.Forms.Button();
            this.textBoxНазваниеЧека = new System.Windows.Forms.TextBox();
            this.dateTimePickerДатаЧека = new System.Windows.Forms.DateTimePicker();
            this.labelЧек = new System.Windows.Forms.Label();
            this.dataGridViewЗаказы = new System.Windows.Forms.DataGridView();
            this.tbpgKlientProfile = new System.Windows.Forms.TabPage();
            this.tblltpnKLinet_Information = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFirst_Name = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMiddle_Name = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfermPassword = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKlient_IsZaban = new System.Windows.Forms.Label();
            this.lblKlinet_Middlename = new System.Windows.Forms.Label();
            this.lblKlinet_Name = new System.Windows.Forms.Label();
            this.lblKlinet_Surname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.gbKlient_Personal.SuspendLayout();
            this.tbctrlKlient.SuspendLayout();
            this.tbpgKlientChekcHistory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказы)).BeginInit();
            this.tbpgKlientProfile.SuspendLayout();
            this.tblltpnKLinet_Information.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKlient_Personal
            // 
            this.gbKlient_Personal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbKlient_Personal.Controls.Add(this.tbctrlKlient);
            this.gbKlient_Personal.Controls.Add(this.lblKlient_IsZaban);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Middlename);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Name);
            this.gbKlient_Personal.Controls.Add(this.lblKlinet_Surname);
            this.gbKlient_Personal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbKlient_Personal.Location = new System.Drawing.Point(0, 0);
            this.gbKlient_Personal.Name = "gbKlient_Personal";
            this.gbKlient_Personal.Size = new System.Drawing.Size(848, 415);
            this.gbKlient_Personal.TabIndex = 2;
            this.gbKlient_Personal.TabStop = false;
            this.gbKlient_Personal.Text = "Персональные данные";
            // 
            // tbctrlKlient
            // 
            this.tbctrlKlient.Controls.Add(this.tbpgKlientChekcHistory);
            this.tbctrlKlient.Controls.Add(this.tbpgKlientProfile);
            this.tbctrlKlient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlKlient.Location = new System.Drawing.Point(3, 132);
            this.tbctrlKlient.Name = "tbctrlKlient";
            this.tbctrlKlient.SelectedIndex = 0;
            this.tbctrlKlient.Size = new System.Drawing.Size(842, 280);
            this.tbctrlKlient.TabIndex = 5;
            // 
            // tbpgKlientChekcHistory
            // 
            this.tbpgKlientChekcHistory.AutoScroll = true;
            this.tbpgKlientChekcHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbpgKlientChekcHistory.CausesValidation = false;
            this.tbpgKlientChekcHistory.Controls.Add(this.tableLayoutPanel1);
            this.tbpgKlientChekcHistory.Controls.Add(this.dataGridViewЗаказы);
            this.tbpgKlientChekcHistory.Location = new System.Drawing.Point(4, 34);
            this.tbpgKlientChekcHistory.Name = "tbpgKlientChekcHistory";
            this.tbpgKlientChekcHistory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpgKlientChekcHistory.Size = new System.Drawing.Size(834, 242);
            this.tbpgKlientChekcHistory.TabIndex = 2;
            this.tbpgKlientChekcHistory.Text = "Заказы";
            this.tbpgKlientChekcHistory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Controls.Add(this.buttonИзмегнитьЗаказ, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonДобавитьЗаказ, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonУдалитьЗаказ, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxНазваниеЧека, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerДатаЧека, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelЧек, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonИзмегнитьЗаказ
            // 
            this.buttonИзмегнитьЗаказ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonИзмегнитьЗаказ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonИзмегнитьЗаказ.Location = new System.Drawing.Point(2, 66);
            this.buttonИзмегнитьЗаказ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonИзмегнитьЗаказ.Name = "buttonИзмегнитьЗаказ";
            this.buttonИзмегнитьЗаказ.Size = new System.Drawing.Size(311, 29);
            this.buttonИзмегнитьЗаказ.TabIndex = 3;
            this.buttonИзмегнитьЗаказ.Text = "Изменить Заказ";
            this.buttonИзмегнитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonИзмегнитьЗаказ.Click += new System.EventHandler(this.ButtonИзмегнитьЗаказ_Click);
            // 
            // buttonДобавитьЗаказ
            // 
            this.buttonДобавитьЗаказ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonДобавитьЗаказ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьЗаказ.Location = new System.Drawing.Point(2, 2);
            this.buttonДобавитьЗаказ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonДобавитьЗаказ.Name = "buttonДобавитьЗаказ";
            this.buttonДобавитьЗаказ.Size = new System.Drawing.Size(311, 28);
            this.buttonДобавитьЗаказ.TabIndex = 0;
            this.buttonДобавитьЗаказ.Text = "Добавить Заказ";
            this.buttonДобавитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonДобавитьЗаказ.Click += new System.EventHandler(this.ButtonДобавитьЗаказ_Click);
            // 
            // buttonУдалитьЗаказ
            // 
            this.buttonУдалитьЗаказ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonУдалитьЗаказ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьЗаказ.Location = new System.Drawing.Point(2, 34);
            this.buttonУдалитьЗаказ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonУдалитьЗаказ.Name = "buttonУдалитьЗаказ";
            this.buttonУдалитьЗаказ.Size = new System.Drawing.Size(311, 28);
            this.buttonУдалитьЗаказ.TabIndex = 1;
            this.buttonУдалитьЗаказ.Text = "Удалить Заказ";
            this.buttonУдалитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonУдалитьЗаказ.Click += new System.EventHandler(this.ButtonУдалитьЗаказ_Click);
            // 
            // textBoxНазваниеЧека
            // 
            this.textBoxНазваниеЧека.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxНазваниеЧека.Location = new System.Drawing.Point(317, 2);
            this.textBoxНазваниеЧека.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxНазваниеЧека.Name = "textBoxНазваниеЧека";
            this.textBoxНазваниеЧека.Size = new System.Drawing.Size(262, 32);
            this.textBoxНазваниеЧека.TabIndex = 4;
            // 
            // dateTimePickerДатаЧека
            // 
            this.dateTimePickerДатаЧека.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerДатаЧека.Location = new System.Drawing.Point(583, 2);
            this.dateTimePickerДатаЧека.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerДатаЧека.Name = "dateTimePickerДатаЧека";
            this.dateTimePickerДатаЧека.Size = new System.Drawing.Size(243, 32);
            this.dateTimePickerДатаЧека.TabIndex = 5;
            // 
            // labelЧек
            // 
            this.labelЧек.AutoSize = true;
            this.labelЧек.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelЧек.Location = new System.Drawing.Point(317, 32);
            this.labelЧек.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelЧек.Name = "labelЧек";
            this.labelЧек.Size = new System.Drawing.Size(262, 32);
            this.labelЧек.TabIndex = 6;
            // 
            // dataGridViewЗаказы
            // 
            this.dataGridViewЗаказы.AllowUserToAddRows = false;
            this.dataGridViewЗаказы.AllowUserToDeleteRows = false;
            this.dataGridViewЗаказы.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewЗаказы.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗаказы.Location = new System.Drawing.Point(5, 6);
            this.dataGridViewЗаказы.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewЗаказы.MultiSelect = false;
            this.dataGridViewЗаказы.Name = "dataGridViewЗаказы";
            this.dataGridViewЗаказы.ReadOnly = true;
            this.dataGridViewЗаказы.RowHeadersWidth = 51;
            this.dataGridViewЗаказы.RowTemplate.Height = 24;
            this.dataGridViewЗаказы.Size = new System.Drawing.Size(824, 67);
            this.dataGridViewЗаказы.TabIndex = 2;
            this.dataGridViewЗаказы.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewЗаказы_CellClick);
            // 
            // tbpgKlientProfile
            // 
            this.tbpgKlientProfile.Controls.Add(this.tblltpnKLinet_Information);
            this.tbpgKlientProfile.Location = new System.Drawing.Point(4, 34);
            this.tbpgKlientProfile.Name = "tbpgKlientProfile";
            this.tbpgKlientProfile.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpgKlientProfile.Size = new System.Drawing.Size(834, 266);
            this.tbpgKlientProfile.TabIndex = 3;
            this.tbpgKlientProfile.Text = "Личный профиль";
            this.tbpgKlientProfile.UseVisualStyleBackColor = true;
            // 
            // tblltpnKLinet_Information
            // 
            this.tblltpnKLinet_Information.ColumnCount = 2;
            this.tblltpnKLinet_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.Controls.Add(this.label1, 0, 0);
            this.tblltpnKLinet_Information.Controls.Add(this.label2, 0, 1);
            this.tblltpnKLinet_Information.Controls.Add(this.label3, 0, 2);
            this.tblltpnKLinet_Information.Controls.Add(this.label4, 0, 3);
            this.tblltpnKLinet_Information.Controls.Add(this.label5, 0, 4);
            this.tblltpnKLinet_Information.Controls.Add(this.tbFirst_Name, 1, 0);
            this.tblltpnKLinet_Information.Controls.Add(this.tbName, 1, 1);
            this.tblltpnKLinet_Information.Controls.Add(this.tbMiddle_Name, 1, 2);
            this.tblltpnKLinet_Information.Controls.Add(this.tbLogin, 1, 3);
            this.tblltpnKLinet_Information.Controls.Add(this.tbPassword, 1, 4);
            this.tblltpnKLinet_Information.Controls.Add(this.tbConfermPassword, 1, 5);
            this.tblltpnKLinet_Information.Controls.Add(this.btSave, 0, 6);
            this.tblltpnKLinet_Information.Controls.Add(this.label6, 0, 5);
            this.tblltpnKLinet_Information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblltpnKLinet_Information.Location = new System.Drawing.Point(3, 3);
            this.tblltpnKLinet_Information.Name = "tblltpnKLinet_Information";
            this.tblltpnKLinet_Information.RowCount = 7;
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblltpnKLinet_Information.Size = new System.Drawing.Size(828, 260);
            this.tblltpnKLinet_Information.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Пароль:";
            // 
            // tbFirst_Name
            // 
            this.tbFirst_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbFirst_Name.Location = new System.Drawing.Point(417, 3);
            this.tbFirst_Name.Name = "tbFirst_Name";
            this.tbFirst_Name.Size = new System.Drawing.Size(408, 32);
            this.tbFirst_Name.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(417, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(408, 32);
            this.tbName.TabIndex = 7;
            // 
            // tbMiddle_Name
            // 
            this.tbMiddle_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbMiddle_Name.Location = new System.Drawing.Point(417, 77);
            this.tbMiddle_Name.Name = "tbMiddle_Name";
            this.tbMiddle_Name.Size = new System.Drawing.Size(408, 32);
            this.tbMiddle_Name.TabIndex = 8;
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(417, 114);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(408, 32);
            this.tbLogin.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(417, 151);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(408, 32);
            this.tbPassword.TabIndex = 10;
            // 
            // tbConfermPassword
            // 
            this.tbConfermPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbConfermPassword.Location = new System.Drawing.Point(417, 188);
            this.tbConfermPassword.Name = "tbConfermPassword";
            this.tbConfermPassword.PasswordChar = '*';
            this.tbConfermPassword.Size = new System.Drawing.Size(408, 32);
            this.tbConfermPassword.TabIndex = 11;
            // 
            // btSave
            // 
            this.btSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSave.Location = new System.Drawing.Point(3, 225);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(408, 32);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Сохранить данные";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Подтверждение пароля:";
            // 
            // lblKlient_IsZaban
            // 
            this.lblKlient_IsZaban.AutoSize = true;
            this.lblKlient_IsZaban.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlient_IsZaban.Location = new System.Drawing.Point(3, 106);
            this.lblKlient_IsZaban.Name = "lblKlient_IsZaban";
            this.lblKlient_IsZaban.Size = new System.Drawing.Size(171, 26);
            this.lblKlient_IsZaban.TabIndex = 4;
            this.lblKlient_IsZaban.Text = "Заблокирован: ";
            // 
            // lblKlinet_Middlename
            // 
            this.lblKlinet_Middlename.AutoSize = true;
            this.lblKlinet_Middlename.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Middlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Middlename.Location = new System.Drawing.Point(3, 80);
            this.lblKlinet_Middlename.Name = "lblKlinet_Middlename";
            this.lblKlinet_Middlename.Size = new System.Drawing.Size(120, 26);
            this.lblKlinet_Middlename.TabIndex = 2;
            this.lblKlinet_Middlename.Text = "Отчество: ";
            // 
            // lblKlinet_Name
            // 
            this.lblKlinet_Name.AutoSize = true;
            this.lblKlinet_Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Name.Location = new System.Drawing.Point(3, 54);
            this.lblKlinet_Name.Name = "lblKlinet_Name";
            this.lblKlinet_Name.Size = new System.Drawing.Size(68, 26);
            this.lblKlinet_Name.TabIndex = 1;
            this.lblKlinet_Name.Text = "Имя: ";
            // 
            // lblKlinet_Surname
            // 
            this.lblKlinet_Surname.AutoSize = true;
            this.lblKlinet_Surname.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKlinet_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblKlinet_Surname.Location = new System.Drawing.Point(3, 28);
            this.lblKlinet_Surname.Name = "lblKlinet_Surname";
            this.lblKlinet_Surname.Size = new System.Drawing.Size(120, 26);
            this.lblKlinet_Surname.TabIndex = 0;
            this.lblKlinet_Surname.Text = "Фамилия: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 40);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(722, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Personal_Profile_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbKlient_Personal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Personal_Profile_Klient";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.Personal_Profile_Klient_Load);
            this.gbKlient_Personal.ResumeLayout(false);
            this.gbKlient_Personal.PerformLayout();
            this.tbctrlKlient.ResumeLayout(false);
            this.tbpgKlientChekcHistory.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказы)).EndInit();
            this.tbpgKlientProfile.ResumeLayout(false);
            this.tblltpnKLinet_Information.ResumeLayout(false);
            this.tblltpnKLinet_Information.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKlient_Personal;
        private System.Windows.Forms.TabControl tbctrlKlient;
        private System.Windows.Forms.TabPage tbpgKlientChekcHistory;
        private System.Windows.Forms.TabPage tbpgKlientProfile;
        private System.Windows.Forms.TableLayoutPanel tblltpnKLinet_Information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFirst_Name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMiddle_Name;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfermPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKlient_IsZaban;
        private System.Windows.Forms.Label lblKlinet_Middlename;
        private System.Windows.Forms.Label lblKlinet_Name;
        private System.Windows.Forms.Label lblKlinet_Surname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonДобавитьЗаказ;
        private System.Windows.Forms.Button buttonУдалитьЗаказ;
        private System.Windows.Forms.DataGridView dataGridViewЗаказы;
        private System.Windows.Forms.Button buttonИзмегнитьЗаказ;
        private System.Windows.Forms.TextBox textBoxНазваниеЧека;
        private System.Windows.Forms.DateTimePicker dateTimePickerДатаЧека;
        private System.Windows.Forms.Label labelЧек;
    }
}