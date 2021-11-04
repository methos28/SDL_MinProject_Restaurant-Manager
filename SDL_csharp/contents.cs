﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Controls;

namespace SDL_csharp
{
    public partial class contents : Form
    {

        public contents()
        {
            InitializeComponent();
        }
        // Buttons Configurations
        private void contents_Load(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Hide();
            fillbox3.Hide();
            fillbox7.Hide();
            fillbox6.Hide();
            fillbox4.Hide();

            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
            userControl41.Hide();
            userControl51.Hide();
            userControl61.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            fillbox1.Show(); 
            fillbox2.Hide();
            fillbox3.Hide();
            fillbox7.Hide();
            fillbox6.Hide();
            fillbox4.Hide();
            userControl11.Show();
            userControl11.BringToFront();

        }

        private void order_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Show();
            fillbox3.Hide();
            fillbox7.Hide();
            fillbox6.Hide();
            fillbox4.Hide();
            userControl11.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void controlpanel_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        { 


        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Hide();
            fillbox3.Hide();
            fillbox7.Hide();
            fillbox6.Show();
            fillbox4.Hide();
            userControl31.Show();
            userControl31.BringToFront();

        }

        private void fillbox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void contents_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void delete_itm_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Hide();
            fillbox3.Show();
            fillbox7.Hide();
            fillbox6.Hide();
            fillbox4.Hide();
            userControl41.BringToFront();
            userControl41.Show();



        }

        private void abt_Click(object sender, EventArgs e)
        {
            fillbox1.Hide();
            fillbox2.Hide();
            fillbox3.Hide();
            fillbox7.Show();
            fillbox6.Hide();
            fillbox4.Hide();
            userControl51.Show();
            userControl51.BringToFront();
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1();

            DialogResult d;
            d = MessageBox.Show("Are you sure ?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                this.Hide();
                frm.Show();
            }
            
            


        }

        private void add_emp_Click(object sender, EventArgs e)
        {

            fillbox1.Hide();
            fillbox2.Hide();
            fillbox3.Hide();
            fillbox7.Hide();
            fillbox4.Show();
            fillbox6.Hide();
            userControl61.Show();
            userControl61.BringToFront();
            

        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }
    }
}
