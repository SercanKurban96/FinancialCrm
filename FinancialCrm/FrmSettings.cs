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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            btnCategoryForm.Text = Localization.btnCategoryForm;
            btnBanksForm.Text = Localization.btnBanksForm;
            btnBillingForm.Text = Localization.btnBillingForm;
            btnSpendingForm.Text = Localization.btnSpendingForm;
            btnBankProcessForm.Text = Localization.btnBankProcessForm;
            btnSettingsForm.Text = Localization.btnSettingsForm;
            btnExit.Text = Localization.btnExit;
            cmbShowHide1.Text = Localization.cmbShowHide1;

            var user = db.Users.Select(x => new
            {
                x.UserID,
                x.Username,
                x.Password,
            }).ToList();
            dataGridView1.DataSource = user;
        }

        private void cmbShowHide1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUserID.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(String.Format(Localization.guncellemedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                int id = int.Parse(txtUserID.Text);

                var updateUser = db.Users.Find(id);

                updateUser.Username = username;
                updateUser.Password = password;

                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.guncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Clear();
                txtUserID.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories fr = new FrmCategories();
            fr.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks fr = new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling fr = new FrmBilling();
            fr.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings fr = new FrmSpendings();
            fr.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses fr = new FrmBankProcesses();
            fr.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard fr = new FrmDashboard();
            fr.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings fr = new FrmSettings();
            fr.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show(String.Format(Localization.programdancikma), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtUsername.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
