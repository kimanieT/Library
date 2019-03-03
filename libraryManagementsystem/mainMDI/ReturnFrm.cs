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
    public partial class ReturnFrm : Form
    {
        public ReturnFrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBookNumber.Text == "")
            {
                if(cobBookTitle.Text == "")
                {
                    MessageBox.Show("Please enter book title", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Please enter book number","Incomplete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtBookNumber.Focus();
            }
        }
    }
}
