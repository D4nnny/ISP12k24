﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Mantenimientos
{
    public partial class frmSucursales : Form
    {
        public frmSucursales()
        {
            InitializeComponent();
            this.navegador1.config("tbl_sucursales", this, "8024");
        }
    }
}
