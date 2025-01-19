using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLanguage : Form
    {
        public FrmLanguage()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (rdbTurkish.Checked)
            {
                Localization.Culture = new CultureInfo("");
            }
            else if (rdbEnglish.Checked)
            {
                Localization.Culture = new CultureInfo("en-US");
            }
            FrmLogin fr = new FrmLogin();
            fr.Show();
            this.Hide();
        }

        private void FrmLanguage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            rdbTurkish.Checked = true;
        }

        private void pctTurkish_Click(object sender, EventArgs e)
        {
            rdbTurkish.Checked = true;
        }

        private void pctEnglish_Click(object sender, EventArgs e)
        {
            rdbEnglish.Checked = true;
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctExit_MouseHover(object sender, EventArgs e)
        {
            pctExit.BackColor = Color.Red;
        }

        private void pctExit_MouseLeave(object sender, EventArgs e)
        {
            pctExit.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int num = int.Parse(label2.Text);
            num++;
            label2.Text = num.ToString();

            if (num == 20)
            {
                lblfinancialcrmproje.ForeColor = Color.Red;
            }
            if (num == 40)
            {
                lblfinancialcrmproje.ForeColor = Color.Black;
            }
            if (num == 60)
            {
                lblfinancialcrmproje.ForeColor = Color.Yellow;
            }
            if (num == 80)
            {
                lblfinancialcrmproje.ForeColor = Color.Cyan;
            }
            if (num == 100)
            {
                lblfinancialcrmproje.ForeColor = Color.LightGreen;
            }
            if (num == 120)
            {
                num = 0;
                label2.Text = num.ToString();
                lblfinancialcrmproje.ForeColor = Color.White;
            }

            lblfinancialcrmproje.Text = lblfinancialcrmproje.Text.Substring(1) + lblfinancialcrmproje.Text.Substring(0, 1);
        }
    }
}
