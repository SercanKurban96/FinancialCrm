namespace FinancialCrm
{
    partial class FrmSpendings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpendings));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteSpending = new System.Windows.Forms.Button();
            this.btnAddSpending = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.txtSpendingName = new System.Windows.Forms.TextBox();
            this.lblgideradi = new System.Windows.Forms.Label();
            this.txtSpendingID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGiderlerFormu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.btnSpendingForm = new System.Windows.Forms.Button();
            this.btnBillingForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.btnUpdateSpending = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.dtpSpendingDate = new System.Windows.Forms.DateTimePicker();
            this.lbltarih = new System.Windows.Forms.Label();
            this.cmbSpendingCategory = new System.Windows.Forms.ComboBox();
            this.lblkategori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 415);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(855, 239);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDeleteSpending
            // 
            this.btnDeleteSpending.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSpending.BackgroundImage")));
            this.btnDeleteSpending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSpending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteSpending.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSpending.Location = new System.Drawing.Point(801, 243);
            this.btnDeleteSpending.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteSpending.Name = "btnDeleteSpending";
            this.btnDeleteSpending.Size = new System.Drawing.Size(98, 82);
            this.btnDeleteSpending.TabIndex = 30;
            this.btnDeleteSpending.UseVisualStyleBackColor = true;
            this.btnDeleteSpending.Click += new System.EventHandler(this.btnDeleteSpending_Click);
            // 
            // btnAddSpending
            // 
            this.btnAddSpending.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSpending.BackgroundImage")));
            this.btnAddSpending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSpending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddSpending.ForeColor = System.Drawing.Color.Black;
            this.btnAddSpending.Location = new System.Drawing.Point(950, 125);
            this.btnAddSpending.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddSpending.Name = "btnAddSpending";
            this.btnAddSpending.Size = new System.Drawing.Size(98, 82);
            this.btnAddSpending.TabIndex = 29;
            this.btnAddSpending.UseVisualStyleBackColor = true;
            this.btnAddSpending.Click += new System.EventHandler(this.btnAddSpending_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpendingList.BackgroundImage")));
            this.btnSpendingList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpendingList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.ForeColor = System.Drawing.Color.Black;
            this.btnSpendingList.Location = new System.Drawing.Point(801, 125);
            this.btnSpendingList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(98, 82);
            this.btnSpendingList.TabIndex = 28;
            this.btnSpendingList.UseVisualStyleBackColor = true;
            this.btnSpendingList.Click += new System.EventHandler(this.btnSpendingList_Click);
            // 
            // txtSpendingName
            // 
            this.txtSpendingName.BackColor = System.Drawing.Color.White;
            this.txtSpendingName.Location = new System.Drawing.Point(400, 175);
            this.txtSpendingName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSpendingName.Name = "txtSpendingName";
            this.txtSpendingName.Size = new System.Drawing.Size(361, 32);
            this.txtSpendingName.TabIndex = 27;
            // 
            // lblgideradi
            // 
            this.lblgideradi.Location = new System.Drawing.Point(247, 178);
            this.lblgideradi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgideradi.Name = "lblgideradi";
            this.lblgideradi.Size = new System.Drawing.Size(149, 24);
            this.lblgideradi.TabIndex = 36;
            this.lblgideradi.Text = "Gider Adı:";
            this.lblgideradi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpendingID
            // 
            this.txtSpendingID.BackColor = System.Drawing.Color.White;
            this.txtSpendingID.Location = new System.Drawing.Point(378, 138);
            this.txtSpendingID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSpendingID.Name = "txtSpendingID";
            this.txtSpendingID.Size = new System.Drawing.Size(361, 32);
            this.txtSpendingID.TabIndex = 35;
            this.txtSpendingID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Gider ID:";
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.lblGiderlerFormu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 54);
            this.panel2.TabIndex = 33;
            // 
            // lblGiderlerFormu
            // 
            this.lblGiderlerFormu.AutoSize = true;
            this.lblGiderlerFormu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiderlerFormu.ForeColor = System.Drawing.Color.White;
            this.lblGiderlerFormu.Location = new System.Drawing.Point(10, 13);
            this.lblGiderlerFormu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiderlerFormu.Name = "lblGiderlerFormu";
            this.lblGiderlerFormu.Size = new System.Drawing.Size(137, 24);
            this.lblGiderlerFormu.TabIndex = 2;
            this.lblGiderlerFormu.Text = "Giderler Formu";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(34, 520);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettingsForm
            // 
            this.btnSettingsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettingsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsForm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsForm.Location = new System.Drawing.Point(34, 450);
            this.btnSettingsForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSettingsForm.Name = "btnSettingsForm";
            this.btnSettingsForm.Size = new System.Drawing.Size(172, 48);
            this.btnSettingsForm.TabIndex = 11;
            this.btnSettingsForm.Text = "Ayarlar";
            this.btnSettingsForm.UseVisualStyleBackColor = true;
            this.btnSettingsForm.Click += new System.EventHandler(this.btnSettingsForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardForm.Location = new System.Drawing.Point(34, 380);
            this.btnDashboardForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(172, 48);
            this.btnDashboardForm.TabIndex = 10;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // btnBankProcessForm
            // 
            this.btnBankProcessForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankProcessForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessForm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessForm.Location = new System.Drawing.Point(34, 310);
            this.btnBankProcessForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBankProcessForm.Name = "btnBankProcessForm";
            this.btnBankProcessForm.Size = new System.Drawing.Size(172, 48);
            this.btnBankProcessForm.TabIndex = 9;
            this.btnBankProcessForm.Text = "Banka Hareketleri";
            this.btnBankProcessForm.UseVisualStyleBackColor = true;
            this.btnBankProcessForm.Click += new System.EventHandler(this.btnBankProcessForm_Click);
            // 
            // btnSpendingForm
            // 
            this.btnSpendingForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpendingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingForm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingForm.Location = new System.Drawing.Point(34, 240);
            this.btnSpendingForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpendingForm.Name = "btnSpendingForm";
            this.btnSpendingForm.Size = new System.Drawing.Size(172, 48);
            this.btnSpendingForm.TabIndex = 8;
            this.btnSpendingForm.Text = "Giderler";
            this.btnSpendingForm.UseVisualStyleBackColor = true;
            this.btnSpendingForm.Click += new System.EventHandler(this.btnSpendingForm_Click);
            // 
            // btnBillingForm
            // 
            this.btnBillingForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillingForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillingForm.ForeColor = System.Drawing.Color.White;
            this.btnBillingForm.Location = new System.Drawing.Point(34, 170);
            this.btnBillingForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBillingForm.Name = "btnBillingForm";
            this.btnBillingForm.Size = new System.Drawing.Size(172, 48);
            this.btnBillingForm.TabIndex = 7;
            this.btnBillingForm.Text = "Faturalar";
            this.btnBillingForm.UseVisualStyleBackColor = true;
            this.btnBillingForm.Click += new System.EventHandler(this.btnBillingForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(34, 100);
            this.btnBanksForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(172, 48);
            this.btnBanksForm.TabIndex = 6;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategoryForm
            // 
            this.btnCategoryForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoryForm.ForeColor = System.Drawing.Color.White;
            this.btnCategoryForm.Location = new System.Drawing.Point(34, 30);
            this.btnCategoryForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCategoryForm.Name = "btnCategoryForm";
            this.btnCategoryForm.Size = new System.Drawing.Size(172, 48);
            this.btnCategoryForm.TabIndex = 5;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // btnUpdateSpending
            // 
            this.btnUpdateSpending.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateSpending.BackgroundImage")));
            this.btnUpdateSpending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateSpending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateSpending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSpending.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateSpending.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSpending.Location = new System.Drawing.Point(950, 243);
            this.btnUpdateSpending.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateSpending.Name = "btnUpdateSpending";
            this.btnUpdateSpending.Size = new System.Drawing.Size(98, 82);
            this.btnUpdateSpending.TabIndex = 31;
            this.btnUpdateSpending.UseVisualStyleBackColor = true;
            this.btnUpdateSpending.Click += new System.EventHandler(this.btnUpdateSpending_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(84)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettingsForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.btnBankProcessForm);
            this.panel1.Controls.Add(this.btnSpendingForm);
            this.panel1.Controls.Add(this.btnBillingForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoryForm);
            this.panel1.Location = new System.Drawing.Point(-1, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 600);
            this.panel1.TabIndex = 32;
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.White;
            this.txtSpendingAmount.Location = new System.Drawing.Point(400, 211);
            this.txtSpendingAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(361, 32);
            this.txtSpendingAmount.TabIndex = 38;
            // 
            // lblmiktar
            // 
            this.lblmiktar.Location = new System.Drawing.Point(267, 214);
            this.lblmiktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(129, 24);
            this.lblmiktar.TabIndex = 39;
            this.lblmiktar.Text = "Miktar:";
            this.lblmiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpSpendingDate
            // 
            this.dtpSpendingDate.Location = new System.Drawing.Point(400, 248);
            this.dtpSpendingDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpSpendingDate.Name = "dtpSpendingDate";
            this.dtpSpendingDate.Size = new System.Drawing.Size(361, 32);
            this.dtpSpendingDate.TabIndex = 40;
            // 
            // lbltarih
            // 
            this.lbltarih.Location = new System.Drawing.Point(277, 250);
            this.lbltarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(118, 24);
            this.lbltarih.TabIndex = 41;
            this.lbltarih.Text = "Tarih:";
            this.lbltarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSpendingCategory
            // 
            this.cmbSpendingCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpendingCategory.FormattingEnabled = true;
            this.cmbSpendingCategory.Location = new System.Drawing.Point(400, 284);
            this.cmbSpendingCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbSpendingCategory.Name = "cmbSpendingCategory";
            this.cmbSpendingCategory.Size = new System.Drawing.Size(361, 32);
            this.cmbSpendingCategory.TabIndex = 42;
            // 
            // lblkategori
            // 
            this.lblkategori.Location = new System.Drawing.Point(254, 287);
            this.lblkategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkategori.Name = "lblkategori";
            this.lblkategori.Size = new System.Drawing.Size(142, 24);
            this.lblkategori.TabIndex = 43;
            this.lblkategori.Text = "Kategori:";
            this.lblkategori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1092, 654);
            this.Controls.Add(this.lblkategori);
            this.Controls.Add(this.cmbSpendingCategory);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.dtpSpendingDate);
            this.Controls.Add(this.txtSpendingAmount);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteSpending);
            this.Controls.Add(this.btnAddSpending);
            this.Controls.Add(this.btnSpendingList);
            this.Controls.Add(this.txtSpendingName);
            this.Controls.Add(this.lblgideradi);
            this.Controls.Add(this.txtSpendingID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpdateSpending);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpendings";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteSpending;
        private System.Windows.Forms.Button btnAddSpending;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.TextBox txtSpendingName;
        private System.Windows.Forms.Label lblgideradi;
        private System.Windows.Forms.TextBox txtSpendingID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGiderlerFormu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button btnSpendingForm;
        private System.Windows.Forms.Button btnBillingForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Button btnUpdateSpending;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.DateTimePicker dtpSpendingDate;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.ComboBox cmbSpendingCategory;
        private System.Windows.Forms.Label lblkategori;
    }
}