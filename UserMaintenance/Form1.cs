﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Properties;

   



namespace UserMaintenance

{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
            lblLastName.Text = "Keresztnév"; // label1
            lblFirstName.Text = "Vezetéknév"; // label2
            btnAdd.Text = "Hozzáadás"; // button1

            // listbox1
           
        }
    }
}
