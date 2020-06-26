namespace GameCenterWindowsForms
{
    partial class KlientZakazForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonЗакрыть = new System.Windows.Forms.Button();
            this.buttonЭкспорт = new System.Windows.Forms.Button();
            this.buttonДобавить = new System.Windows.Forms.Button();
            this.buttonУдалить = new System.Windows.Forms.Button();
            this.comboBoxТовар = new System.Windows.Forms.ComboBox();
            this.labelТоварДляУдаления = new System.Windows.Forms.Label();
            this.comboBoxЭкспорт = new System.Windows.Forms.ComboBox();
            this.dataGridViewЗаказ = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказ)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.Controls.Add(this.buttonЗакрыть, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonЭкспорт, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonДобавить, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonУдалить, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxТовар, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelТоварДляУдаления, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxЭкспорт, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 340);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 158);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonЗакрыть
            // 
            this.buttonЗакрыть.Location = new System.Drawing.Point(2, 106);
            this.buttonЗакрыть.Margin = new System.Windows.Forms.Padding(2);
            this.buttonЗакрыть.Name = "buttonЗакрыть";
            this.buttonЗакрыть.Size = new System.Drawing.Size(268, 50);
            this.buttonЗакрыть.TabIndex = 5;
            this.buttonЗакрыть.Text = "Закрыть";
            this.buttonЗакрыть.UseVisualStyleBackColor = true;
            this.buttonЗакрыть.Click += new System.EventHandler(this.ButtonЗакрыть_Click);
            // 
            // buttonЭкспорт
            // 
            this.buttonЭкспорт.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonЭкспорт.Location = new System.Drawing.Point(2, 65);
            this.buttonЭкспорт.Margin = new System.Windows.Forms.Padding(2);
            this.buttonЭкспорт.Name = "buttonЭкспорт";
            this.buttonЭкспорт.Size = new System.Drawing.Size(268, 37);
            this.buttonЭкспорт.TabIndex = 4;
            this.buttonЭкспорт.Text = "Экспорт";
            this.buttonЭкспорт.UseVisualStyleBackColor = true;
            this.buttonЭкспорт.Click += new System.EventHandler(this.ButtonЭкспорт_Click);
            // 
            // buttonДобавить
            // 
            this.buttonДобавить.Location = new System.Drawing.Point(2, 2);
            this.buttonДобавить.Margin = new System.Windows.Forms.Padding(2);
            this.buttonДобавить.Name = "buttonДобавить";
            this.buttonДобавить.Size = new System.Drawing.Size(268, 19);
            this.buttonДобавить.TabIndex = 0;
            this.buttonДобавить.Text = "Добавить";
            this.buttonДобавить.UseVisualStyleBackColor = true;
            this.buttonДобавить.Click += new System.EventHandler(this.ButtonДобавить_Click);
            // 
            // buttonУдалить
            // 
            this.buttonУдалить.Location = new System.Drawing.Point(2, 26);
            this.buttonУдалить.Margin = new System.Windows.Forms.Padding(2);
            this.buttonУдалить.Name = "buttonУдалить";
            this.buttonУдалить.Size = new System.Drawing.Size(268, 34);
            this.buttonУдалить.TabIndex = 2;
            this.buttonУдалить.Text = "Удалить";
            this.buttonУдалить.UseVisualStyleBackColor = true;
            this.buttonУдалить.Click += new System.EventHandler(this.ButtonУдалить_Click);
            // 
            // comboBoxТовар
            // 
            this.comboBoxТовар.FormattingEnabled = true;
            this.comboBoxТовар.Location = new System.Drawing.Point(274, 2);
            this.comboBoxТовар.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxТовар.Name = "comboBoxТовар";
            this.comboBoxТовар.Size = new System.Drawing.Size(306, 21);
            this.comboBoxТовар.TabIndex = 6;
            // 
            // labelТоварДляУдаления
            // 
            this.labelТоварДляУдаления.AutoSize = true;
            this.labelТоварДляУдаления.Location = new System.Drawing.Point(274, 24);
            this.labelТоварДляУдаления.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelТоварДляУдаления.Name = "labelТоварДляУдаления";
            this.labelТоварДляУдаления.Size = new System.Drawing.Size(0, 13);
            this.labelТоварДляУдаления.TabIndex = 7;
            // 
            // comboBoxЭкспорт
            // 
            this.comboBoxЭкспорт.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxЭкспорт.FormattingEnabled = true;
            this.comboBoxЭкспорт.Items.AddRange(new object[] {
            ".docx",
            ".xlsx",
            ".pdf"});
            this.comboBoxЭкспорт.Location = new System.Drawing.Point(274, 65);
            this.comboBoxЭкспорт.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxЭкспорт.Name = "comboBoxЭкспорт";
            this.comboBoxЭкспорт.Size = new System.Drawing.Size(306, 21);
            this.comboBoxЭкспорт.TabIndex = 8;
            this.comboBoxЭкспорт.SelectedValueChanged += new System.EventHandler(this.ComboBoxЭкспорт_SelectedValueChanged);
            // 
            // dataGridViewЗаказ
            // 
            this.dataGridViewЗаказ.AllowUserToAddRows = false;
            this.dataGridViewЗаказ.AllowUserToDeleteRows = false;
            this.dataGridViewЗаказ.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewЗаказ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗаказ.Location = new System.Drawing.Point(9, 10);
            this.dataGridViewЗаказ.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewЗаказ.Name = "dataGridViewЗаказ";
            this.dataGridViewЗаказ.ReadOnly = true;
            this.dataGridViewЗаказ.RowHeadersWidth = 51;
            this.dataGridViewЗаказ.RowTemplate.Height = 24;
            this.dataGridViewЗаказ.Size = new System.Drawing.Size(582, 326);
            this.dataGridViewЗаказ.TabIndex = 3;
            this.dataGridViewЗаказ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewЗаказ_CellClick);
            // 
            // KlientZakazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dataGridViewЗаказ);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KlientZakazForm";
            this.Text = "КлиентЗаказ";
            this.Load += new System.EventHandler(this.KlientZakazForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonДобавить;
        private System.Windows.Forms.Button buttonУдалить;
        private System.Windows.Forms.DataGridView dataGridViewЗаказ;
        private System.Windows.Forms.Button buttonЭкспорт;
        private System.Windows.Forms.Button buttonЗакрыть;
        private System.Windows.Forms.ComboBox comboBoxТовар;
        private System.Windows.Forms.Label labelТоварДляУдаления;
        private System.Windows.Forms.ComboBox comboBoxЭкспорт;
    }
}