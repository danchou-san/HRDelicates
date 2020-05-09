using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace HRDelicates
{
    public partial class Adminscreen : UserControl
    {

        const string path = @"Tables.json";

        public Tables Tables { get; set; }

        public Adminscreen()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Adminscreen_Load(object sender, EventArgs e)
        {
            var serializedStr = File.ReadAllText(path);
            var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);

            dataGridView1.DataSource = tables;
        }
    }
}
