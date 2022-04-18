using ShopcartCore;
using ShopcartModel;
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
    public partial class FormBill : Form
    {
        private List<OrderedProduct> order { get; set; }

        public FormBill(List<OrderedProduct> shopcartOrder)
        {
            this.order = shopcartOrder;
            InitializeComponent();
        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            SetDataGridViewBill();
            SetComboBoxSelectCustomer();

            var totalPrice = this.order.Sum(x => x.ItemPrice * x.ItemQuantity);
            var totalCups = this.order.Sum(x => x.ItemQuantity);

            labelCupNumber.Text = totalCups.ToString();
            labelMoney.Text = totalPrice.Normalize().ToString();
        }

        private void SetComboBoxSelectCustomer()
        {
            this.comboBoxSelectCustomer.DataSource = GetCustomers();
            this.comboBoxSelectCustomer.DisplayMember = "text";
            this.comboBoxSelectCustomer.ValueMember = "rowid";
        }

        private void SetDataGridViewBill()
        {
            dataGridView_BillConfirm.RowHeadersVisible = false;
            dataGridView_BillConfirm.Font = new Font(this.Font.FontFamily, 14);
            dataGridView_BillConfirm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_BillConfirm.ReadOnly = true;

            var containerWidth = dataGridView_BillConfirm.Width;

            dataGridView_BillConfirm.DataSource = this.order;
            dataGridView_BillConfirm.Columns["ItemName"].HeaderText = "產品名稱";
            dataGridView_BillConfirm.Columns["ItemPrice"].HeaderText = "單價";
            dataGridView_BillConfirm.Columns["TotalPrice"].HeaderText = "小計";
            dataGridView_BillConfirm.Columns["ItemQuantity"].HeaderText = "杯數";
            dataGridView_BillConfirm.Columns["SugerLevel"].HeaderText = "甜度";
            dataGridView_BillConfirm.Columns["IceLevel"].HeaderText = "冰度";
            dataGridView_BillConfirm.Columns["NameWithQuantity"].Visible = false;
            dataGridView_BillConfirm.Columns["Img"].Visible = false;
            dataGridView_BillConfirm.Columns["ItemNo"].Visible = false;
            dataGridView_BillConfirm.Columns["ItemName"].Width = (int)(containerWidth * 0.30) - 1;
            dataGridView_BillConfirm.Columns["ItemPrice"].Width = (int)(containerWidth * 0.17) - 1;
            dataGridView_BillConfirm.Columns["TotalPrice"].Width = (int)(containerWidth * 0.17) - 1;
            dataGridView_BillConfirm.Columns["ItemQuantity"].Width = (int)(containerWidth * 0.17) - 1;
            dataGridView_BillConfirm.Columns["SugerLevel"].Width = (int)(containerWidth * 0.18) - 1;
            dataGridView_BillConfirm.Columns["IceLevel"].Width = (int)(containerWidth * 0.18) - 1;
            dataGridView_BillConfirm.Columns["ItemName"].DisplayIndex = 0;
            dataGridView_BillConfirm.Columns["SugerLevel"].DisplayIndex = 1;
            dataGridView_BillConfirm.Columns["IceLevel"].DisplayIndex = 2;
            dataGridView_BillConfirm.Columns["ItemQuantity"].DisplayIndex = 3;
            dataGridView_BillConfirm.Columns["ItemPrice"].DisplayIndex = 4;
            dataGridView_BillConfirm.Columns["TotalPrice"].DisplayIndex = 5;
        }

        private List<Customer> GetCustomers()
        {
            CustomerService product = new CustomerService();

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer
            {
                rowid = 0,
                name = "請輸入姓名電話",
                phone = ""
            });

            var cus = product.GetCustomers().Select(x => new Customer
            {
                rowid = x.rowid,
                name = x.name,
                phone = x.phone
            });

            customers.AddRange(cus);

            return customers;
        }

        private void buttonConfirmBill_Click(object sender, EventArgs e)
        {
            var selectItem = (Customer)comboBoxSelectCustomer.SelectedItem;

            if(selectItem.rowid == 0 
                && (string.IsNullOrEmpty(textBoxName.Text)
                || string.IsNullOrEmpty(textBoxPhone.Text)))
            {
                MessageBox.Show("尚未選擇客戶,或未輸入客戶名稱與電話!!");
                return;
            }

            OrderService os = new OrderService();
            CustomerService cs = new CustomerService();

            var txtName = textBoxName.Text.Trim();
            var txtPhone = textBoxPhone.Text.Trim();

            var orderList = this.order.Select(x => new sale_detail
            {
                product_rowid = x.ItemNo,
                quatity = x.ItemQuantity
            }).ToList();

            try
            {
                if (selectItem.rowid == 0)
                {
                    cs.ImportCustomers(new List<customer>()
                {
                    new customer
                    {
                        name = txtName,
                        phone = txtPhone
                    }
                });

                    var customer = cs.GetCustomers()
                        .Where(x => x.name == txtName && x.phone == txtPhone)
                        .First();

                    var result = os.InsertOrder(orderList, customer);
                }
                else
                {
                    var Cus = (comboBoxSelectCustomer.SelectedItem as Customer);

                    var result = os.InsertOrder(orderList, new customer
                    {
                        rowid = Cus.rowid,
                        name = Cus.name,
                        phone = Cus.phone
                    });
                }
                var isOK = MessageBox.Show("訂單已經成立!!", "訂單建立", MessageBoxButtons.OK);
                if (isOK == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("訂單建立失敗,請聯絡系統管理員!!");
            }




        }

        private void comboBoxSelectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Customer)((ComboBox)sender).SelectedItem).rowid == 0)
            {
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                labelName.Visible = true;
                labelPhone.Visible = true;
                textBoxName.Visible = true;
                textBoxPhone.Visible = true;
            }
            else
            {
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                labelName.Visible = false;
                labelPhone.Visible = false;
                textBoxName.Visible = false;
                textBoxPhone.Visible = false;
            }
        }

        #region 列印

        // Declare a string to hold the entire document contents.
        string documentContents;
        // Declare a variable to hold the portion of the document that  is not printed.
        string stringToPrint;

        private void buttonPrintBill_Click(object sender, EventArgs e)
        {
            var selectItem = (Customer)comboBoxSelectCustomer.SelectedItem;

            if (selectItem.rowid == 0
                && (string.IsNullOrEmpty(textBoxName.Text)
                || string.IsNullOrEmpty(textBoxPhone.Text)))
            {
                MessageBox.Show("尚未選擇客戶,或未輸入客戶名稱與電話!!");
                return;
            }

            printDocument1.DocumentName = "列印訂單";

            string output = "------------產品訂單------------" + Environment.NewLine;

            foreach (OrderedProduct item in order)
            {
                output += $"{item.ItemName}    {item.ItemQuantity}杯" + Environment.NewLine;
            }

            output += "總杯數:" + order.Sum(a => a.ItemQuantity).ToString() + Environment.NewLine;
            output += "總價:" + order.Sum(a => a.ItemPrice * a.ItemQuantity).ToString() + Environment.NewLine;

            var customer = (Customer)comboBoxSelectCustomer.SelectedItem;

            if (customer.rowid == 0)
            {
                output += $"客戶:{this.textBoxName}   客戶電話:{textBoxPhone}"; 
            }
            else
            {
                output += $"客戶:{customer.name}   客戶電話:{customer.phone}";
            }

          

            documentContents = output;
            stringToPrint = output;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters 
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            //e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            //    e.MarginBounds, StringFormat.GenericTypographic);
            e.Graphics.DrawString(stringToPrint, new Font(this.Font.FontFamily, 30, this.Font.Style), Brushes.Black,
                e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed.
            if (!e.HasMorePages)
                stringToPrint = documentContents;
        }

        #endregion
    }
}
