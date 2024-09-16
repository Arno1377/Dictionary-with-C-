using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class frmedit : Form
    {
        Form1 frm1;
        public frmedit()
        {
            InitializeComponent();
        }
        public frmedit(Form1 x)
        {
            frm1 = x;
            InitializeComponent();
            txtenglishword.Text = x.getenglishword();
            txtfarsiword.Text = x.getfarsiword();
        }

        private void frmedit_Load(object sender, EventArgs e)
        {

        }

        private void btnapply_Click(object sender, EventArgs e)
        {
            frm1.d1.editrec(txtfarsiword.Text, txtenglishword.Text);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
