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
    public partial class orden8 : Form
    {
        public orden8()
        {
            InitializeComponent();
        }

        examen2Bss bss = new examen2Bss();
        private void orden8_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = bss.orden8Bss();
        }
    }
}
