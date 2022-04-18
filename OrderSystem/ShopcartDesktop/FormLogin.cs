using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopcartDesktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.textBoxAccount.Text == "nguyenlanqn298@gmail.com" 
                && this.textBoxPassword.Text == "jiayou111")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("帳號密碼有誤,請重新輸入!!!");
            }
        }
    }
}
