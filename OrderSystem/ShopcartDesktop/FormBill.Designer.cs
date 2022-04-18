
namespace ShopcartDesktop
{
    partial class FormBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.dataGridView_BillConfirm = new System.Windows.Forms.DataGridView();
            this.buttonConfirmBill = new System.Windows.Forms.Button();
            this.buttonPrintBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectCustomer = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCupNumber = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BillConfirm
            // 
            this.dataGridView_BillConfirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BillConfirm.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_BillConfirm.Name = "dataGridView_BillConfirm";
            this.dataGridView_BillConfirm.RowTemplate.Height = 24;
            this.dataGridView_BillConfirm.Size = new System.Drawing.Size(840, 507);
            this.dataGridView_BillConfirm.TabIndex = 0;
            // 
            // buttonConfirmBill
            // 
            this.buttonConfirmBill.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonConfirmBill.Location = new System.Drawing.Point(858, 392);
            this.buttonConfirmBill.Name = "buttonConfirmBill";
            this.buttonConfirmBill.Size = new System.Drawing.Size(124, 127);
            this.buttonConfirmBill.TabIndex = 1;
            this.buttonConfirmBill.Text = "確認";
            this.buttonConfirmBill.UseVisualStyleBackColor = true;
            this.buttonConfirmBill.Click += new System.EventHandler(this.buttonConfirmBill_Click);
            // 
            // buttonPrintBill
            // 
            this.buttonPrintBill.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonPrintBill.Location = new System.Drawing.Point(988, 392);
            this.buttonPrintBill.Name = "buttonPrintBill";
            this.buttonPrintBill.Size = new System.Drawing.Size(130, 127);
            this.buttonPrintBill.TabIndex = 2;
            this.buttonPrintBill.Text = "列印帳單";
            this.buttonPrintBill.UseVisualStyleBackColor = true;
            this.buttonPrintBill.Click += new System.EventHandler(this.buttonPrintBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(858, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "請選擇訂購人";
            // 
            // comboBoxSelectCustomer
            // 
            this.comboBoxSelectCustomer.Font = new System.Drawing.Font("新細明體", 18F);
            this.comboBoxSelectCustomer.FormattingEnabled = true;
            this.comboBoxSelectCustomer.Location = new System.Drawing.Point(864, 66);
            this.comboBoxSelectCustomer.Name = "comboBoxSelectCustomer";
            this.comboBoxSelectCustomer.Size = new System.Drawing.Size(254, 32);
            this.comboBoxSelectCustomer.TabIndex = 5;
            this.comboBoxSelectCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCustomer_SelectedIndexChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxName.Location = new System.Drawing.Point(932, 132);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 36);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("新細明體", 18F);
            this.textBoxPhone.Location = new System.Drawing.Point(932, 206);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(186, 36);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("新細明體", 18F);
            this.labelName.Location = new System.Drawing.Point(864, 135);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 24);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "姓名";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("新細明體", 18F);
            this.labelPhone.Location = new System.Drawing.Point(864, 209);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(58, 24);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "電話";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F);
            this.label2.Location = new System.Drawing.Point(862, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "總杯數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F);
            this.label3.Location = new System.Drawing.Point(864, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "總價";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F);
            this.label4.Location = new System.Drawing.Point(1049, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "杯";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 18F);
            this.label5.Location = new System.Drawing.Point(1049, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "元";
            // 
            // labelCupNumber
            // 
            this.labelCupNumber.AutoSize = true;
            this.labelCupNumber.Font = new System.Drawing.Font("新細明體", 18F);
            this.labelCupNumber.Location = new System.Drawing.Point(967, 284);
            this.labelCupNumber.Name = "labelCupNumber";
            this.labelCupNumber.Size = new System.Drawing.Size(64, 24);
            this.labelCupNumber.TabIndex = 14;
            this.labelCupNumber.Text = "label6";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("新細明體", 18F);
            this.labelMoney.Location = new System.Drawing.Point(967, 333);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(64, 24);
            this.labelMoney.TabIndex = 15;
            this.labelMoney.Text = "label7";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 531);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelCupNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxSelectCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrintBill);
            this.Controls.Add(this.buttonConfirmBill);
            this.Controls.Add(this.dataGridView_BillConfirm);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "FormBill";
            this.Text = "訂單確認";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BillConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BillConfirm;
        private System.Windows.Forms.Button buttonConfirmBill;
        private System.Windows.Forms.Button buttonPrintBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectCustomer;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCupNumber;
        private System.Windows.Forms.Label labelMoney;
    }
}