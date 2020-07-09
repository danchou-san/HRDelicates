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
using System.Net;
using System.Net.Mail;

namespace HRDelicates
{
    public partial class Reservationscreen : UserControl
    {
        const string path = @"Tables.json";
        bool able_table = false;

        public Tables Tables { get; set; }

        public Reservationscreen()
        {
            InitializeComponent();
        }

        private void Reservationscreen_Load(object sender, EventArgs e)
        {
            datum_box.Value = DateTime.Today;
            datum_box.MinDate = DateTime.Today;
        }

        private void table1_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "1";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table2_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "2";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table3_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "3";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table4_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "4";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table5_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "5";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table6_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "6";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table7_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "7";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table8_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "8";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table9_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "9";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table10_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "10";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table11_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "11";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table12_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "12";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table13_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "13";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void table14_Click(object sender, EventArgs e)
        {
            chosen_table.Text = "14";
            chosen_table_text.Visible = true;
            able_table = true;
        }

        private void verder_button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                table_header_text.Visible = true;
                table_panel.Visible = true;
                //dataGridView1.Visible = true;

                //personen_box.Value = value;

                //var serializedStr = File.ReadAllText(path);
                //var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);
                ////var personen_value = Convert.ToInt32(personen_box.Value);

                //DataTable dt = new DataTable();
                ////dt.Columns.Add("Nummer");
                ////dt.Columns.Add("Capaciteit");

                //foreach (var n in tables)
                //{
                //    var capaciteit = Convert.ToInt32(n.Capaciteit);
                //    //if (capaciteit >= personen_box.Value && capaciteit <= (personen_box.Value + 2))
                //    //{
                //    //    DataRow dr = dt.NewRow();
                //    //    //dr["Nummer"] = n.Nummer;
                //    //    //dr["Capaciteit"] = n.Capaciteit;
                //    //    //dt.Rows.Add(dr);

                //    //    //table_combo.Items.Add(d["Nummer"]);
                //    //}
                //}
                //dataGridView1.DataSource = dt;

                table1.Visible = false;
                table2.Visible = false;
                table3.Visible = false;
                table4.Visible = false;
                table5.Visible = false;
                table6.Visible = false;
                table7.Visible = false;
                table8.Visible = false;
                table9.Visible = false;
                table10.Visible = false;
                table11.Visible = false;
                table12.Visible = false;
                table13.Visible = false;
                table14.Visible = false;

                 if (personen_box.Value <= 2)
                {
                    table1.Visible = true;
                    table2.Visible = true;
                    table3.Visible = true;
                    table4.Visible = true;
                    table5.Visible = true;
                    table6.Visible = true;
                    table7.Visible = true;
                    table8.Visible = true;
                }
                else if (personen_box.Value <= 3)
                {
                    table9.Visible = true;
                    table10.Visible = true;
                    table11.Visible = true;
                    table12.Visible = true;
                }
                else if (personen_box.Value <= 4)
                {
                    table9.Visible = true;
                    table10.Visible = true;
                    table11.Visible = true;
                    table12.Visible = true;
                    table13.Visible = true;
                    table14.Visible = true;
                }
                else if (personen_box.Value <= 6)
                {
                    table13.Visible = true;
                    table14.Visible = true;
                }
                else
                {
                    table1.Visible = false;
                    table2.Visible = false;
                    table3.Visible = false;
                    table4.Visible = false;
                    table5.Visible = false;
                    table6.Visible = false;
                    table7.Visible = false;
                    table8.Visible = false;
                    table9.Visible = false;
                    table10.Visible = false;
                    table11.Visible = false;
                    table12.Visible = false;
                    table13.Visible = false;
                    table14.Visible = false;
                }
            }

        }

        private void table_next_Click(object sender, EventArgs e)
        {
            if (able_table == true && time_box.Text != "")
            {
                confirmation_title.Visible = true;
                verification_panel.Visible = true;
                name_value.Text = naam_box.Text + " " + achternaam_box.Text;
                table_value.Text = chosen_table.Text;
                date_value.Text = datum_box.Value.ToString("dd-MM-yyyy");
                time_value.Text = time_box.Text;
                phone_value.Text = telefoon_Box.Text;
                email_value.Text = email_box.Text;
            }
        }

        private void table_back_Click(object sender, EventArgs e)
        {
            table_panel.Visible = false;
            chosen_table_text.Visible = false;
            chosen_table.Text = "";
            able_table = false;
            //table_combo.Items.Clear();
        }

        private void confirmation_back_Click(object sender, EventArgs e)
        {
            verification_panel.Visible = false;
            table_panel.Visible = true;
        }

        private void confirm_button_Click(object sender, EventArgs e)


        {
            // Mail sturen nadat de klant op bevestig reservatie klikt.
            var fromAddress = new MailAddress("hrdelicates@gmail.com", "HRDelicates"); // Mail adres en naam van de gene die stuurt.
            var toAddress = new MailAddress(email_value.Text, name_value.Text); // Mail van de ontvanger en naam.
            string fromPassword = "Henk12345"; // ww email restaurant.
            string subject = "Reservering HRDelicates"; // onderwerp mail.
            // Hieronder de opbouw van de tekst in de mail.
            string introductionMail = "Beste " + name_value.Text + ",\nBedankt voor uw reservatie bij HRDelicates.\nHieronder vind u de informatie betreffende uw reservatie.";
            string reservationInfo = "\n\nAdres Restaurant: Wijnhaven 107\nTijd reservatie: " + time_value.Text + "\nDatum: " + date_value.Text +"\nTafel: " + table_value.Text +"\nAantal personen: " + personen_box.Value;
            string endMail = "\n\nMocht u nog vragen of opmerkingen hebben kunt u contact opnemen met ons op het volgende nummer: 0104287287 of mailen naar bovenstaand mail adres.\nBedankt voor uw reservatie en wij hopen u snel te zien.\n\nMet vriendelijke groet,\nHRDelicates";
            string body = introductionMail + reservationInfo + endMail;
                            
                         
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",  // standaard gmail server voor het sturen van gmail mails.
                Port = 587, // standaard port van de server voor het sturen van gmail mails.
                EnableSsl = true, // beveiliging voor het schakelen tussen de app en de gmail server.
                DeliveryMethod = SmtpDeliveryMethod.Network, // Via wat de mail wordt afgeleverd en hoe.
                UseDefaultCredentials = false, // Dit is false omdat we niet de standaar gebruiken maar de info die ons wordt aangegeven en vervolgens wordt die hieronder gebruikt.
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword) // new instance.
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message); // stuurt de mail.
            }

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
            jsonObj[Int32.Parse(table_value.Text) - 1]["Persoon"] = naam_box.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Last_name"] = achternaam_box.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["D_reservering"] = date_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Time"] = time_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Telefoon"] = phone_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Email"] = email_value.Text;
            jsonObj[Int32.Parse(table_value.Text) - 1]["Status"] = "Unavailable";
            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(path, output);

            finish_panel.Visible = true;
            finish_text.Visible = true;
        }

        private void back_begin_Click(object sender, EventArgs e)
        {
            table_panel.Visible = false;
            verification_panel.Visible = false;
            finish_panel.Visible = false;
            naam_box.Text = "";
            achternaam_box.Text = "";
            date_value.Text = "";
            time_value.Text = "";
            phone_value.Text = "";
            email_value.Text = "";
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
            else if(!email_box.Text.Contains("@"))
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

        private void chosen_table_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }
    }
}
