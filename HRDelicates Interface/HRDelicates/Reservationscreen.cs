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
    public partial class Reservationscreen : UserControl
    {
        const string path = @"Tables.json";

        public Tables Tables { get; set; }

        public Reservationscreen()
        {
            InitializeComponent();
        }

        private void Reservationscreen_Load(object sender, EventArgs e)
        {
            
        }

        private void verder_button_Click(object sender, EventArgs e)
        {
            //personen_box.Value = value;
            var serializedStr = File.ReadAllText(path);
            var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);
            //var personen_value = Convert.ToInt32(personen_box.Value);

            DataTable dt = new DataTable();
            dt.Columns.Add("Nummer");
            dt.Columns.Add("Capaciteit");

            foreach (var n in tables)
            {
                var capaciteit = Convert.ToInt32(n.Capaciteit);
                if (n.Status == "Available" && capaciteit >= personen_box.Value)
                {
                    DataRow dr = dt.NewRow();
                    dr["Nummer"] = n.Nummer;
                    dr["Capaciteit"] = n.Capaciteit;
                    dt.Rows.Add(dr);

                    table_header_text.Visible = true;
                    table_panel.Visible = true;
                    dataGridView1.Visible = true;

                    table_combo.Items.Add(dr["Nummer"]);
                }
            }
            dataGridView1.DataSource = dt;
            
        }

        private void table_next_Click(object sender, EventArgs e)
        {
            confirmation_title.Visible = true;
            verification_panel.Visible = true;
            name_value.Text = naam_box.Text + " " + achternaam_box.Text;
            table_value.Text = table_combo.Text;
            date_value.Text = datum_box.Value.ToString("dd-MM-yyyy");
            time_value.Text = time_box.Text;
            phone_value.Text = telefoon_Box.Text;
        }

        private void table_back_Click(object sender, EventArgs e)
        {
            table_panel.Visible = false;

            table_combo.Items.Clear();
        }

        private void confirmation_back_Click(object sender, EventArgs e)
        {
            verification_panel.Visible = false;
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            //var serializedStr = File.ReadAllText(path);
            //var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);

            //foreach (var n in tables)
            //{
            //    if (n.Nummer == table_value.Text)
            //    {
            //        n.Persoon = name_value.Text;
            //        n.D_reservering = date_value.Text;
            //        n.Time = time_value.Text;
            //    }
            //}

            string json = File.ReadAllText(path);
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
            jsonObj[Int32.Parse(table_value.Text) - 1]["Persoon"] = name_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["D_reservering"] = date_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Time"] = time_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Telefoon"] = phone_value.Text;

            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(path, output);

            finish_panel.Visible = true;
            finish_text.Visible = true;
        }

        private void back_begin_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void name_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void verification_screen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phone_label_Click(object sender, EventArgs e)
        {

        }

        private void time_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void phone_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_label_Click(object sender, EventArgs e)
        {

        }
    }
}
