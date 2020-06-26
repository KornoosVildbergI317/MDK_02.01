using GameCenterWindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCenterWindowsForms
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {

            ArrayList arrayList = new ArrayList();
            arrayList.Add(-1);
            arrayList.Add(tbFirst_Name.Text);
            arrayList.Add(tbName.Text);
            arrayList.Add(tbMiddle_Name.Text);
            arrayList.Add(tbLogin.Text);
            arrayList.Add(tbPassword.Text);
            new Procedure_Class().procedure_Execution("Klient_insert", arrayList);
            MessageBox.Show("Вы успешно зарегистрировались в системе, ваш логин: " + tbLogin.Text + ", ваш пароль: " + tbPassword.Text);
            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
