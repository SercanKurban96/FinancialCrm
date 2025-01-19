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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void CategoriesList()
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.CategoryName
            }).ToList();
            dataGridView1.DataSource = values;
        }

        void TextClear()
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            CategoriesList();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            btnCategoryForm.Text = Localization.btnCategoryForm;
            btnBanksForm.Text = Localization.btnBanksForm;
            btnBillingForm.Text = Localization.btnBillingForm;
            btnSpendingForm.Text = Localization.btnSpendingForm;
            btnBankProcessForm.Text = Localization.btnBankProcessForm;
            btnSettingsForm.Text = Localization.btnSettingsForm;
            btnExit.Text = Localization.btnExit;
            lblCategoryName.Text = Localization.lblCategoryName;
            lblkategoriformu.Text = Localization.lblkategoriformu;

            CategoriesList();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string categoryName = txtCategoryName.Text;

                Categories categories = new Categories();

                categories.CategoryName = categoryName;

                db.Categories.Add(categories);
                db.SaveChanges();

                MessageBox.Show(String.Format(Localization.eklendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CategoriesList();
                TextClear();
                txtCategoryName.Focus();
            }         
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.silmedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegersil), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(txtCategoryID.Text);
                    var deleteCategory = db.Categories.Find(id);

                    db.Categories.Remove(deleteCategory);
                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.silindi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CategoriesList();
                    TextClear();
                    txtCategoryName.Focus();
                }         
            }        
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.guncellemedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegerguncelle), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string categoryName = txtCategoryName.Text;

                    int id = int.Parse(txtCategoryID.Text);
                    var updateCategory = db.Categories.Find(id);

                    updateCategory.CategoryName = categoryName;

                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.guncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CategoriesList();
                    TextClear();
                    txtCategoryName.Focus();
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
                txtCategoryID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCategoryName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
