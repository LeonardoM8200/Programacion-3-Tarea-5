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
    public partial class frmpromediode4 : Form
    {
        Clases.Promedio NTO = new Clases.Promedio();
        public frmpromediode4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prome, n1, n2, n3, n4;
            n1 = int.Parse(textBox2.Text);
            n2 = int.Parse(textBox3.Text);
            n3 = int.Parse(textBox4.Text);
            n4 = int.Parse(textBox5.Text);
            prome = (n1 + n2 + n3 + n4);
            textBox6.Text = Convert.ToString(prome);

            int p = prome;
            int a = 65;
            if (p > a)
                if (p > a)
                {
                    textBox7.Text = ("Aprovado");
                }
            if (p < a)
            {
                textBox7.Text = ("Reprovado");
            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre, aprobadoandreprobado;
            int nota1, nota2, nota3, nota4, prome;
            nombre = textBox1.Text;
            aprobadoandreprobado = textBox7.Text;
            nota1 = int.Parse(textBox2.Text);
            nota2 = int.Parse(textBox3.Text);
            nota3 = int.Parse(textBox4.Text);
            nota4 = int.Parse(textBox5.Text);
            prome = int.Parse(textBox6.Text);
            dataGridView1.Rows.Add(nombre, nota1, nota2, nota3, nota4, prome, aprobadoandreprobado, "Borrar");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void ClickEnBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 00)
            {
                var row = dataGridView1.CurrentRow;
                Form2 frm = new Form2();
                var txt1 = frm.Controls["textnombre"];
                var txt2 = frm.Controls["textnota1"];
                var txt3 = frm.Controls["textnota2"];
                var txt4 = frm.Controls["textnota3"];
                var txt5 = frm.Controls["textnota4"];
                var txt6 = frm.Controls["textpromedio"];
                var txt7 = frm.Controls["textaprobadoandreprobado"];

        

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    row.Cells[0].Value = txt1.Text;
                    row.Cells[1].Value = txt2.Text;
                    row.Cells[2].Value = txt3.Text;
                    row.Cells[3].Value = txt4.Text;
                    row.Cells[4].Value = txt5.Text;
                    row.Cells[5].Value = txt6.Text;
                    row.Cells[6].Value = txt7.Text;
                }
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == 7)
            {
                var row = dataGridView1.CurrentRow;
                dataGridView1.Rows.Remove(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Column6"].Value);

                double valor;
                valor = Convert.ToDouble(total / 4);
                textBox8.Text = Convert.ToString(valor);
               
            }


        }
    }
}

