using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenterWindowsForms
{
    public partial class RoleForm : Form
    {
        private Int32 ID_Supplier;
        public RoleForm()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            //CbFill();
        }

        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Role, " +
            "Name_of_Role as Роли, " +
            "Address_Role as Адрес_ролей, " +
            "Phone_Role as Телефон_исполнителя роли " +
            "FROM Role ";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            dataGridView1.Columns[0].Visible = false;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Supplier = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxSupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            Visible = false;
            ShowInTaskbar = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Supplier);
            new Procedure_Class().procedure_Execution("Role_delete", arrayList);
            DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxSupplier.Text);
            arrayList.Add(textBoxAddress.Text);
            arrayList.Add(textBoxPhone.Text);
            new Procedure_Class().procedure_Execution("Role_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID_Supplier == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Supplier);
            arrayList.Add(textBoxSupplier.Text);
            arrayList.Add(textBoxAddress.Text);
            arrayList.Add(textBoxPhone.Text);
            new Procedure_Class().procedure_Execution("Role_update", arrayList);
            DgFill();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        }
                        else
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.White)
                {
                    dataGridView1.CurrentCell = null;
                    dataGridView1.Rows[i].Visible = false;
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DgFill();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}