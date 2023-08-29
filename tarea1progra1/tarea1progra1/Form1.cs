using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Integrantes 
// William Alexander Aparicio Zelaya
//Gerson Daniel Guerrero Castillo 
namespace tarea1progra1
{
     
    public partial class Form1 : Form
    {
        String[][] TiposConversores = new string[][] {
       new string[] {"Pie cuadrado", "Vara cuadrada", "Yarda cuadrada", "Metro Cuadrado", "Tareas", "Manzanas", "Hectarias", }, //areas
        
        };
        

        public Form1()
        {
            InitializeComponent();
        }

       

        private void CboTipoConversor_TextChanged(object sender, EventArgs e)
        {
            CboDeConversor.Items.Clear();
            CboDeConversor.Items.AddRange(TiposConversores[CboTipoConversor.SelectedIndex]);

            CboAConversores.Items.Clear();
            CboAConversores.Items.AddRange(TiposConversores[CboTipoConversor.SelectedIndex]);

        }

        private void Btn_ConvertirConversores_Click(object sender, EventArgs e)
        {
            
                int de = 0, a = 0;
                double cantidad = 0, respuesta = 0;
                de = CboDeConversor.SelectedIndex;
                a = CboAConversores.SelectedIndex;

                cantidad = double.Parse(TxtCantidadConversores.Text);

            double[][] monedas = {
            new double []{0.09290304, 0.698896, 0.836127, 1, 437.5, 7000, 10.000, }, //area
            };
            respuesta = monedas[CboTipoConversor.SelectedIndex][de] / monedas[CboTipoConversor.SelectedIndex][a] * cantidad;

                LblRespuestaConversores.Text = "Respuesta: " + Math.Round(respuesta, 4);
            }

        
    }
}
