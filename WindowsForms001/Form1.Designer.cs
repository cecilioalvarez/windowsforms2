namespace WindowsForms001
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.EtiquetaNombre = new System.Windows.Forms.Label();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.EtiquetaApellidos = new System.Windows.Forms.Label();
            this.cajaApellidos = new System.Windows.Forms.TextBox();
            this.botonPersona = new System.Windows.Forms.Button();
            this.EtiquetaNota1 = new System.Windows.Forms.Label();
            this.EtiquetaNota2 = new System.Windows.Forms.Label();
            this.EtiquetaNota3 = new System.Windows.Forms.Label();
            this.cajaNota1 = new System.Windows.Forms.TextBox();
            this.cajaNota2 = new System.Windows.Forms.TextBox();
            this.cajaNota3 = new System.Windows.Forms.TextBox();
            this.botonNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pulsame";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EtiquetaNombre
            // 
            this.EtiquetaNombre.AutoSize = true;
            this.EtiquetaNombre.Location = new System.Drawing.Point(21, 120);
            this.EtiquetaNombre.Name = "EtiquetaNombre";
            this.EtiquetaNombre.Size = new System.Drawing.Size(62, 17);
            this.EtiquetaNombre.TabIndex = 1;
            this.EtiquetaNombre.Text = "Nombre:";
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(109, 120);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(100, 22);
            this.cajaNombre.TabIndex = 2;
            // 
            // EtiquetaApellidos
            // 
            this.EtiquetaApellidos.AutoSize = true;
            this.EtiquetaApellidos.Location = new System.Drawing.Point(21, 157);
            this.EtiquetaApellidos.Name = "EtiquetaApellidos";
            this.EtiquetaApellidos.Size = new System.Drawing.Size(65, 17);
            this.EtiquetaApellidos.TabIndex = 3;
            this.EtiquetaApellidos.Text = "Apellidos";
            // 
            // cajaApellidos
            // 
            this.cajaApellidos.Location = new System.Drawing.Point(109, 157);
            this.cajaApellidos.Name = "cajaApellidos";
            this.cajaApellidos.Size = new System.Drawing.Size(100, 22);
            this.cajaApellidos.TabIndex = 4;
            // 
            // botonPersona
            // 
            this.botonPersona.Location = new System.Drawing.Point(24, 211);
            this.botonPersona.Name = "botonPersona";
            this.botonPersona.Size = new System.Drawing.Size(171, 52);
            this.botonPersona.TabIndex = 5;
            this.botonPersona.Text = "Datos de la Persona";
            this.botonPersona.UseVisualStyleBackColor = true;
            this.botonPersona.Click += new System.EventHandler(this.botonPersona_Click);
            // 
            // EtiquetaNota1
            // 
            this.EtiquetaNota1.AutoSize = true;
            this.EtiquetaNota1.Location = new System.Drawing.Point(359, 47);
            this.EtiquetaNota1.Name = "EtiquetaNota1";
            this.EtiquetaNota1.Size = new System.Drawing.Size(46, 17);
            this.EtiquetaNota1.TabIndex = 6;
            this.EtiquetaNota1.Text = "Nota1";
            // 
            // EtiquetaNota2
            // 
            this.EtiquetaNota2.AutoSize = true;
            this.EtiquetaNota2.Location = new System.Drawing.Point(359, 93);
            this.EtiquetaNota2.Name = "EtiquetaNota2";
            this.EtiquetaNota2.Size = new System.Drawing.Size(46, 17);
            this.EtiquetaNota2.TabIndex = 7;
            this.EtiquetaNota2.Text = "Nota2";
            // 
            // EtiquetaNota3
            // 
            this.EtiquetaNota3.AutoSize = true;
            this.EtiquetaNota3.Location = new System.Drawing.Point(359, 142);
            this.EtiquetaNota3.Name = "EtiquetaNota3";
            this.EtiquetaNota3.Size = new System.Drawing.Size(46, 17);
            this.EtiquetaNota3.TabIndex = 8;
            this.EtiquetaNota3.Text = "Nota3";
            // 
            // cajaNota1
            // 
            this.cajaNota1.Location = new System.Drawing.Point(440, 47);
            this.cajaNota1.Name = "cajaNota1";
            this.cajaNota1.Size = new System.Drawing.Size(100, 22);
            this.cajaNota1.TabIndex = 9;
            // 
            // cajaNota2
            // 
            this.cajaNota2.Location = new System.Drawing.Point(440, 87);
            this.cajaNota2.Name = "cajaNota2";
            this.cajaNota2.Size = new System.Drawing.Size(100, 22);
            this.cajaNota2.TabIndex = 10;
            // 
            // cajaNota3
            // 
            this.cajaNota3.Location = new System.Drawing.Point(440, 142);
            this.cajaNota3.Name = "cajaNota3";
            this.cajaNota3.Size = new System.Drawing.Size(100, 22);
            this.cajaNota3.TabIndex = 11;
            // 
            // botonNotas
            // 
            this.botonNotas.Location = new System.Drawing.Point(421, 211);
            this.botonNotas.Name = "botonNotas";
            this.botonNotas.Size = new System.Drawing.Size(136, 23);
            this.botonNotas.TabIndex = 12;
            this.botonNotas.Text = "sumarNotas";
            this.botonNotas.UseVisualStyleBackColor = true;
            this.botonNotas.Click += new System.EventHandler(this.botonNotas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonNotas);
            this.Controls.Add(this.cajaNota3);
            this.Controls.Add(this.cajaNota2);
            this.Controls.Add(this.cajaNota1);
            this.Controls.Add(this.EtiquetaNota3);
            this.Controls.Add(this.EtiquetaNota2);
            this.Controls.Add(this.EtiquetaNota1);
            this.Controls.Add(this.botonPersona);
            this.Controls.Add(this.cajaApellidos);
            this.Controls.Add(this.EtiquetaApellidos);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.EtiquetaNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EtiquetaNombre;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.Label EtiquetaApellidos;
        private System.Windows.Forms.TextBox cajaApellidos;
        private System.Windows.Forms.Button botonPersona;
        private System.Windows.Forms.Label EtiquetaNota1;
        private System.Windows.Forms.Label EtiquetaNota2;
        private System.Windows.Forms.Label EtiquetaNota3;
        private System.Windows.Forms.TextBox cajaNota1;
        private System.Windows.Forms.TextBox cajaNota2;
        private System.Windows.Forms.TextBox cajaNota3;
        private System.Windows.Forms.Button botonNotas;
    }
}

