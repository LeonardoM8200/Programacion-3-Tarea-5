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
    public partial class frmpromedio : Form
    {
        Clases.Promedio PM = new Clases.Promedio();
        public frmpromedio()
        {
            InitializeComponent();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtpromedio.Clear();
            txtfaltante.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, promedio;
            nota1 = int.Parse(txtnota1.Text);
            nota2 = int.Parse(txtnota2.Text);
            nota3 = int.Parse(txtnota3.Text);
            txtpromedio.Text = PM.promedio(nota1, nota2, nota3).ToString();
            promedio = int.Parse(txtpromedio.Text);
            txtfaltante.Text = PM.Faltante(promedio).ToString();

        }

        private void txtaprovado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
