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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                table_header_text.Visible = true;
                table_panel.Visible = true;
                //dataGridView1.Visible = true;

                //personen_box.Value = value;
                
                var serializedStr = File.ReadAllText(path);
                var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);
                //var personen_value = Convert.ToInt32(personen_box.Value);

                DataTable dt = new DataTable();
                //dt.Columns.Add("Nummer");
                //dt.Columns.Add("Capaciteit");

                foreach (var n in tables)
                {
                    var capaciteit = Convert.ToInt32(n.Capaciteit);
                    if (capaciteit >= personen_box.Value && capaciteit <= (personen_box.Value + 2))
                    {
                        DataRow dr = dt.NewRow();
                        //dr["Nummer"] = n.Nummer;
                        //dr["Capaciteit"] = n.Capaciteit;
                        //dt.Rows.Add(dr);

                        //table_combo.Items.Add(d["Nummer"]);
                        table_combo.Items.Add(n.Nummer);
                    }
                }
                //dataGridView1.DataSource = dt;
            }

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
            email_value.Text = email_box.Text;
        }

        private void table_back_Click(object sender, EventArgs e)
        {
            table_panel.Visible = false;

            table_combo.Items.Clear();
        }

        private void confirmation_back_Click(object sender, EventArgs e)
        {
            verification_panel.Visible = false;
            table_panel.Visible = true;
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
            jsonObj[Int32.Parse(table_value.Text) - 1]["Email"] = email_value.Text;
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

        private void naam_box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(naam_box.Text))
            {
                e.Cancel = true;
                naam_box.Focus();
                errorProvider1.SetError(naam_box, "Vul uw voornaam in.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(naam_box, null);
            }

        }

        private void achternaam_box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(achternaam_box.Text))
            {
                e.Cancel = true;
                achternaam_box.Focus();
                errorProvider1.SetError(achternaam_box, "Vul uw achternaam in.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(achternaam_box, null);
            }
        }

        private void telefoon_Box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(telefoon_Box.Text))
            {
                e.Cancel = true;
                telefoon_Box.Focus();
                errorProvider1.SetError(telefoon_Box, "Vul uw telefoonnummer in.");
            }
            else if (telefoon_Box.Text.ToLower().IndexOf('s') != -1)
            {
                e.Cancel = true;
                telefoon_Box.Focus();
                errorProvider1.SetError(telefoon_Box, "Vul een geldige telefoonnummer in.");
            }
            else if (!telefoon_Box.Text.StartsWith("06") && (!telefoon_Box.Text.StartsWith("010")))
            {
                e.Cancel = true;
                telefoon_Box.Focus();
                errorProvider1.SetError(telefoon_Box, "Vul een geldige telefoonnummer in.");
            }
            else if (telefoon_Box.Text.Length != 10)
            {
                e.Cancel = true;
                telefoon_Box.Focus();
                errorProvider1.SetError(telefoon_Box, "Vul een geldige telefoonnummer in.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(telefoon_Box, null);
            }
        }

        private void email_box_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(email_box.Text))
            {
                e.Cancel = true;
                email_box.Focus();
                errorProvider1.SetError(email_box, "Vul uw email in.");
            }
            else if(!email_box.Text.Contains("@") || (!email_box.Text.EndsWith(".com")))
            {
                e.Cancel = true;
                email_box.Focus();
                errorProvider1.SetError(email_box, "Vul een geldige email in.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(email_box, null);
                }
            }

        private void finish_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
