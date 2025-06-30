using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView2.DataSource = values;
        }

        private void btnSpendingAdd_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime period = DateTime.Parse(txtSpendingPeriod.Text);

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = title;
            spendings.SpendingAmount = amount;
            spendings.SpendingDate = period;
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Sisteme Eklendi!");

            var values = db.Spendings.ToList();
            dataGridView2.DataSource = values;
        }

        private void btnSpendingDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Harcama Başarılı Bir Şekilde Silindi!", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView2.DataSource = values;
        }

        private void btnSpendingUpdate_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime period = DateTime.Parse(txtSpendingPeriod.Text);
            int id = int.Parse(txtSpendingId.Text);

            var values = db.Spendings.Find(id);


            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = period;
            db.SaveChanges();
            MessageBox.Show("Harcama Başarılı Bir Şekilde Güncellendi!");

            var values2 = db.Spendings.ToList();
            dataGridView2.DataSource = values2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
            frm.Show();
            this.Hide();    
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();  
            frm.Show(); 
            this.Hide();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBills frm = new FrmBills();  
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();  
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }
    }
}
