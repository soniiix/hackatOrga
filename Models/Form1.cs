﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackatOrga.Models
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MonDbContext cnx = new MonDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
