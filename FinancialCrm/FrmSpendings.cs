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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void SpendingsList()
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingID,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                Categories = x.Categories.CategoryName
            }).ToList();

            dataGridView1.DataSource = values;
        }

        void CategoriesList()
        {
            var categories = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.CategoryName
            }).ToList();

            cmbSpendingCategory.DisplayMember = "CategoryName";
            cmbSpendingCategory.ValueMember = "CategoryID";
            cmbSpendingCategory.DataSource = categories;
        }

        void TextClear()
        {
            txtSpendingID.Clear();
            txtSpendingName.Clear();
            txtSpendingAmount.Clear();
            dtpSpendingDate.Text = "";
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            btnCategoryForm.Text = Localization.btnCategoryForm;
            btnBanksForm.Text = Localization.btnBanksForm;
            btnBillingForm.Text = Localization.btnBillingForm;
            btnSpendingForm.Text = Localization.btnSpendingForm;
            btnBankProcessForm.Text = Localization.btnBankProcessForm;
            btnSettingsForm.Text = Localization.btnSettingsForm;
            btnExit.Text = Localization.btnExit;
            lblGiderlerFormu.Text = Localization.lblGiderlerFormu;
            lblgideradi.Text = Localization.lblgideradi;
            lblmiktar.Text = Localization.lblmiktar;
            lbltarih.Text = Localization.lbltarih;
            lblkategori.Text = Localization.lblkategori;

            SpendingsList();
            CategoriesList();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpendings fr = new FrmSpendings();
            fr.Show();
            this.Hide();
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            SpendingsList();
            CategoriesList();
        }

        private void btnAddSpending_Click(object sender, EventArgs e)
        {
            if (txtSpendingName.Text == "" || txtSpendingAmount.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string spendingName = txtSpendingName.Text;
                decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
                DateTime spendingDate = DateTime.Parse(dtpSpendingDate.Text);
                int categoryID = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

                Spendings spendings = new Spendings();

                spendings.SpendingTitle = spendingName;
                spendings.SpendingAmount = spendingAmount;
                spendings.SpendingDate = spendingDate;
                spendings.CategoryID = categoryID;

                db.Spendings.Add(spendings);
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.eklendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                SpendingsList();
                CategoriesList();
                TextClear();
            }       
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            if (txtSpendingID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.silmedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegersil), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(txtSpendingID.Text);
                    var deleteSpending = db.Spendings.Find(id);
                    db.Spendings.Remove(deleteSpending);
                    db.SaveChanges();

                    MessageBox.Show(String.Format(Localization.silindi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SpendingsList();
                    CategoriesList();
                    TextClear();
                }
            }      
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            if (txtSpendingID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.guncellemedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegerguncelle), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string spendingName = txtSpendingName.Text;
                    decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
                    DateTime spendingDate = DateTime.Parse(dtpSpendingDate.Text);
                    int categoryID = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

                    int id = int.Parse(txtSpendingID.Text);
                    var updateSpending = db.Spendings.Find(id);

                    updateSpending.SpendingTitle = spendingName;
                    updateSpending.SpendingAmount = spendingAmount;
                    updateSpending.SpendingDate = spendingDate;
                    updateSpending.CategoryID = categoryID;

                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.guncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SpendingsList();
                    CategoriesList();
                    TextClear();
                }
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
                txtSpendingID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSpendingName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSpendingAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpSpendingDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbSpendingCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
