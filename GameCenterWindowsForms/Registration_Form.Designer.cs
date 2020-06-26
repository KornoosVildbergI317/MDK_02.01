namespace GameCenterWindowsForms
{
    partial class Registration_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirst_Name = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMiddle_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите фамилию";
            // 
            // tbFirst_Name
            // 
            this.tbFirst_Name.Location = new System.Drawing.Point(265, 94);
            this.tbFirst_Name.Name = "tbFirst_Name";
            this.tbFirst_Name.Size = new System.Drawing.Size(204, 22);
            this.tbFirst_Name.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(265, 164);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(204, 22);
            this.tbName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите имя";
            // 
            // tbMiddle_Name
            // 
            this.tbMiddle_Name.Location = new System.Drawing.Point(265, 232);
            this.tbMiddle_Name.Name = "tbMiddle_Name";
            this.tbMiddle_Name.Size = new System.Drawing.Size(204, 22);
            this.tbMiddle_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите отчество";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(265, 344);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(204, 22);
            this.tbPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(265, 290);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(204, 22);
            this.tbLogin.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Введите пароль";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMiddle_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirst_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Registration_Form";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirst_Name;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMiddle_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label label5;
    }
}