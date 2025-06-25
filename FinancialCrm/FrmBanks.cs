using FinancialCrm.Models;
using System;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities(); 
        private void FrmBanks_Load(object sender, EventArgs e)
        {

        }
    }
}
