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
    public partial class Introscreen : UserControl
    {
        const string path = @"Tables.json";

        public Tables Tables { get; set; }

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
            klant_button.Visible = false;
            worker_button.Visible = false;
            username_text.Visible = true;
            username_box.Visible = true;
            password_text.Visible = true;
            password_box.Visible = true;
            login_button.Visible = true;
            terug_login.Visible = true;
            login_header.Visible = true;
            password_box.PasswordChar = '*';
        }

        private void terug_login_Click(object sender, EventArgs e)
        {
            klant_button.Visible = true;
            worker_button.Visible = true;
            username_text.Visible = false;
            username_box.Visible = false;
            password_text.Visible = false;
            password_box.Visible = false;
            login_button.Visible = false;
            terug_login.Visible = false;
            login_header.Visible = false;

            username_box.Text = "";
            password_box.Text = "";
            error_login.Visible = false;
        }

        private void terug_admin_Click(object sender, EventArgs e)
        {
            edit_panel.Visible = false;
            dataGridView1.Visible = false;
            klant_button.Visible = false;
            worker_button.Visible = false;
            username_text.Visible = true;
            username_box.Visible = true;
            password_text.Visible = true;
            password_box.Visible = true;
            login_button.Visible = true;
            terug_login.Visible = true;
            terug_admin.Visible = false;
            login_header.Visible = true;

            username_box.Text = "";
            password_box.Text = "";
            error_login.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u het programma wilt aflsuiten?", "Programma afsluiten", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void confirmation_title_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_box.Text == "Admin" && password_box.Text == "Admin")
            {
                dataGridView1.Visible = true;
                dataGridView1.BringToFront();
                terug_admin.Visible = true;
                edit_panel.Visible = true;
                edit_panel.BringToFront();
                terug_login.Visible = false;
                login_header.Visible = false;

                username_box.Text = "";
                password_box.Text = "";

                var serializedStr = File.ReadAllText(path);
                var tables = JsonConvert.DeserializeObject<Tables[]>(serializedStr);

                DataTable dt = new DataTable();
                dt.Columns.Add("Nummer");
                dt.Columns.Add("Capaciteit");
                dt.Columns.Add("Status");
                dt.Columns.Add("Persoon");
                dt.Columns.Add("Email");
                dt.Columns.Add("D_reservering");
                dt.Columns.Add("Time");

                foreach (var n in tables)
                {
                    if (n.Persoon != "")
                    {
                        DataRow dr = dt.NewRow();
                        dr["Nummer"] = n.Nummer;
                        dr["Capaciteit"] = n.Capaciteit;
                        dr["Status"] = n.Status;
                        dr["Persoon"] = n.Persoon;
                        dr["Email"] = n.Email;
                        dr["D_reservering"] = n.D_reservering;
                        dr["Time"] = n.Time;

                        dt.Rows.Add(dr);
                    }
                }
                dataGridView1.DataSource = dt;

                //dataGridView1.DataSource = tafels;
            }
            else
            {
                error_login.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intropanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_text_Click(object sender, EventArgs e)
        {

        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void table_edit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}