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
    public partial class TypeEventsForm : Form
    {
        private Int32 ID_Type_of_Events = -1;

        public TypeEventsForm()
        {
            InitializeComponent();


            //comboBoxPosition.Item

        }

        private void TypeEvents_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();
            CbFill();
        }

        private void CbFill()
        {
            comboBoxSupplier.DataSource = new Table_Class("SELECT ID_Role, Name_of_Role FROM dbo.Role").table.DefaultView;
            comboBoxSupplier.ValueMember = "ID_Role";
            comboBoxSupplier.DisplayMember = "Name_of_Role";
            comboBoxSupplier.SelectedIndex = -1;

            comboBoxGoods.DataSource = new Table_Class("SELECT ID_Events, Name_of_Events FROM dbo.Events").table.DefaultView;
            comboBoxGoods.ValueMember = "ID_Events";
            comboBoxGoods.DisplayMember = "Name_of_Events";
            comboBoxGoods.SelectedIndex = -1;

            comboBoxEmployee.DataSource = new Table_Class("SELECT ID_Employee, First_Name FROM dbo.Employee").table.DefaultView;
            comboBoxEmployee.ValueMember = "ID_Employee";
            comboBoxEmployee.DisplayMember = "First_Name";
            comboBoxEmployee.SelectedIndex = -1;

        }

        private void DgFill()
        {

            string sqlstr = "SELECT " +
            "ID_Type_of_Events,  " +
            "Role.Name_of_Role as Роли, " +
            "Events.Name_of_Events as События, " +
            "Employee.First_Name as Сотрудник, " +
            "Name_of_Type_Events as Тип_события, " +
            "Role_ID, Events_ID, Employee_ID " +
            "FROM Type_of_Events " +
            "INNER JOIN Role ON ID_Role = Role_ID " +
            "INNER JOIN Events ON ID_Events = Events_ID " +
            "INNER JOIN Employee ON ID_Employee = Employee_ID";
            var table_class = new Table_Class(sqlstr);
            dataGridView1.DataSource = table_class.table.DefaultView;
            //var v = table_class.table.Rows[3].ItemArray[3];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Type_of_Events = (Int32)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBoxName_of_Type_Goods.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxSupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxGoods.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxEmployee.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
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
            arrayList.Add(ID_Type_of_Events);
            new Procedure_Class().procedure_Execution("Type_of_Events_delete", arrayList);
            DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxName_of_Type_Goods.Text);
            arrayList.Add(comboBoxSupplier.SelectedValue);
            arrayList.Add(comboBoxGoods.SelectedValue);
            arrayList.Add(comboBoxEmployee.SelectedValue);
            new Procedure_Class().procedure_Execution("Type_of_Events_insert", arrayList);
            DgFill();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID_Type_of_Events == -1)
            {
                MessageBox.Show("No select!");
                return;

            }
            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Type_of_Events);
            arrayList.Add(textBoxName_of_Type_Goods.Text);
            arrayList.Add(comboBoxSupplier.SelectedValue);
            arrayList.Add(comboBoxGoods.SelectedValue);
            arrayList.Add(comboBoxEmployee.SelectedValue);
            new Procedure_Class().procedure_Execution("Type_of_Events_update", arrayList);
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

        private void TextBoxName_of_Type_Goods_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBoxGoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
