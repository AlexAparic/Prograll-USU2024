using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLibreria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnInicioProveedor_Click(object sender, EventArgs e)
        {
            Proveedores form = new Proveedores();
            form.Show();
            this.Hide();
        }
    }
}
