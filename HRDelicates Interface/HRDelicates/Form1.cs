using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDelicates
{
    public partial class Form1 : Form
    {
        string screen_active;

        public Form1()
        {
            InitializeComponent();
            startscreen1.BringToFront();
            screen_active = "home";
            home_text.Visible = true;

            home_nav.MouseEnter += OnMouseEnterHome;
            home_nav.MouseLeave += OnMouseLeaveHome;
            reserve_nav.MouseEnter += OnMouseEnterReserve;
            reserve_nav.MouseLeave += OnMouseLeaveReserve;
            menu_nav.MouseEnter += OnMouseEnterMenu;
            menu_nav.MouseLeave += OnMouseLeaveMenu;
            contact_nav.MouseEnter += OnMouseEnterContact;
            contact_nav.MouseLeave += OnMouseLeaveContact;
            exit_button2.MouseEnter += OnMouseEnterExit;
            exit_button2.MouseLeave += OnMouseLeaveExit;
        }

        private void OnMouseEnterHome(object sender, EventArgs e)
        {
            choose_home.Visible = true;
        }
        private void OnMouseLeaveHome(object sender, EventArgs e)
        {
            if(screen_active != "home")
            {
                choose_home.Visible = false;
            }
        }
        private void OnMouseEnterReserve(object sender, EventArgs e)
        {
            choose_reserve.Visible = true;
        }
        private void OnMouseLeaveReserve(object sender, EventArgs e)
        {
            if (screen_active != "reserve")
            {
                choose_reserve.Visible = false;
            }
        }
        private void OnMouseEnterMenu(object sender, EventArgs e)
        {
            choose_menu.Visible = true;
        }
        private void OnMouseLeaveMenu(object sender, EventArgs e)
        {
            if (screen_active != "menu")
            {
                choose_menu.Visible = false;
            }
        }
        private void OnMouseEnterContact(object sender, EventArgs e)
        {
            choose_contact.Visible = true;
        }
        private void OnMouseLeaveContact(object sender, EventArgs e)
        {
            if (screen_active != "contact")
            {
                choose_contact.Visible = false;
            }
        }
        private void OnMouseEnterExit(object sender, EventArgs e)
        {
            choose_close.Visible = true;
        }
        private void OnMouseLeaveExit(object sender, EventArgs e)
        {
            if (screen_active != "exit")
            {
                choose_close.Visible = false;
            }
        }

        private void home_nav_Click(object sender, EventArgs e)
        {
            startscreen1.BringToFront();
            screen_active = "home";
            home_text.Visible = true;
            menu_text.Visible = false;
            contact_text.Visible = false;

            choose_home.Visible = true;
            choose_reserve.Visible = false;
            choose_menu.Visible = false;
            choose_contact.Visible = false;
            choose_close.Visible = false;
        }

        private void reserve_nav_Click(object sender, EventArgs e)
        {
            reservationscreen1.BringToFront();
            screen_active = "reserve";
            home_text.Visible = false;
            reserve_text.Visible = true;
            menu_text.Visible = false;
            contact_text.Visible = false;

            choose_home.Visible = false;
            choose_reserve.Visible = true;
            choose_menu.Visible = false;
            choose_contact.Visible = false;
            choose_close.Visible = false;
        }

        private void menu_nav_Click(object sender, EventArgs e)
        {
            menuscreen1.BringToFront();
            screen_active = "menu";
            menu_text.Visible = true;
            contact_text.Visible = false;
            home_text.Visible = false;

            choose_menu.Visible = true;
            choose_contact.Visible = false;
            choose_home.Visible = false;
            choose_reserve.Visible = false;
            choose_close.Visible = false;
        }

        private void contact_nav_Click(object sender, EventArgs e)
        {
            contactscreen1.BringToFront();
            screen_active = "contact";
            home_text.Visible = false;
            menu_text.Visible = false;
            contact_text.Visible = true;

            choose_contact.Visible = true;
            choose_home.Visible = false;
            choose_reserve.Visible = false;
            choose_menu.Visible = false;
            choose_close.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (Dishes == null)
            //{
            //    Dishes = new Dishes
            //    {
            //        Name = "Spaghet",
            //        Type = "Voorgerecht",
            //        Price = "3.80"
            //    };
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u het programma wilt aflsuiten?", "Programma afsluiten", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void exit_button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet u zeker dat u het programma wilt aflsuiten?", "Programma afsluiten", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void contactscreen1_Load(object sender, EventArgs e)
        {

        }

        private void home_text_Click(object sender, EventArgs e)
        {

        }

        private void menuscreen1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
