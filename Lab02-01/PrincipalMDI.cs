﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class PrincipalMDI : Form
    {
        public PrincipalMDI()
        {
            InitializeComponent();
        }


        private void mnuManUsuarios_Click(object sender, EventArgs e)
        {
            manUsuarios frm = new manUsuarios();
            frm.MdiParent = this;
            frm.Show();
            
        }
        private void mnuSisSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
