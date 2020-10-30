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
    public partial class frmfactura : Form
    {
        public frmfactura()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string producto, descripcion;
            int codigo, preciounitario;
            producto = txtproducto.Text;
            descripcion = txtdescripcion.Text;
            codigo = int.Parse(txtcodigo.Text);
            preciounitario = int.Parse(txtpreciounitario.Text);
            dataGridView1.Rows.Add(codigo, producto, descripcion, preciounitario, "Borrar");
            txtcodigo.Clear();
            txtproducto.Clear();
            txtdescripcion.Clear();
            txtpreciounitario.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Column4"].Value);
                txtsubtotal.Text = Convert.ToString(total);
            }
            double subtotal, impuesto;
            subtotal = Convert.ToDouble(txtsubtotal.Text);
            impuesto = subtotal * 0.015;
            txtisv.Text = impuesto.ToString();

            double total1;
            total1 = subtotal + impuesto;
            txttotal.Text = total1.ToString();

        }

        private void ClickEnBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                var row = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(row);
            }
        }
    }
}
