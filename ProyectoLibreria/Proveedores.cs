using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;


namespace ProyectoLibreria
{
    public partial class Proveedores : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        DataTable miTabla = new DataTable();
        public int posicion = 0;
        String accion = "nuevo";

        public Proveedores()
        {

            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {

            actualizarDsProveedor();
            Limpiar();
            cboBuscarProveedor.SelectedIndex = 1;
        }
        private void actualizarDsProveedor()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            miTabla = miDs.Tables["Proveedor"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["IdProveedor"] };
            mostrarProveedor();
            mostrarDatosProveedor();
        }
        private void mostrarProveedor()
        {
            dgvProveedores.DataSource = miDs.Tables["Proveedor"].DefaultView;

        }
        private void FiltrarProveedores(String valor, int opcion)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dgvProveedores.DataSource;
                bs.Filter = opcion == 0 ? "NombreProveedor=" + valor : "Telefono like '%" + valor + "%'";
                dgvProveedores.DataSource = bs;
                erpProveedor.SetError(txtBuscarProveedor, "");
            }
            catch (Exception e)
            {
                erpProveedor.SetError(txtBuscarProveedor, "Por favor Ingrese un nombre o Telefono de Proveedor");

            }
        }
        private void mostrarDatosProveedor()
        {
            txtNombreProveedor.Text = miDs.Tables["Proveedor"].Rows[posicion].ItemArray[1].ToString();
            txtTelefonoProveedor.Text = miDs.Tables["Proveedor"].Rows[posicion].ItemArray[2].ToString();
            txtDireccionProveedor.Text = miDs.Tables["Proveedor"].Rows[posicion].ItemArray[3].ToString();
            txtEmailProveedor.Text = miDs.Tables["Proveedor"].Rows[posicion].ItemArray[4].ToString();


        }
        private void btnGuardarProveedor_Click_1(object sender, EventArgs e)
        {
            if (btnGuardarProveedor.Text == "Nuevo")
            {
                btnGuardarProveedor.Text = "Guardar";
                btnActualizarProveedor.Text = "Cancelar";

                estadoControles(false);
                accion = "nuevo";
            }
            else
            {
                // Guardar
                String[] Proveedor = new string[] {
                accion, txtNombreProveedor.Text, txtTelefonoProveedor.Text, txtDireccionProveedor.Text, txtEmailProveedor.Text,
                miTabla.Rows[posicion].ItemArray[0].ToString()
            };
                String msg = objConexion.mantenimientoProveedor(Proveedor);
                if (msg != "1")
                {
                    MessageBox.Show("Error en el registro de Proveedor: " + msg, "Registro de Proveedor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsProveedor();
                    estadoControles(true);
                    btnGuardarProveedor.Text = "Nuevo";
                    btnActualizarProveedor.Text = "Modificar";
                }
            }
        }
        private void btnActualizarProveedor_Click_1(object sender, EventArgs e)
        {
            if (btnActualizarProveedor.Text == "Modificar")
            {
                btnGuardarProveedor.Text = "Guardar";
                btnActualizarProveedor.Text = "Cancelar";
                estadoControles(false);
                accion = "modificar";
            }
            else
            {
                estadoControles(true);
                mostrarDatosProveedor();
                btnGuardarProveedor.Text = "Nuevo";
                btnActualizarProveedor.Text = "Modificar";
            }
        }
        private void estadoControles(Boolean estado)
        {
            txtNombreProveedor.ReadOnly = estado;
            txtTelefonoProveedor.ReadOnly = estado;
            txtDireccionProveedor.ReadOnly = estado;
            txtEmailProveedor.ReadOnly = estado;
            dgvProveedores.Enabled = estado;
            btnEliminarProveedor.Enabled = estado;
            txtBuscarProveedor.ReadOnly = !estado;
        }
        private void Limpiar()
        {
            txtNombreProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtDireccionProveedor.Text = "";
            txtEmailProveedor.Text = "";
        }
        private void txtBuscarProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarProveedores(txtBuscarProveedor.Text, cboBuscarProveedor.SelectedIndex);
            if (e.KeyValue == 13)
            {//tecla enter
                seleccionarProveedor();
            }
        }
        private void seleccionarProveedor()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(dgvProveedores.CurrentRow.Cells["IdProveedor"].Value.ToString()));
            mostrarDatosProveedor();
        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarProveedor();
        }
        private void btnEliminarProveedor_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Está seguro de eliminar a " + txtNombreProveedor.Text + "?", "Eliminar Proveedor",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] Proveedor = new string[] {
                "eliminar", txtNombreProveedor.Text, txtTelefonoProveedor.Text, txtDireccionProveedor.Text, txtEmailProveedor.Text,
                miTabla.Rows[posicion].ItemArray[0].ToString()
            };
                String msg = objConexion.mantenimientoProveedor(Proveedor);
                if (msg != "1")
                {
                    MessageBox.Show("Error en la eliminación de Proveedor: " + msg, "Registro de Proveedores.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    actualizarDsProveedor();
                }
            }
        }

    }
}

