using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                MessageBox.Show(String.Format(Localization.girisbasarili), String.Format(Localization.hosgeldiniz), MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmDashboard fr = new FrmDashboard();
                fr.Show();
                this.Hide();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(String.Format(Localization.girisbasarisiz), String.Format(Localization.hata), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblfinancialcrmproje.Text = Localization.lblfinancialcrmproje;
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
            lblcrm.Text = Localization.lblcrm + " ~ " + DateTime.Now.Year.ToString();  
        }
    }
}
