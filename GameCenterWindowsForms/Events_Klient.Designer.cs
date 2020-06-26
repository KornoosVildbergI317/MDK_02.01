namespace GameCenterWindowsForms
{
    partial class Events_Klient
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
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxKlient = new System.Windows.Forms.ComboBox();
            this.comboBoxGoods = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(685, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 25);
            this.button7.TabIndex = 122;
            this.button7.Text = "Фильтр";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(621, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 25);
            this.button6.TabIndex = 121;
            this.button6.Text = "Поиск";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(747, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 25);
            this.button5.TabIndex = 120;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(356, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 20);
            this.textBoxSearch.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Событие";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 49);
            this.button2.TabIndex = 110;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 49);
            this.button1.TabIndex = 107;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Клиент";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(794, 171);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick_1);
            // 
            // comboBoxKlient
            // 
            this.comboBoxKlient.FormattingEnabled = true;
            this.comboBoxKlient.Location = new System.Drawing.Point(6, 231);
            this.comboBoxKlient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxKlient.Name = "comboBoxKlient";
            this.comboBoxKlient.Size = new System.Drawing.Size(125, 21);
            this.comboBoxKlient.TabIndex = 123;
            // 
            // comboBoxGoods
            // 
            this.comboBoxGoods.FormattingEnabled = true;
            this.comboBoxGoods.Location = new System.Drawing.Point(6, 269);
            this.comboBoxGoods.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGoods.Name = "comboBoxGoods";
            this.comboBoxGoods.Size = new System.Drawing.Size(125, 21);
            this.comboBoxGoods.TabIndex = 124;
            // 
            // Events_Klient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 366);
            this.Controls.Add(this.comboBoxGoods);
            this.Controls.Add(this.comboBoxKlient);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Events_Klient";
            this.Text = "События_Клиент";
            this.Load += new System.EventHandler(this.Events_Klient_Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxKlient;
        private System.Windows.Forms.ComboBox comboBoxGoods;
    }
}