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
    public partial class Dishdescriptions : UserControl
    {
        public Dishdescriptions()
        {
            InitializeComponent();
        }

        #region Properties
        private string _naam;

        [Category("Custom Props")]
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        #endregion

        private void Dishdescriptions_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dish_descriptions_TextChanged(object sender, EventArgs e)
        {

        }

        private void dish_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
