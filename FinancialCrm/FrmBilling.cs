﻿using System;
using System.Linq;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void TextClear()
        {
            txtBillID.Clear();
            txtBillTitle.Clear();
            txtBillAmount.Clear();
            txtBillPeriod.Clear();
        }
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            btnCategoryForm.Text = Localization.btnCategoryForm;
            btnBanksForm.Text = Localization.btnBanksForm;
            btnBillingForm.Text = Localization.btnBillingForm;
            btnSpendingForm.Text = Localization.btnSpendingForm;
            btnBankProcessForm.Text = Localization.btnBankProcessForm;
            btnSettingsForm.Text = Localization.btnSettingsForm;
            btnExit.Text = Localization.btnExit;
            lblFaturaFormu.Text = Localization.lblFaturaFormu;
            lblfaturabaslik.Text = Localization.lblfaturabaslik;
            lblfaturamiktar.Text = Localization.lblfaturamiktar;
            lblfaturaperiyot.Text = Localization.lblfaturaperiyot;


            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            txtBillTitle.Focus();
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            txtBillTitle.Focus();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            if (txtBillTitle.Text == "" || txtBillAmount.Text == "" || txtBillPeriod.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string title = txtBillTitle.Text;
                decimal amount = decimal.Parse(txtBillAmount.Text);
                string period = txtBillPeriod.Text;

                Bills bills = new Bills();

                bills.BillTitle = title;
                bills.BillAmount = amount;
                bills.BillPeriod = period;

                db.Bills.Add(bills);
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.eklendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;

                TextClear();
                txtBillTitle.Focus();
            }       
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.silmedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegersil), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(txtBillID.Text);
                    var removeValue = db.Bills.Find(id);
                    db.Bills.Remove(removeValue);
                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.silindi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var values = db.Bills.ToList();
                    dataGridView1.DataSource = values;

                    TextClear();
                    txtBillTitle.Focus();
                }
            }           
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            if (txtBillID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.guncellemedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegerguncelle), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string title = txtBillTitle.Text;
                    decimal amount = decimal.Parse(txtBillAmount.Text);
                    string period = txtBillPeriod.Text;

                    int id = int.Parse(txtBillID.Text);
                    var values = db.Bills.Find(id);

                    values.BillTitle = title;
                    values.BillAmount = amount;
                    values.BillPeriod = period;

                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.guncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var values2 = db.Bills.ToList();
                    dataGridView1.DataSource = values2;

                    TextClear();
                    txtBillTitle.Focus();
                }
            }         
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks fr = new FrmBanks();
            fr.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategories fr = new FrmCategories();
            fr.Show();
            this.Hide();
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling fr = new FrmBilling();
            fr.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard fr = new FrmDashboard();
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

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings fr = new FrmSpendings();
            fr.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses fr = new FrmBankProcesses();
            fr.Show();
            this.Hide();
        }

        private void btnSettingsForm_Click(object sender, EventArgs e)
        {
            FrmSettings fr = new FrmSettings();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtBillID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBillTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtBillAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBillPeriod.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
