using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScrapingWrapper;

namespace OnlineStoreScrappper
{
    public partial class frmMain : Form
    {
        private WrapperBase scraper = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            scraper = new WrapperBase((int)(double.Parse(txtInterval.Text) * 60000));
            scraper.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            if(scraper != null)
                scraper.Stop();
        }
    }
}
