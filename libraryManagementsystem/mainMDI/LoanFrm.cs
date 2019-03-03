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
    public partial class LoanFrm : Form
    {
        public LoanFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cobBookTitle.Text == "")
            {
                MessageBox.Show("Please enter book title","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cobBookTitle.Focus();
            }

            else if (txtBookNumber.Text == "")
            {
                MessageBox.Show("Please enter book number","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBookNumber.Focus();
            }

            else if(txtPersonName.Text == "")
            {
                MessageBox.Show("Please enter borrower name", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonName.Focus();
            }

            else if (txtPersonId.Text == "")
            {
                MessageBox.Show("Please enter borrower id ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPersonId.Focus();
            }

            else if(txtLibarian.Text == "")
            {
                MessageBox.Show("Please enter Libarian name ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLibarian.Focus();
            }

            else if(txtDateIssue.Text == "")
            {
                MessageBox.Show("Please enter date book is being issue ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDateIssue.Focus();
            }

            else if(txtDateToBeReturned.Text == "")
            {
                MessageBox.Show("Please enter date book will be returned ", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDateToBeReturned.Focus();
            }

            else
            {
                MessageBox.Show("Information has been registered succesfully", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
