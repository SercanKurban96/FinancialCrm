namespace FinancialCrm
{
    partial class FrmLanguage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLanguage));
            this.pctTurkish = new System.Windows.Forms.PictureBox();
            this.pctEnglish = new System.Windows.Forms.PictureBox();
            this.rdbTurkish = new System.Windows.Forms.RadioButton();
            this.rdbEnglish = new System.Windows.Forms.RadioButton();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.lblfinancialcrmproje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctTurkish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pctTurkish
            // 
            this.pctTurkish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctTurkish.Image = ((System.Drawing.Image)(resources.GetObject("pctTurkish.Image")));
            this.pctTurkish.Location = new System.Drawing.Point(119, 162);
            this.pctTurkish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctTurkish.Name = "pctTurkish";
            this.pctTurkish.Size = new System.Drawing.Size(188, 130);
            this.pctTurkish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTurkish.TabIndex = 0;
            this.pctTurkish.TabStop = false;
            this.pctTurkish.Click += new System.EventHandler(this.pctTurkish_Click);
            // 
            // pctEnglish
            // 
            this.pctEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctEnglish.Image = ((System.Drawing.Image)(resources.GetObject("pctEnglish.Image")));
            this.pctEnglish.Location = new System.Drawing.Point(417, 162);
            this.pctEnglish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctEnglish.Name = "pctEnglish";
            this.pctEnglish.Size = new System.Drawing.Size(188, 130);
            this.pctEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctEnglish.TabIndex = 1;
            this.pctEnglish.TabStop = false;
            this.pctEnglish.Click += new System.EventHandler(this.pctEnglish_Click);
            // 
            // rdbTurkish
            // 
            this.rdbTurkish.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbTurkish.ForeColor = System.Drawing.Color.White;
            this.rdbTurkish.Location = new System.Drawing.Point(119, 311);
            this.rdbTurkish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbTurkish.Name = "rdbTurkish";
            this.rdbTurkish.Size = new System.Drawing.Size(188, 36);
            this.rdbTurkish.TabIndex = 2;
            this.rdbTurkish.TabStop = true;
            this.rdbTurkish.Text = "TÜRKÇE";
            this.rdbTurkish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbTurkish.UseVisualStyleBackColor = true;
            // 
            // rdbEnglish
            // 
            this.rdbEnglish.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbEnglish.ForeColor = System.Drawing.Color.White;
            this.rdbEnglish.Location = new System.Drawing.Point(417, 311);
            this.rdbEnglish.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rdbEnglish.Name = "rdbEnglish";
            this.rdbEnglish.Size = new System.Drawing.Size(188, 36);
            this.rdbEnglish.TabIndex = 3;
            this.rdbEnglish.TabStop = true;
            this.rdbEnglish.Text = "ENGLISH";
            this.rdbEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbEnglish.UseVisualStyleBackColor = true;
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(672, 4);
            this.pctExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(67, 68);
            this.pctExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctExit.TabIndex = 4;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            this.pctExit.MouseLeave += new System.EventHandler(this.pctExit_MouseLeave);
            this.pctExit.MouseHover += new System.EventHandler(this.pctExit_MouseHover);
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.Transparent;
            this.btnChoose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoose.BackgroundImage")));
            this.btnChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Location = new System.Drawing.Point(649, 424);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(89, 74);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // lblfinancialcrmproje
            // 
            this.lblfinancialcrmproje.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinancialcrmproje.ForeColor = System.Drawing.Color.White;
            this.lblfinancialcrmproje.Location = new System.Drawing.Point(-23, 9);
            this.lblfinancialcrmproje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfinancialcrmproje.Name = "lblfinancialcrmproje";
            this.lblfinancialcrmproje.Size = new System.Drawing.Size(691, 38);
            this.lblfinancialcrmproje.TabIndex = 6;
            this.lblfinancialcrmproje.Text = "                              Financial CRM";
            this.lblfinancialcrmproje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // FrmLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(738, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfinancialcrmproje);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.rdbEnglish);
            this.Controls.Add(this.rdbTurkish);
            this.Controls.Add(this.pctEnglish);
            this.Controls.Add(this.pctTurkish);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLanguage";
            this.Load += new System.EventHandler(this.FrmLanguage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctTurkish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTurkish;
        private System.Windows.Forms.PictureBox pctEnglish;
        private System.Windows.Forms.RadioButton rdbTurkish;
        private System.Windows.Forms.RadioButton rdbEnglish;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lblfinancialcrmproje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}