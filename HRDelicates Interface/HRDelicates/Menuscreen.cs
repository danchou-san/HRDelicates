﻿using System;
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
            //    var serializedStr = File.ReadAllText(path);
            //    var gerechten = JsonConvert.DeserializeObject<Dishes[]>(serializedStr);

            ////foreach(var n in gerechten)
            ////{
            ////    Console.WriteLine(n.Naam);
            ////}

            //dataGridView1.DataSource = gerechten;

            //    Dishes[] listItems = new Dishes[15];

            //    for (int i = 0; i < listItems.Length; i++)
            //    {
            //        listItems[i] = new Dishes();
            //        listItems[i].Naam = "Get Data";

            //        //flowLayoutPanel1.Controls.Clear();
            //        flowLayoutPanel1.Controls.Add(listItems[i]);
            //    }
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

        private void dishdescriptions11_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dishdescriptions5_Load(object sender, EventArgs e)
        {
                    }

        private void finish_text_Click(object sender, EventArgs e)
        {

        }

        private void dishdescriptions8_Load(object sender, EventArgs e)
        {
                    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            terug_admin.BackColor = SystemColors.Control;
            terug_admin.ForeColor = SystemColors.ButtonShadow;
            button1.BackColor = Color.FromArgb(207, 2, 69);
            button1.ForeColor = Color.White;
            flowLayoutPanel1.Visible = false;
            DrankenPanel.Visible = true;           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void terug_admin_Click(object sender, EventArgs e)
        {
            terug_admin.BackColor = Color.FromArgb(207, 2, 69);
            terug_admin.ForeColor = Color.White;
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.ButtonShadow;
            flowLayoutPanel1.Visible = true;
            DrankenPanel.Visible = false;
        }
    }
}
