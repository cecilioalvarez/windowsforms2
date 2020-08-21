namespace WindowsForms001
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EtiquetaRadios = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.botonSeleccionado = new System.Windows.Forms.Button();
            this.esInformatico = new System.Windows.Forms.CheckBox();
            this.botonInformatico = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colores";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(66, 123);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.Text = "azul";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "rojo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "verde";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // EtiquetaRadios
            // 
            this.EtiquetaRadios.AutoSize = true;
            this.EtiquetaRadios.Location = new System.Drawing.Point(41, 254);
            this.EtiquetaRadios.Name = "EtiquetaRadios";
            this.EtiquetaRadios.Size = new System.Drawing.Size(0, 17);
            this.EtiquetaRadios.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Location = new System.Drawing.Point(44, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 125);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(9, 83);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(110, 21);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(9, 40);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // botonSeleccionado
            // 
            this.botonSeleccionado.Location = new System.Drawing.Point(492, 104);
            this.botonSeleccionado.Name = "botonSeleccionado";
            this.botonSeleccionado.Size = new System.Drawing.Size(135, 23);
            this.botonSeleccionado.TabIndex = 6;
            this.botonSeleccionado.Text = "Seleccionado";
            this.botonSeleccionado.UseVisualStyleBackColor = true;
            this.botonSeleccionado.Click += new System.EventHandler(this.botonSeleccionado_Click);
            // 
            // esInformatico
            // 
            this.esInformatico.AutoSize = true;
            this.esInformatico.Location = new System.Drawing.Point(504, 222);
            this.esInformatico.Name = "esInformatico";
            this.esInformatico.Size = new System.Drawing.Size(114, 21);
            this.esInformatico.TabIndex = 7;
            this.esInformatico.Text = "esInformatico";
            this.esInformatico.UseVisualStyleBackColor = true;
            // 
            // botonInformatico
            // 
            this.botonInformatico.Location = new System.Drawing.Point(476, 313);
            this.botonInformatico.Name = "botonInformatico";
            this.botonInformatico.Size = new System.Drawing.Size(163, 23);
            this.botonInformatico.TabIndex = 8;
            this.botonInformatico.Text = "botonInformatico";
            this.botonInformatico.UseVisualStyleBackColor = true;
            this.botonInformatico.Click += new System.EventHandler(this.botonInformatico_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonInformatico);
            this.Controls.Add(this.esInformatico);
            this.Controls.Add(this.botonSeleccionado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.EtiquetaRadios);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label EtiquetaRadios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button botonSeleccionado;
        private System.Windows.Forms.CheckBox esInformatico;
        private System.Windows.Forms.Button botonInformatico;
    }
}