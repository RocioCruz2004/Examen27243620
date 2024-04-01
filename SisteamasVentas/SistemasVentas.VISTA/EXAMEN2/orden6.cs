using SistemasVentas.BSS;
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
    public partial class orden6 : Form
    {
        public orden6()
        {
            InitializeComponent();
        }
        examen2Bss bss = new examen2Bss();
        private void orden6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.orden6Bss();
        }
    }
}
