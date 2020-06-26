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
    public partial class Personal_Profile_Klient : Form
    {

        private Int32 ID_Заказа = -1;

        public Personal_Profile_Klient()
        {
            InitializeComponent();
        }

        private void Personal_Profile_Klient_Load(object sender, EventArgs e)
        {
            dataGridViewЗаказы.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgFill();


        }




        private void DgFill()
        {

            //var sqlstr = $"select distinct ID_Check, Nomer_Check from dbo.[Check] " +
            //    "inner join  dbo.Goods_Klient_Check on dbo.Goods_Klient_Check.Check_ID = dbo.[Check].ID_Check "+
            //    "where dbo.Goods_Klient_Check.Klient_ID = " + Program.IDKlient;

            var sqlstr = "select distinct ID_Check, Nomer_Check from dbo.[Check] " +
                "inner join  dbo.Events_Klient_Check on dbo.Events_Klient_Check.Check_ID = dbo.[Check].ID_Check " +
                "where dbo.Events_Klient_Check.Klient_ID = " + Program.IDKlient +
                "union select ID_Check, Nomer_Check " +
                "from dbo.[Check] left join  dbo.Events_Klient_Check " +
                "on dbo.Events_Klient_Check.Check_ID = dbo.[Check].ID_Check " +
                "where dbo.Events_Klient_Check.Check_ID is Null";

            var table_class = new Table_Class(sqlstr);
            dataGridViewЗаказы.DataSource = table_class.table.DefaultView;
            dataGridViewЗаказы.Columns[0].Visible = false;



            lblKlinet_Name.Text = "Имя: " + Program.modelKlient.Name_Klient;
            lblKlient_IsZaban.Text = "Заблокирован: " + Program.modelKlient.Klient_Logical_Delete.ToString();
            lblKlinet_Middlename.Text = "Отчество: " + Program.modelKlient.Middle_Name_Klient;
            lblKlinet_Surname.Text = "Фамилия: " + Program.modelKlient.First_Name_Klient;


            tbConfermPassword.Text = Program.modelKlient.Klient_Password;
            tbConfermPassword.Enabled = !Program.modelKlient.Klient_Logical_Delete;

            tbFirst_Name.Text = Program.modelKlient.First_Name_Klient;
            tbFirst_Name.Enabled = !Program.modelKlient.Klient_Logical_Delete;

            tbLogin.Text = Program.modelKlient.Klient_Login;
            tbLogin.Enabled = !Program.modelKlient.Klient_Logical_Delete;

            tbMiddle_Name.Text = Program.modelKlient.Middle_Name_Klient;
            tbMiddle_Name.Enabled = !Program.modelKlient.Klient_Logical_Delete;

            tbName.Text = Program.modelKlient.Name_Klient;
            tbName.Enabled = !Program.modelKlient.Klient_Logical_Delete;

            tbPassword.Text = Program.modelKlient.Klient_Password;
            tbPassword.Enabled = !Program.modelKlient.Klient_Logical_Delete;
        }

        private void Dependency_OnChange(object sender, System.Data.SqlClient.SqlNotificationEventArgs e)
        {
            //Если отклик не равен бездействию, то перевыполняем метод
            //Заполения данных о клиенте
            if (e.Info != System.Data.SqlClient.SqlNotificationInfo.Invalid)
                DgFill();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Authorization().Show();
            Close();
        }

        private void ButtonДобавитьЗаказ_Click(object sender, EventArgs e)
        {


            if (textBoxНазваниеЧека.Text == string.Empty)
            {
                MessageBox.Show("Не задано имя заказа");
                return;
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add(textBoxНазваниеЧека.Text);
            arrayList.Add(dateTimePickerДатаЧека.Value.ToString());
            new Procedure_Class().procedure_Execution("Check_insert", arrayList);
            DgFill();


        }

        private void ButtonУдалитьЗаказ_Click(object sender, EventArgs e)
        {
            if (ID_Заказа == -1)
            {

                MessageBox.Show("Не выбран заказ");
                return;
            }


            ArrayList arrayList = new ArrayList();
            arrayList.Add(ID_Заказа);
            new Procedure_Class().procedure_Execution("Check_delete", arrayList);
            DgFill();


        }

        private void ButtonИзмегнитьЗаказ_Click(object sender, EventArgs e)
        {
            if (ID_Заказа == -1)
            {

                MessageBox.Show("Не выбран заказ");
                return;
            }

            new KlientZakazForm(ID_Заказа).ShowDialog();

        }



        private void DataGridViewЗаказы_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Заказа = (Int32)dataGridViewЗаказы.Rows[e.RowIndex].Cells[0].Value;
            var a = ID_Заказа;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(Program.IDKlient);
            arrayList.Add(tbFirst_Name.Text);
            arrayList.Add(tbName.Text);
            arrayList.Add(tbMiddle_Name.Text);
            arrayList.Add(tbLogin.Text);
            arrayList.Add(tbPassword.Text);
            new Procedure_Class().procedure_Execution("Klient_update", arrayList);
            Program.modelKlient.Update();
            DgFill();

        }

        private void TbctrlKlient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbpgKlientChekcHistory_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewЗаказы_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxНазваниеЧека_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerДатаЧека_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LabelЧек_Click(object sender, EventArgs e)
        {

        }

        private void GbKlient_Personal_Enter(object sender, EventArgs e)
        {

        }

        private void TbpgKlientProfile_Click(object sender, EventArgs e)
        {

        }

        private void TblltpnKLinet_Information_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
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

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TbFirst_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbMiddle_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbConfermPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void LblKlient_IsZaban_Click(object sender, EventArgs e)
        {

        }

        private void LblKlinet_Middlename_Click(object sender, EventArgs e)
        {

        }

        private void LblKlinet_Name_Click(object sender, EventArgs e)
        {

        }

        private void LblKlinet_Surname_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
