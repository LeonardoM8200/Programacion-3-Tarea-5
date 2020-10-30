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
    public partial class frmganancia : Form
    {
        Clases.Ganancia GA = new Clases.Ganancia();
        public frmganancia()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double costo, venta;
            costo = Convert.ToDouble(txtpreciobase.Text);
            venta = Convert.ToDouble(txtprecioventa.Text);
            txtganancia.Text = GA.Ganancia1(costo, venta).ToString();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtganancia.Clear();
            txtpreciobase.Clear();
            txtprecioventa.Clear();
            txtproducto.Clear();
        }

    }
}
