using ShopcartCore;
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
    public partial class FormCustomerManagement : Form
    {
        public FormCustomerManagement()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var txtName = this.textBoxName.Text;
            var txtPhone = this.textBoxPhone.Text;

            if (string.IsNullOrEmpty(txtName) 
                || string.IsNullOrEmpty(txtPhone))
            {
                MessageBox.Show("客戶名稱或電話尚未填寫,請確認!");
            }
            else
            {
                CustomerService cs = new CustomerService();
                cs.ImportCustomers(new List<customer>()
                {
                    new customer
                    {
                        name = txtName,
                        phone = txtPhone
                    }
                });

                MessageBox.Show("已經存檔!!");
            }

        }
    }
}
