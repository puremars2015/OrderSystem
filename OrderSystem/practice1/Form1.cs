using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {

        private class RowComparer : System.Collections.IComparer
        {
            private static int sortOrderModifier = 1;

            public RowComparer(SortOrder sortOrder)
            {
                if (sortOrder == SortOrder.Descending)
                {
                    sortOrderModifier = -1;
                }
                else if (sortOrder == SortOrder.Ascending)
                {
                    sortOrderModifier = 1;
                }
            }

            public int Compare(object x, object y)
            {
                DataGridViewRow DataGridViewRow1 = (DataGridViewRow)x;
                DataGridViewRow DataGridViewRow2 = (DataGridViewRow)y;

                // Try to sort based on the Last Name column.
                int CompareResult = System.String.Compare(
                    DataGridViewRow1.Cells[1].Value.ToString(),
                    DataGridViewRow2.Cells[1].Value.ToString());

                // If the Last Names are equal, sort based on the First Name.
                if (CompareResult == 0)
                {
                    CompareResult = System.String.Compare(
                        DataGridViewRow1.Cells[0].Value.ToString(),
                        DataGridViewRow2.Cells[0].Value.ToString());
                }
                return CompareResult * sortOrderModifier;
            }
        }


        // Declare a string to hold the entire document contents.
        string documentContents;
        // Declare a variable to hold the portion of the document that  is not printed.
        string stringToPrint;

        public Form1()
        {
            InitializeComponent();
        }
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }

            public string NameWithQuantity
            {
                get
                {
                    return $"{this.Name}       {Quantity}杯";
                }
            }
            public Image Img { get; set; }
            public Product(string Name, int Price)
            {
                this.Name = Name;
                this.Price = Price;
                this.Quantity = 1;
            }
            public Product(string Name, int Price, int Quantity)
            {
                this.Name = Name;
                this.Price = Price;
                this.Quantity = Quantity;
            }
        }

        BindingList<Product> products = new BindingList<Product>()
        {
            new Product("茉莉綠茶", 25),
            new Product("紅茶", 20),
            new Product("豆漿", 30),
            new Product("越式咖啡", 45),
            new Product("果汁", 55),
            new Product("水果茶", 75),
        };

        List<Product> ppp = new List<Product>()
        {
            new Product("茉莉綠茶", 25),
            new Product("紅茶", 20),
            new Product("豆漿", 30),
            new Product("越式咖啡", 45),
            new Product("果汁", 55),
            new Product("水果茶", 75),
        };

        BindingList<Product> shopcar = new BindingList<Product>();

        private void Refresh_DataGridView1()
        {
            dataGridView1.DataSource = products;
            dataGridView1.Columns["Name"].Width = 260;
            dataGridView1.Columns["Name"].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
            dataGridView1.Columns["Name"].SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridView1.Columns["Name"].HeaderText = "產品名稱";
            dataGridView1.Columns["Price"].HeaderText = "價格";
            dataGridView1.Columns["Quantity"].Visible = false;
            dataGridView1.Columns["NameWithQuantity"].Visible = false;
            dataGridView1.Columns["Img"].Visible = false;
        }

        private void Refresh_DataGridView2()
        {
            dataGridView2.DataSource = shopcar;
            dataGridView2.Columns["Name"].Width = 185;
            dataGridView2.Columns["Name"].HeaderText = "產品名稱";
            dataGridView2.Columns["Price"].HeaderText = "價格";
            dataGridView2.Columns["Quantity"].HeaderText = "杯數";
            dataGridView2.Columns["NameWithQuantity"].Visible = false;
            dataGridView2.Columns["Img"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = products;
            listBox2.DataSource = shopcar;
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "NameWithQuantity";

            this.Refresh_DataGridView1();
            this.Refresh_DataGridView2();

            domainUpDown1.Items.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            domainUpDown1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }

            Product p = products[listBox1.SelectedIndex];
            label2.Text = p.Name + "$" + p.Price;
            textBox1.Text = p.Name;
            textBox2.Text = p.Price.ToString();

        }
        //加入購物車
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("您沒有選擇任何產品");
                return;
            }

            var item = products[listBox1.SelectedIndex];

            if (shopcar.Select( x => x.Name.Trim()).Contains(item.Name))
            {
                var updateItem = shopcar.Where(x => x.Name.Trim() == item.Name).First();
                updateItem.Quantity+=item.Quantity;
                listBox2.Refresh();
                dataGridView2.Refresh();

                listBox2.DataSource = null;
                listBox2.DataSource = this.shopcar;
                listBox2.DisplayMember = "NameWithQuantity";
            }
            else
            {
                shopcar.Add(new Product(
                item.Name,
                item.Price,
                (int)domainUpDown1.SelectedItem
                ));
            }
        }
        //刪除購物車內指定產品
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                shopcar.RemoveAt(listBox2.SelectedIndex);
            }
            else
            {
                MessageBox.Show("目前購物車內沒有任何產品");
            }
        }
        //清空
        private void button3_Click(object sender, EventArgs e)
        {
            if (shopcar.Count < 1)
            {
                MessageBox.Show("目前購物車沒有任何東西");
            }
            shopcar.Clear();
        }
        /// <summary>
        /// 結賬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = shopcar.Sum(a => a.Price * a.Quantity).ToString();
            label12.Text = shopcar.Sum(a => a.Quantity).ToString();
        }
        //新增產品
        private void button5_Click(object sender, EventArgs e)
        {
            if (!products.Select(x => x.Name.Trim()).Contains(textBox1.Text.Trim()))
            {
                products.Add(new Product(textBox1.Text, int.Parse(textBox2.Text)));
            }
            else
            {
                MessageBox.Show("請勿重複新增商品!");
            }
        }

        /// <summary>
        /// 修改產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            products[listBox1.SelectedIndex] = new Product(textBox1.Text, int.Parse(textBox2.Text));

        }
        /// <summary>
        /// 刪除產品
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                products.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("目前產品清單沒有設定任何產品");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            this.products = new BindingList<Product>(products.OrderBy(x => x.Price).ToList());
            listBox1.DataSource = this.products;
            listBox1.DisplayMember = "Name";

            this.Refresh_DataGridView1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            this.products = new BindingList<Product>(products.OrderByDescending(x => x.Price).ToList());
            listBox1.DataSource = this.products;
            listBox1.DisplayMember = "Name";

            this.Refresh_DataGridView1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = "列印訂單";

            string output = "------------產品訂單------------" + Environment.NewLine;

            foreach (Product item in listBox2.Items)
            {
                output += item.NameWithQuantity + Environment.NewLine;
            }

            output += "總杯數:" + shopcar.Sum(a => a.Quantity).ToString() + Environment.NewLine;
            output += "總價:" + shopcar.Sum(a => a.Price * a.Quantity).ToString() + Environment.NewLine;

            documentContents = output;
            stringToPrint = output;

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

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

        private void button11_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                if (shopcar[listBox2.SelectedIndex].Quantity - 1 <= 0)
                {
                    shopcar.RemoveAt(listBox2.SelectedIndex);
                }
                else
                {
                    shopcar[listBox2.SelectedIndex].Quantity--;
                    dataGridView2.Refresh();

                    listBox2.DataSource = null;
                    listBox2.DataSource = this.shopcar;
                    listBox2.DisplayMember = "NameWithQuantity";
                }
            }
            else
            {
                MessageBox.Show("目前購物車任何產品");
            }
           
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show(e.ColumnIndex.ToString());

            //dataGridView1.SortOrder == SortOrder.
        }
    }

}
