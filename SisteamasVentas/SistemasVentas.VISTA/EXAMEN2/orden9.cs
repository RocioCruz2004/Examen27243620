﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.EXAMEN2
{
    public partial class orden9 : Form
    {
        public orden9()
        {
            InitializeComponent();
        }

        examen2Bss bss = new examen2Bss();
        private void orden9_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.orden9Bss();
        }
    }
}
