﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer_2D
{
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
        }

        private void btMeniu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
