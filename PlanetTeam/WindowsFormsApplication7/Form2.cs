﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlanetTeam
{
    public partial class Form2 : Form
    {

        public Form2()
        {
           
            InitializeComponent();
            label1.Text = Form1.PLN[Form1.pln_selected].NAME;
            
        }

        private void btn_Click(object sender, EventArgs e)
        {

           
            Close(); 
             
        }
    }
}