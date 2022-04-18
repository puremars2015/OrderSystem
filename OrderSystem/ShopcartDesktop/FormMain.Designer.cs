
namespace ShopcartDesktop
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button0Ice = new System.Windows.Forms.Button();
            this.button3Ice = new System.Windows.Forms.Button();
            this.button7Ice = new System.Windows.Forms.Button();
            this.button10Ice = new System.Windows.Forms.Button();
            this.button0Suger = new System.Windows.Forms.Button();
            this.button3Suger = new System.Windows.Forms.Button();
            this.button7Suger = new System.Windows.Forms.Button();
            this.button10Suger = new System.Windows.Forms.Button();
            this.buttonClearItems = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.dataGridView_shopcart = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExportCustomer = new System.Windows.Forms.Button();
            this.buttonImportCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shopcart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 43.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(4867, 2915);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button0Ice);
            this.tabPage1.Controls.Add(this.button3Ice);
            this.tabPage1.Controls.Add(this.button7Ice);
            this.tabPage1.Controls.Add(this.button10Ice);
            this.tabPage1.Controls.Add(this.button0Suger);
            this.tabPage1.Controls.Add(this.button3Suger);
            this.tabPage1.Controls.Add(this.button7Suger);
            this.tabPage1.Controls.Add(this.button10Suger);
            this.tabPage1.Controls.Add(this.buttonClearItems);
            this.tabPage1.Controls.Add(this.buttonCount);
            this.tabPage1.Controls.Add(this.buttonDeleteItem);
            this.tabPage1.Controls.Add(this.dataGridView_shopcart);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 68);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(4859, 2843);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "點單";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button0Ice
            // 
            this.button0Ice.Location = new System.Drawing.Point(1113, 232);
            this.button0Ice.Name = "button0Ice";
            this.button0Ice.Size = new System.Drawing.Size(243, 73);
            this.button0Ice.TabIndex = 14;
            this.button0Ice.Text = "去冰";
            this.button0Ice.UseVisualStyleBackColor = true;
            this.button0Ice.Click += new System.EventHandler(this.button0Ice_Click);
            // 
            // button3Ice
            // 
            this.button3Ice.Location = new System.Drawing.Point(857, 232);
            this.button3Ice.Name = "button3Ice";
            this.button3Ice.Size = new System.Drawing.Size(250, 73);
            this.button3Ice.TabIndex = 13;
            this.button3Ice.Text = "微冰";
            this.button3Ice.UseVisualStyleBackColor = true;
            this.button3Ice.Click += new System.EventHandler(this.button3Ice_Click);
            // 
            // button7Ice
            // 
            this.button7Ice.Location = new System.Drawing.Point(1113, 153);
            this.button7Ice.Name = "button7Ice";
            this.button7Ice.Size = new System.Drawing.Size(243, 73);
            this.button7Ice.TabIndex = 12;
            this.button7Ice.Text = "少冰";
            this.button7Ice.UseVisualStyleBackColor = true;
            this.button7Ice.Click += new System.EventHandler(this.button7Ice_Click);
            // 
            // button10Ice
            // 
            this.button10Ice.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10Ice.Location = new System.Drawing.Point(857, 153);
            this.button10Ice.Name = "button10Ice";
            this.button10Ice.Size = new System.Drawing.Size(250, 73);
            this.button10Ice.TabIndex = 11;
            this.button10Ice.Text = "正常冰";
            this.button10Ice.UseVisualStyleBackColor = true;
            this.button10Ice.Click += new System.EventHandler(this.button10Ice_Click);
            // 
            // button0Suger
            // 
            this.button0Suger.Location = new System.Drawing.Point(1113, 77);
            this.button0Suger.Name = "button0Suger";
            this.button0Suger.Size = new System.Drawing.Size(243, 70);
            this.button0Suger.TabIndex = 10;
            this.button0Suger.Text = "無糖";
            this.button0Suger.UseVisualStyleBackColor = true;
            this.button0Suger.Click += new System.EventHandler(this.button0Suger_Click);
            // 
            // button3Suger
            // 
            this.button3Suger.Location = new System.Drawing.Point(857, 77);
            this.button3Suger.Name = "button3Suger";
            this.button3Suger.Size = new System.Drawing.Size(250, 70);
            this.button3Suger.TabIndex = 9;
            this.button3Suger.Text = "微糖";
            this.button3Suger.UseVisualStyleBackColor = true;
            this.button3Suger.Click += new System.EventHandler(this.button3Suger_Click);
            // 
            // button7Suger
            // 
            this.button7Suger.Location = new System.Drawing.Point(1113, 3);
            this.button7Suger.Name = "button7Suger";
            this.button7Suger.Size = new System.Drawing.Size(243, 68);
            this.button7Suger.TabIndex = 8;
            this.button7Suger.Text = "少糖";
            this.button7Suger.UseVisualStyleBackColor = true;
            this.button7Suger.Click += new System.EventHandler(this.button7Suger_Click);
            // 
            // button10Suger
            // 
            this.button10Suger.Location = new System.Drawing.Point(857, 3);
            this.button10Suger.Name = "button10Suger";
            this.button10Suger.Size = new System.Drawing.Size(250, 68);
            this.button10Suger.TabIndex = 7;
            this.button10Suger.Text = "全糖";
            this.button10Suger.UseVisualStyleBackColor = true;
            this.button10Suger.Click += new System.EventHandler(this.button10Suger_Click);
            // 
            // buttonClearItems
            // 
            this.buttonClearItems.Location = new System.Drawing.Point(1020, 695);
            this.buttonClearItems.Name = "buttonClearItems";
            this.buttonClearItems.Size = new System.Drawing.Size(156, 115);
            this.buttonClearItems.TabIndex = 5;
            this.buttonClearItems.Text = "清空";
            this.buttonClearItems.UseVisualStyleBackColor = true;
            this.buttonClearItems.Click += new System.EventHandler(this.buttonClearItems_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(1182, 695);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(174, 115);
            this.buttonCount.TabIndex = 4;
            this.buttonCount.Text = "結帳";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(857, 695);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(157, 115);
            this.buttonDeleteItem.TabIndex = 3;
            this.buttonDeleteItem.Text = "刪除";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // dataGridView_shopcart
            // 
            this.dataGridView_shopcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_shopcart.Location = new System.Drawing.Point(857, 311);
            this.dataGridView_shopcart.Name = "dataGridView_shopcart";
            this.dataGridView_shopcart.RowTemplate.Height = 24;
            this.dataGridView_shopcart.Size = new System.Drawing.Size(499, 378);
            this.dataGridView_shopcart.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 807);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExportCustomer);
            this.tabPage2.Controls.Add(this.buttonImportCustomer);
            this.tabPage2.Controls.Add(this.buttonDeleteCustomer);
            this.tabPage2.Controls.Add(this.buttonAddCustomer);
            this.tabPage2.Controls.Add(this.dataGridView_customer);
            this.tabPage2.Location = new System.Drawing.Point(4, 68);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(4859, 2843);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "客戶管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExportCustomer
            // 
            this.buttonExportCustomer.Location = new System.Drawing.Point(792, 365);
            this.buttonExportCustomer.Name = "buttonExportCustomer";
            this.buttonExportCustomer.Size = new System.Drawing.Size(301, 91);
            this.buttonExportCustomer.TabIndex = 5;
            this.buttonExportCustomer.Text = "匯出會員";
            this.buttonExportCustomer.UseVisualStyleBackColor = true;
            this.buttonExportCustomer.Click += new System.EventHandler(this.buttonExportCustomer_Click);
            // 
            // buttonImportCustomer
            // 
            this.buttonImportCustomer.Location = new System.Drawing.Point(792, 277);
            this.buttonImportCustomer.Name = "buttonImportCustomer";
            this.buttonImportCustomer.Size = new System.Drawing.Size(301, 82);
            this.buttonImportCustomer.TabIndex = 4;
            this.buttonImportCustomer.Text = "匯入會員";
            this.buttonImportCustomer.UseVisualStyleBackColor = true;
            this.buttonImportCustomer.Click += new System.EventHandler(this.buttonImportCustomer_Click);
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(792, 99);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(301, 81);
            this.buttonDeleteCustomer.TabIndex = 2;
            this.buttonDeleteCustomer.Text = "刪除會員";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            this.buttonDeleteCustomer.Click += new System.EventHandler(this.buttonDeleteCustomer_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(792, 14);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(301, 79);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "新增會員";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Location = new System.Drawing.Point(8, 14);
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.RowTemplate.Height = 24;
            this.dataGridView_customer.Size = new System.Drawing.Size(766, 592);
            this.dataGridView_customer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Font = new System.Drawing.Font("新細明體", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 68);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(4859, 2843);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "菜單管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 893);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("新細明體", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.Name = "FormMain";
            this.Text = "蘭美人POS系統";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_shopcart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_shopcart;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonClearItems;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonImportCustomer;
        private System.Windows.Forms.Button buttonExportCustomer;
        private System.Windows.Forms.Button button10Suger;
        private System.Windows.Forms.Button button7Suger;
        private System.Windows.Forms.Button button3Suger;
        private System.Windows.Forms.Button button0Suger;
        private System.Windows.Forms.Button button7Ice;
        private System.Windows.Forms.Button button10Ice;
        private System.Windows.Forms.Button button3Ice;
        private System.Windows.Forms.Button button0Ice;
    }
}

