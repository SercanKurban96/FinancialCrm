namespace FinancialCrm
{
    partial class FrmBankProcesses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankProcesses));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteBankProcess = new System.Windows.Forms.Button();
            this.btnAddBankProcess = new System.Windows.Forms.Button();
            this.btnBankProcessList = new System.Windows.Forms.Button();
            this.lblaciklama = new System.Windows.Forms.Label();
            this.txtBankProcessID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblbankahareketleriformu = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettingsForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.btnBankProcessForm = new System.Windows.Forms.Button();
            this.btnSpendingForm = new System.Windows.Forms.Button();
            this.btnBillingForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoryForm = new System.Windows.Forms.Button();
            this.btnUpdateBankProcess = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltarih = new System.Windows.Forms.Label();
            this.dtpBankProcessDate = new System.Windows.Forms.DateTimePicker();
            this.rtbBankProcessDescription = new System.Windows.Forms.RichTextBox();
            this.lbltur = new System.Windows.Forms.Label();
            this.cmbBankProcessType = new System.Windows.Forms.ComboBox();
            this.txtBankProcessAmount = new System.Windows.Forms.TextBox();
            this.lblmiktar = new System.Windows.Forms.Label();
            this.cmbBankID = new System.Windows.Forms.ComboBox();
            this.lblbanka = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(985, 239);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDeleteBankProcess
            // 
            this.btnDeleteBankProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteBankProcess.BackgroundImage")));
            this.btnDeleteBankProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteBankProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteBankProcess.Location = new System.Drawing.Point(838, 237);
            this.btnDeleteBankProcess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeleteBankProcess.Name = "btnDeleteBankProcess";
            this.btnDeleteBankProcess.Size = new System.Drawing.Size(110, 73);
            this.btnDeleteBankProcess.TabIndex = 7;
            this.btnDeleteBankProcess.UseVisualStyleBackColor = true;
            this.btnDeleteBankProcess.Click += new System.EventHandler(this.btnDeleteBankProcess_Click);
            // 
            // btnAddBankProcess
            // 
            this.btnAddBankProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddBankProcess.BackgroundImage")));
            this.btnAddBankProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddBankProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnAddBankProcess.Location = new System.Drawing.Point(1005, 144);
            this.btnAddBankProcess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddBankProcess.Name = "btnAddBankProcess";
            this.btnAddBankProcess.Size = new System.Drawing.Size(110, 73);
            this.btnAddBankProcess.TabIndex = 6;
            this.btnAddBankProcess.UseVisualStyleBackColor = true;
            this.btnAddBankProcess.Click += new System.EventHandler(this.btnAddBankProcess_Click);
            // 
            // btnBankProcessList
            // 
            this.btnBankProcessList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBankProcessList.BackgroundImage")));
            this.btnBankProcessList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBankProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessList.ForeColor = System.Drawing.Color.Black;
            this.btnBankProcessList.Location = new System.Drawing.Point(838, 144);
            this.btnBankProcessList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBankProcessList.Name = "btnBankProcessList";
            this.btnBankProcessList.Size = new System.Drawing.Size(110, 73);
            this.btnBankProcessList.TabIndex = 5;
            this.btnBankProcessList.UseVisualStyleBackColor = true;
            this.btnBankProcessList.Click += new System.EventHandler(this.btnBankProcessList_Click);
            // 
            // lblaciklama
            // 
            this.lblaciklama.Location = new System.Drawing.Point(256, 121);
            this.lblaciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblaciklama.Name = "lblaciklama";
            this.lblaciklama.Size = new System.Drawing.Size(123, 24);
            this.lblaciklama.TabIndex = 36;
            this.lblaciklama.Text = "Açıklama:";
            this.lblaciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBankProcessID
            // 
            this.txtBankProcessID.BackColor = System.Drawing.Color.White;
            this.txtBankProcessID.Location = new System.Drawing.Point(380, 81);
            this.txtBankProcessID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBankProcessID.Name = "txtBankProcessID";
            this.txtBankProcessID.Size = new System.Drawing.Size(345, 32);
            this.txtBankProcessID.TabIndex = 35;
            this.txtBankProcessID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hareket ID:";
            this.label2.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(227)))));
            this.panel2.Controls.Add(this.lblbankahareketleriformu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 54);
            this.panel2.TabIndex = 33;
            // 
            // lblbankahareketleriformu
            // 
            this.lblbankahareketleriformu.AutoSize = true;
            this.lblbankahareketleriformu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbankahareketleriformu.ForeColor = System.Drawing.Color.White;
            this.lblbankahareketleriformu.Location = new System.Drawing.Point(10, 13);
            this.lblbankahareketleriformu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbankahareketleriformu.Name = "lblbankahareketleriformu";
            this.lblbankahareketleriformu.Size = new System.Drawing.Size(219, 24);
            this.lblbankahareketleriformu.TabIndex = 2;
            this.lblbankahareketleriformu.Text = "Banka Hareketleri Formu";
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
            this.btnExit.TabIndex = 16;
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
            this.btnSettingsForm.TabIndex = 15;
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
            this.btnDashboardForm.TabIndex = 14;
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
            this.btnBankProcessForm.TabIndex = 13;
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
            this.btnSpendingForm.TabIndex = 12;
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
            this.btnBillingForm.TabIndex = 11;
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
            this.btnBanksForm.TabIndex = 10;
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
            this.btnCategoryForm.TabIndex = 9;
            this.btnCategoryForm.Text = "Kategoriler";
            this.btnCategoryForm.UseVisualStyleBackColor = true;
            this.btnCategoryForm.Click += new System.EventHandler(this.btnCategoryForm_Click);
            // 
            // btnUpdateBankProcess
            // 
            this.btnUpdateBankProcess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateBankProcess.BackgroundImage")));
            this.btnUpdateBankProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateBankProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateBankProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBankProcess.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateBankProcess.Location = new System.Drawing.Point(1005, 237);
            this.btnUpdateBankProcess.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdateBankProcess.Name = "btnUpdateBankProcess";
            this.btnUpdateBankProcess.Size = new System.Drawing.Size(110, 73);
            this.btnUpdateBankProcess.TabIndex = 8;
            this.btnUpdateBankProcess.UseVisualStyleBackColor = true;
            this.btnUpdateBankProcess.Click += new System.EventHandler(this.btnUpdateBankProcess_Click);
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
            this.panel1.Location = new System.Drawing.Point(-1, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 603);
            this.panel1.TabIndex = 32;
            // 
            // lbltarih
            // 
            this.lbltarih.Location = new System.Drawing.Point(290, 225);
            this.lbltarih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(89, 24);
            this.lbltarih.TabIndex = 43;
            this.lbltarih.Text = "Tarih:";
            this.lbltarih.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBankProcessDate
            // 
            this.dtpBankProcessDate.Location = new System.Drawing.Point(393, 223);
            this.dtpBankProcessDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpBankProcessDate.Name = "dtpBankProcessDate";
            this.dtpBankProcessDate.Size = new System.Drawing.Size(372, 32);
            this.dtpBankProcessDate.TabIndex = 1;
            // 
            // rtbBankProcessDescription
            // 
            this.rtbBankProcessDescription.Location = new System.Drawing.Point(393, 121);
            this.rtbBankProcessDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbBankProcessDescription.Name = "rtbBankProcessDescription";
            this.rtbBankProcessDescription.Size = new System.Drawing.Size(372, 96);
            this.rtbBankProcessDescription.TabIndex = 0;
            this.rtbBankProcessDescription.Text = "";
            // 
            // lbltur
            // 
            this.lbltur.Location = new System.Drawing.Point(304, 262);
            this.lbltur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltur.Name = "lbltur";
            this.lbltur.Size = new System.Drawing.Size(75, 24);
            this.lbltur.TabIndex = 45;
            this.lbltur.Text = "Tür:";
            this.lbltur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBankProcessType
            // 
            this.cmbBankProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankProcessType.FormattingEnabled = true;
            this.cmbBankProcessType.Items.AddRange(new object[] {
            "Gelen Havale",
            "Giden Havale"});
            this.cmbBankProcessType.Location = new System.Drawing.Point(393, 259);
            this.cmbBankProcessType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbBankProcessType.Name = "cmbBankProcessType";
            this.cmbBankProcessType.Size = new System.Drawing.Size(372, 32);
            this.cmbBankProcessType.TabIndex = 2;
            // 
            // txtBankProcessAmount
            // 
            this.txtBankProcessAmount.BackColor = System.Drawing.Color.White;
            this.txtBankProcessAmount.Location = new System.Drawing.Point(392, 297);
            this.txtBankProcessAmount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBankProcessAmount.Name = "txtBankProcessAmount";
            this.txtBankProcessAmount.Size = new System.Drawing.Size(373, 32);
            this.txtBankProcessAmount.TabIndex = 3;
            // 
            // lblmiktar
            // 
            this.lblmiktar.Location = new System.Drawing.Point(276, 300);
            this.lblmiktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmiktar.Name = "lblmiktar";
            this.lblmiktar.Size = new System.Drawing.Size(103, 24);
            this.lblmiktar.TabIndex = 47;
            this.lblmiktar.Text = "Miktar:";
            this.lblmiktar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbBankID
            // 
            this.cmbBankID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankID.FormattingEnabled = true;
            this.cmbBankID.Location = new System.Drawing.Point(392, 333);
            this.cmbBankID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbBankID.Name = "cmbBankID";
            this.cmbBankID.Size = new System.Drawing.Size(372, 32);
            this.cmbBankID.TabIndex = 4;
            // 
            // lblbanka
            // 
            this.lblbanka.Location = new System.Drawing.Point(280, 336);
            this.lblbanka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblbanka.Name = "lblbanka";
            this.lblbanka.Size = new System.Drawing.Size(99, 24);
            this.lblbanka.TabIndex = 49;
            this.lblbanka.Text = "Banka:";
            this.lblbanka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 654);
            this.Controls.Add(this.cmbBankID);
            this.Controls.Add(this.lblbanka);
            this.Controls.Add(this.txtBankProcessAmount);
            this.Controls.Add(this.lblmiktar);
            this.Controls.Add(this.cmbBankProcessType);
            this.Controls.Add(this.lbltur);
            this.Controls.Add(this.rtbBankProcessDescription);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.dtpBankProcessDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteBankProcess);
            this.Controls.Add(this.btnAddBankProcess);
            this.Controls.Add(this.btnBankProcessList);
            this.Controls.Add(this.lblaciklama);
            this.Controls.Add(this.txtBankProcessID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnUpdateBankProcess);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcesses";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteBankProcess;
        private System.Windows.Forms.Button btnAddBankProcess;
        private System.Windows.Forms.Button btnBankProcessList;
        private System.Windows.Forms.Label lblaciklama;
        private System.Windows.Forms.TextBox txtBankProcessID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblbankahareketleriformu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettingsForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button btnBankProcessForm;
        private System.Windows.Forms.Button btnSpendingForm;
        private System.Windows.Forms.Button btnBillingForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoryForm;
        private System.Windows.Forms.Button btnUpdateBankProcess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltarih;
        private System.Windows.Forms.DateTimePicker dtpBankProcessDate;
        private System.Windows.Forms.RichTextBox rtbBankProcessDescription;
        private System.Windows.Forms.Label lbltur;
        private System.Windows.Forms.ComboBox cmbBankProcessType;
        private System.Windows.Forms.TextBox txtBankProcessAmount;
        private System.Windows.Forms.Label lblmiktar;
        private System.Windows.Forms.ComboBox cmbBankID;
        private System.Windows.Forms.Label lblbanka;
    }
}