using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5_LeonardoMolina.Formularios
{
    public partial class frmlitros : Form
    {
        Clases.Ganancia LT = new Clases.Ganancia();
        public frmlitros()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtdiametro.Clear();
            txtlitros.Clear();
            txtvolumen.Clear();
            txtradio.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double altura, diametro, volumen,potencia,radio;
                altura = Convert.ToDouble(txtaltura.Text);
            diametro = Convert.ToDouble(txtdiametro.Text);
            txtradio.Text = LT.radio(diametro).ToString();
            radio = Convert.ToDouble(txtradio.Text);
            potencia = Convert.ToDouble(2);
            txtvolumen.Text = LT.volumen(radio,altura, potencia, diametro).ToString();
            volumen = Convert.ToDouble(txtvolumen.Text);
            txtlitros.Text = LT.litros(volumen, 1000).ToString();
            
            
            
        }

        
        
    }
}
