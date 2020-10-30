namespace Tarea5_LeonardoMolina.Formularios
{
    partial class frmmenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnfactura = new System.Windows.Forms.Button();
            this.btnpromedio = new System.Windows.Forms.Button();
            this.btnnota = new System.Windows.Forms.Button();
            this.btnlitros = new System.Windows.Forms.Button();
            this.btnganancia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.btnfactura);
            this.groupBox1.Controls.Add(this.btnpromedio);
            this.groupBox1.Controls.Add(this.btnnota);
            this.groupBox1.Controls.Add(this.btnlitros);
            this.groupBox1.Controls.Add(this.btnganancia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(239, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 31);
            this.button7.TabIndex = 7;
            this.button7.Text = "Salir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(17, 239);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Autor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnfactura
            // 
            this.btnfactura.Location = new System.Drawing.Point(41, 193);
            this.btnfactura.Name = "btnfactura";
            this.btnfactura.Size = new System.Drawing.Size(244, 28);
            this.btnfactura.TabIndex = 5;
            this.btnfactura.Text = "Factura";
            this.btnfactura.UseVisualStyleBackColor = true;
            this.btnfactura.Click += new System.EventHandler(this.btnfactura_Click);
            // 
            // btnpromedio
            // 
            this.btnpromedio.Location = new System.Drawing.Point(41, 159);
            this.btnpromedio.Name = "btnpromedio";
            this.btnpromedio.Size = new System.Drawing.Size(244, 28);
            this.btnpromedio.TabIndex = 4;
            this.btnpromedio.Text = "Promedio De 4 Notas";
            this.btnpromedio.UseVisualStyleBackColor = true;
            this.btnpromedio.Click += new System.EventHandler(this.btnpromedio_Click);
            // 
            // btnnota
            // 
            this.btnnota.Location = new System.Drawing.Point(41, 125);
            this.btnnota.Name = "btnnota";
            this.btnnota.Size = new System.Drawing.Size(244, 28);
            this.btnnota.TabIndex = 3;
            this.btnnota.Text = "Nota Para Aprovar";
            this.btnnota.UseVisualStyleBackColor = true;
            this.btnnota.Click += new System.EventHandler(this.btnnota_Click);
            // 
            // btnlitros
            // 
            this.btnlitros.Location = new System.Drawing.Point(41, 91);
            this.btnlitros.Name = "btnlitros";
            this.btnlitros.Size = new System.Drawing.Size(244, 28);
            this.btnlitros.TabIndex = 2;
            this.btnlitros.Text = "Cantidad De Litros";
            this.btnlitros.UseVisualStyleBackColor = true;
            this.btnlitros.Click += new System.EventHandler(this.btnlitros_Click);
            // 
            // btnganancia
            // 
            this.btnganancia.Location = new System.Drawing.Point(41, 57);
            this.btnganancia.Name = "btnganancia";
            this.btnganancia.Size = new System.Drawing.Size(244, 28);
            this.btnganancia.TabIndex = 1;
            this.btnganancia.Text = "Ganancia De Un Producto";
            this.btnganancia.UseVisualStyleBackColor = true;
            this.btnganancia.Click += new System.EventHandler(this.btnganancia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese A Uno De Los Ejercicios";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(354, 310);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnfactura;
        private System.Windows.Forms.Button btnpromedio;
        private System.Windows.Forms.Button btnnota;
        private System.Windows.Forms.Button btnlitros;
        private System.Windows.Forms.Button btnganancia;
        private System.Windows.Forms.Label label1;
    }
}