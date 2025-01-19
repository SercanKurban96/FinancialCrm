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
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void BankProcessesList()
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessID,
                x.Description,
                x.ProcessDate,
                x.ProcessType,
                x.Amount,
                Banks = x.Banks.BankTitle
            }).ToList();

            dataGridView1.DataSource = values;
        }

        void BanksList()
        {
            var banks = db.Banks.Select(x => new
            {
                x.BankID,
                x.BankTitle
            }).ToList();

            cmbBankID.DisplayMember = "BankTitle";
            cmbBankID.ValueMember = "BankID";
            cmbBankID.DataSource = banks;
        }

        void TextClear()
        {
            txtBankProcessAmount.Clear();
            rtbBankProcessDescription.Clear();
        }
        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            btnCategoryForm.Text = Localization.btnCategoryForm;
            btnBanksForm.Text = Localization.btnBanksForm;
            btnBillingForm.Text = Localization.btnBillingForm;
            btnSpendingForm.Text = Localization.btnSpendingForm;
            btnBankProcessForm.Text = Localization.btnBankProcessForm;
            btnSettingsForm.Text = Localization.btnSettingsForm;
            btnExit.Text = Localization.btnExit;
            lblbankahareketleriformu.Text = Localization.lblbankahareketleriformu;
            lblmiktar.Text = Localization.lblmiktar;
            lbltarih.Text = Localization.lbltarih;
            lbltur.Text = Localization.lbltur;
            lblbanka.Text = Localization.lblbanka;
            lblaciklama.Text = Localization.lblaciklama;

            cmbBankProcessType.Text = "Gelen Havale";
            BankProcessesList();
            BanksList();
            rtbBankProcessDescription.Focus();
        }

        private void btnBankProcessList_Click(object sender, EventArgs e)
        {
            cmbBankProcessType.Text = "Gelen Havale";
            BankProcessesList();
            BanksList();
            rtbBankProcessDescription.Focus();
        }

        private void btnAddBankProcess_Click(object sender, EventArgs e)
        {
            if (rtbBankProcessDescription.Text == "" || txtBankProcessAmount.Text == "")
            {
                MessageBox.Show(String.Format(Localization.alanlarbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string description = rtbBankProcessDescription.Text;
                DateTime processDate = DateTime.Parse(dtpBankProcessDate.Text);
                string processType = cmbBankProcessType.Text;
                decimal amount = decimal.Parse(txtBankProcessAmount.Text);
                int bankID = int.Parse(cmbBankID.SelectedValue.ToString());

                BankProcesses bankProcesses = new BankProcesses();

                bankProcesses.Description = description;
                bankProcesses.ProcessDate = processDate;
                bankProcesses.ProcessType = processType;
                bankProcesses.Amount = amount;
                bankProcesses.BankID = bankID;

                db.BankProcesses.Add(bankProcesses);
                db.SaveChanges();
                MessageBox.Show(String.Format(Localization.eklendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                BankProcessesList();
                BanksList();
                TextClear();
                rtbBankProcessDescription.Focus();
            }            
        }

        private void btnDeleteBankProcess_Click(object sender, EventArgs e)
        {
            if (txtBankProcessID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.silmedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegersil), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = int.Parse(txtBankProcessID.Text);
                    var deleteProcess = db.BankProcesses.Find(id);
                    db.BankProcesses.Remove(deleteProcess);
                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.silindi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BankProcessesList();
                    BanksList();
                    TextClear();
                    rtbBankProcessDescription.Focus();
                }
            }    
        }

        private void btnUpdateBankProcess_Click(object sender, EventArgs e)
        {
            if (txtBankProcessID.Text == "")
            {
                MessageBox.Show(String.Format(Localization.guncellemedegerbos), String.Format(Localization.uyari), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show(String.Format(Localization.secilendegerguncelle), String.Format(Localization.uyari), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string description = rtbBankProcessDescription.Text;
                    DateTime processDate = DateTime.Parse(dtpBankProcessDate.Text);
                    string processType = cmbBankProcessType.Text;
                    decimal amount = decimal.Parse(txtBankProcessAmount.Text);
                    int bankID = int.Parse(cmbBankID.SelectedValue.ToString());

                    int id = int.Parse(txtBankProcessID.Text);
                    var updateProcess = db.BankProcesses.Find(id);

                    updateProcess.Description = description;
                    updateProcess.ProcessDate = processDate;
                    updateProcess.ProcessType = processType;
                    updateProcess.Amount = amount;
                    updateProcess.BankID = bankID;

                    db.SaveChanges();
                    MessageBox.Show(String.Format(Localization.guncellendi), String.Format(Localization.bilgi), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BankProcessesList();
                    BanksList();
                    TextClear();
                    rtbBankProcessDescription.Focus();
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
                txtBankProcessID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                rtbBankProcessDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                dtpBankProcessDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbBankProcessType.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBankProcessAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbBankID.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
