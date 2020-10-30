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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos A Mi Programa, Edwin Leonardo Molina");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnganancia_Click(object sender, EventArgs e)
        {
            Formularios.frmganancia Ganancia = new Formularios.frmganancia();
            Ganancia.ShowDialog();
        }

        private void btnlitros_Click(object sender, EventArgs e)
        {
            Formularios.frmlitros Litros = new Formularios.frmlitros();
            Litros.ShowDialog();
        }

        private void btnnota_Click(object sender, EventArgs e)
        {
            Formularios.frmpromedio Promedio = new Formularios.frmpromedio();
            Promedio.ShowDialog();

        }

        private void btnpromedio_Click(object sender, EventArgs e)
        {
            Formularios.frmpromediode4 notas = new Formularios.frmpromediode4();
            notas.ShowDialog();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            Formularios.frmfactura factura = new Formularios.frmfactura();
            factura.ShowDialog();
        }
    }
}
