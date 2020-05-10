using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDelicates
{
    public partial class Introscreen : UserControl
    {
        public Introscreen()
        {
            InitializeComponent();
        }

        private void klant_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void worker_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u het programma wilt aflsuiten?", "Programma afsluiten", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}