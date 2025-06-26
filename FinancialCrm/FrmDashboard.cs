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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessID).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastProcessAmount.Text = lastProcessAmount.ToString() + " ₺";

            //Chart1 Kodları



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count % 4 == 1)
            {
                var bill1 = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillsTitle.Text = "Elektrik Faturası";
                lblBillsAmount.Text = bill1.ToString() + " ₺";
            }
            if (count % 4 == 2)
            {
                var bill2 = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillsTitle.Text = "Doğalgaz Faturası";
                lblBillsAmount.Text = bill2.ToString() + " ₺";
            }
            if (count % 4 == 3)
            {
                var bill3 = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillsTitle.Text = "Su Faturası";
                lblBillsAmount.Text = bill3.ToString() + " ₺";
            }
            if (count % 4 == 0)
            {
                var bill4 = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillsTitle.Text = "İnternet Faturası";
                lblBillsAmount.Text = bill4.ToString() + " ₺";
            }
        }
    }
}
