using Microsoft.VisualBasic.FileIO;
using ShopcartCore;
using ShopcartModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopcartDesktop
{
    public partial class FormMain : Form
    {
        private BindingList<OrderedProduct> shopcart = new BindingList<OrderedProduct>();
        private Product CurrentProduct { get; set; }
        private List<Button> SugerSelector = new List<Button>();
        private List<Button> IceSelector = new List<Button>();
        private SugerLevel currentSugerLevel { get; set; }
        private IceLevel currentIceLevel { get; set; }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            SugerSelector.Add(this.button0Suger);
            SugerSelector.Add(this.button3Suger);
            SugerSelector.Add(this.button7Suger);
            SugerSelector.Add(this.button10Suger);

            IceSelector.Add(this.button0Ice);
            IceSelector.Add(this.button3Ice);
            IceSelector.Add(this.button7Ice);
            IceSelector.Add(this.button10Ice);

            //Set default sugar and ice
            sugerButterAction(this.button10Suger, SugerLevel.全糖);
            iceButterAction(this.button10Ice, IceLevel.正常冰);

           
            ShowOrderSystem();



        }

        private void ShowOrderSystem()
        {
            SetDataGridViewShopcart();

            var products = LoadingDrinkData().ToList();

            panel1.AutoScroll = true;
            //panel1.AutoScrollMinSize = new System.Drawing.Size(panel1.Size.Width, 2500);
            for (int i = 0, x = 10, y = 10; i < products.Count; i++)
            {
                var button = GetProductButton(products[i], x, y);
                this.panel1.Controls.Add(button);

                if (i % 6 != 5)
                {
                    x += 130;
                }
                else
                {
                    x = 10;
                    y += 130;
                }
            }
        }

        private void SetDataGridViewShopcart()
        {
            dataGridView_shopcart.RowHeadersVisible = false;
            dataGridView_shopcart.Font = new Font(this.Font.FontFamily, 14);
            dataGridView_shopcart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_shopcart.ReadOnly = true;

            var containerWidth = dataGridView_shopcart.Width;

            dataGridView_shopcart.DataSource = this.shopcart;
            dataGridView_shopcart.Columns["ItemName"].HeaderText = "產品名稱";
            dataGridView_shopcart.Columns["ItemPrice"].HeaderText = "單價";
            dataGridView_shopcart.Columns["TotalPrice"].HeaderText = "小計";
            dataGridView_shopcart.Columns["ItemQuantity"].HeaderText = "杯數";
            dataGridView_shopcart.Columns["SugerLevel"].HeaderText = "甜度";
            dataGridView_shopcart.Columns["IceLevel"].HeaderText = "冰度";
            dataGridView_shopcart.Columns["NameWithQuantity"].Visible = false;
            dataGridView_shopcart.Columns["Img"].Visible = false;
            dataGridView_shopcart.Columns["ItemNo"].Visible = false;
            dataGridView_shopcart.Columns["ItemName"].Width = (int)(containerWidth * 0.23) - 1;
            dataGridView_shopcart.Columns["ItemPrice"].Width = (int)(containerWidth * 0.17) - 1;
            dataGridView_shopcart.Columns["TotalPrice"].Width = (int)(containerWidth * 0.17) - 1;
            dataGridView_shopcart.Columns["ItemQuantity"].Width = (int)(containerWidth * 0.15) - 1;
            dataGridView_shopcart.Columns["SugerLevel"].Width = (int)(containerWidth * 0.15) - 1;
            dataGridView_shopcart.Columns["IceLevel"].Width = (int)(containerWidth * 0.15) - 1;
            dataGridView_shopcart.Columns["ItemName"].DisplayIndex = 0;
            dataGridView_shopcart.Columns["SugerLevel"].DisplayIndex = 1;
            dataGridView_shopcart.Columns["IceLevel"].DisplayIndex = 2;
            dataGridView_shopcart.Columns["ItemQuantity"].DisplayIndex = 3;
            dataGridView_shopcart.Columns["ItemPrice"].DisplayIndex = 4;
            dataGridView_shopcart.Columns["TotalPrice"].DisplayIndex = 5;
        }

        private ProductButton GetProductButton(Product Product, int X, int Y)
        {
            ProductButton button = new ProductButton(Product);
            button.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            button.Font = new Font(this.tabPage1.Font.FontFamily, 30);
            button.Location = new Point(X, Y);
            button.Size = new System.Drawing.Size(130, 130);
            button.BackColor = Color.White;
            button.Click += AddItem;
            return button;
        }

        private void AddItem(object sender, EventArgs e)
        {
            var btn = sender as ProductButton;
            this.CurrentProduct = btn.Product;

            if (shopcart.Any(x => x.ItemNo == btn.ItemNo 
            && x.IceLevel == currentIceLevel 
            && x.SugerLevel == currentSugerLevel))
            {
                var updateItem = shopcart.Where(x => x.ItemNo == btn.ItemNo
                && x.IceLevel == currentIceLevel
            && x.SugerLevel == currentSugerLevel).First();
                updateItem.ItemQuantity += 1;
                dataGridView_shopcart.Refresh();
            }
            else
            {
                shopcart.Add(new OrderedProduct(this.currentSugerLevel, this.currentIceLevel, btn.Product));
            }
        }

        private IEnumerable<customer> LoadingCustomerData()
        {
            CustomerService product = new CustomerService();
            return product.GetCustomers();
        }

        private IEnumerable<Product> LoadingDrinkData()
        {
            ProductService product = new ProductService();
            return product.GetProducts().Select(x => new Product(x.rowid, x.drink_name, x.drink_price));
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            CustomerService service = new CustomerService();
            dataGridView_customer.DataSource = service.GetCustomers();
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            foreach (var row in this.dataGridView_shopcart.SelectedRows)
            {
                this.dataGridView_shopcart.Rows.Remove(row as DataGridViewRow);
            }
        }

        /// <summary>
        /// 結帳
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (this.shopcart.Count > 0)
            {
                FormBill formBill = new FormBill(this.shopcart.ToList());
                formBill.ShowDialog();
            }
            else
            {
                MessageBox.Show("並未選購任何商品,無法結帳!");
            }
        }

        private void buttonClearItems_Click(object sender, EventArgs e)
        {
            this.dataGridView_shopcart.Rows.Clear();
        }

        private void ShowCustomerManagement()
        {
            dataGridView_customer.RowHeadersVisible = false;
            dataGridView_customer.Font = new Font(this.Font.FontFamily, 14);
            dataGridView_customer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_customer.ReadOnly = true;

            var containerWidth = this.dataGridView_customer.Width;
            
            this.dataGridView_customer.DataSource = this.LoadingCustomerData();
            dataGridView_customer.Columns["rowid"].HeaderText = "會員序號";
            dataGridView_customer.Columns["name"].HeaderText = "會員名稱";
            dataGridView_customer.Columns["phone"].HeaderText = "電話";
            dataGridView_customer.Columns["rowid"].Width = (int)(containerWidth * 0.19) - 1;
            dataGridView_customer.Columns["name"].Width = (int)(containerWidth * 0.39) - 1;
            dataGridView_customer.Columns["phone"].Width = (int)(containerWidth * 0.39) - 1;
        }

        private void ShowDrinksManagement()
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Text)
            {
                case "點單":
                    ShowOrderSystem();
                    break;
                case "客戶管理":
                    ShowCustomerManagement();
                    break;
                case "菜單管理":
                    ShowDrinksManagement();
                    break;
            }
        }

        /// <summary>
        /// 匯入客戶資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonImportCustomer_Click(object sender, EventArgs e)
        {
            List<customer> customers = new List<customer>();

            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.InitialDirectory = "C:\\";
                dialog.Filter = "csv逗點分隔檔 (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dialog.FileName, FileMode.Open))
                    {
                        using (TextFieldParser csvReader = new TextFieldParser(stream))
                        {
                            csvReader.CommentTokens = new string[] { "#" };
                            csvReader.SetDelimiters(new string[] { "," });
                            csvReader.HasFieldsEnclosedInQuotes = true;

                            //讀取Column Header
                            if (!csvReader.EndOfData)
                            {
                                string[] headerFields = csvReader.ReadFields();
                                if (headerFields[0].Trim() != "name" || headerFields[1].Trim() != "phone")
                                {
                                    MessageBox.Show("請使用csv文檔的匯入模板,非模板無法正確匯入");
                                    return;
                                }
                            }

                            //讀取資料
                            while (!csvReader.EndOfData)
                            {
                                string[] valueFields = csvReader.ReadFields();
                                var customer = new customer();
                                customer.name = valueFields[0];
                                customer.phone = valueFields[1];
                                customers.Add(customer);
                            }

                            CustomerService service = new CustomerService();

                            if (service.ImportCustomers(customers))
                            {
                                MessageBox.Show("會員匯入成功");
                                ShowCustomerManagement();
                                dataGridView_customer.Refresh();
                            }
                            else
                            {
                                MessageBox.Show("會員匯入失敗,請聯絡管理員!");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 匯出客戶資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExportCustomer_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.InitialDirectory = $"{Environment.GetEnvironmentVariable("USERPROFILE")}\\Downloads";
                dialog.Filter = "csv逗點分隔檔 (*.csv)|*.csv";
                dialog.FileName = $"客戶資料{DateTime.Now.ToString("yyyy-MM-dd")}";

                CustomerService service = new CustomerService();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        CSVGenerator(true, dialog.FileName, service.GetCustomers());
                        MessageBox.Show("檔案產生完成");
                        ShowCustomerManagement();
                        dataGridView_customer.Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("檔案產生失敗,請聯絡系統管理員");
                    }
                }
            }
        }

        /// <summary>
        /// CSV Generator
        /// </summary>
        /// <param name="genColumn">output data property name</param>
        /// <param name="FilePath">target CSV path</param>
        /// <param name="data"> List of T</param>
        void CSVGenerator<T>(bool genColumn, string FilePath, List<T> data)
        {
            using (var file = new StreamWriter(FilePath,false,Encoding.UTF8))
            {
                Type t = typeof(T);
                PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
                //是否要輸出屬性名稱
                if (genColumn)
                {
                    file.WriteLine(string.Join(",", propInfos.Select(i => i.Name)));
                }
                foreach (var item in data)
                {
                    file.WriteLine(string.Join(",", propInfos.Select(i => i.GetValue(item))));
                }
            }
        }

        #region 糖冰按鈕
        private void clearSugerSelector()
        {
            this.SugerSelector.ForEach( x => x.BackColor = Color.White);
        }
        
        private void clearIceSelector()
        {
            this.IceSelector.ForEach(x => x.BackColor = Color.White);
        }

        private void sugerButterAction(Button sender, SugerLevel level)
        {
            clearSugerSelector();
            sender.BackColor = Color.Yellow;
            currentSugerLevel = level;
        }

        private void iceButterAction(Button sender, IceLevel level)
        {
            clearIceSelector();
            sender.BackColor = Color.Aqua;
            currentIceLevel = level;
        }

        private void button10Suger_Click(object sender, EventArgs e)
        {
            sugerButterAction((Button)sender, SugerLevel.全糖);
        }

        private void button7Suger_Click(object sender, EventArgs e)
        {
            sugerButterAction((Button)sender, SugerLevel.少糖);
        }

        private void button3Suger_Click(object sender, EventArgs e)
        {
            sugerButterAction((Button)sender, SugerLevel.微糖);
        }

        private void button0Suger_Click(object sender, EventArgs e)
        {
            sugerButterAction((Button)sender, SugerLevel.無糖);
        }

        private void button10Ice_Click(object sender, EventArgs e)
        {
            iceButterAction((Button)sender, IceLevel.正常冰);
        }

        private void button7Ice_Click(object sender, EventArgs e)
        {
            iceButterAction((Button)sender, IceLevel.少冰);
        }

        private void button3Ice_Click(object sender, EventArgs e)
        {
            iceButterAction((Button)sender, IceLevel.微冰);
        }

        private void button0Ice_Click(object sender, EventArgs e)
        {
            iceButterAction((Button)sender, IceLevel.去冰);
        }

        #endregion

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormCustomerManagement form = new FormCustomerManagement();
            form.ShowDialog();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            var rowid = this.dataGridView_customer.SelectedRows[0].Cells[0].Value;

            CustomerService cs = new CustomerService();
            cs.DeleteCustomer((int)rowid);

            dataGridView_customer.DataSource = cs.GetCustomers();
        }
    }
}
