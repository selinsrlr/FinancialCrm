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
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView3.DataSource = values;
        }

        private void btnBillAdd_Click(object sender, EventArgs e)
        {
            string title = txtCategoryTitle.Text;

            Categories categories = new Categories();
            categories.CategoryName = title;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi!");

            var values = db.Categories.ToList();
            dataGridView3.DataSource = values;
        }

        private void btnBillDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Kategori Başarılı Bir Şekilde Silindi!", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView3.DataSource = values;
        }

        private void btnBillUpdate_Click(object sender, EventArgs e)
        {
            string title = txtCategoryTitle.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categories.Find(id);

            values.CategoryName = title;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi!");

            var values2 = db.Categories.ToList();
            dataGridView3.DataSource = values2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategories frm = new FrmCategories();
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

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSpendings frm = new FrmSpendings();
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

        private void button8_Click(object sender, EventArgs e)
        {
            FrmBankProcesses frm = new FrmBankProcesses();
            frm.Show();
            this.Hide();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {

        }
    }
}
