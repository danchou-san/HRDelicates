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
    public partial class Menuscreen : UserControl
    {
        const string path = @"Dishes.json";

        public Dishes Dishes { get; set; }

        public Menuscreen()
        {
            InitializeComponent();
        }

        private void Menuscreen_Load(object sender, EventArgs e)
        {
            var serializedStr = File.ReadAllText(path);
            var gerechten = JsonConvert.DeserializeObject<Dishes[]>(serializedStr);

            //foreach(var n in gerechten)
            //{
            //    Console.WriteLine(n.Naam);
            //}

            dataGridView1.DataSource = gerechten;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
