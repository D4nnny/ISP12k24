using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_SisB
{
    public partial class frmRetiro : Form
    {
        public frmRetiro()
        {
            InitializeComponent();
        }

        private void btn_genCodigo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int codigo = rnd.Next(100000000, 999999999);
            label_CodigoSeguridad.Text = codigo.ToString();
        }
    }
}
