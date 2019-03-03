using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainMDI
{
    public partial class MainMDI : Form
    {
        public MainMDI()
        {
            InitializeComponent();
        }

        private void loanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanFrm loanFrm = new LoanFrm();
            loanFrm.MdiParent = this;
            loanFrm.Show();           
        }

        private void viewToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RecordFrm recordFrm = new RecordFrm();
            recordFrm.MdiParent = this;
            recordFrm.Show();
        }
    }
}
