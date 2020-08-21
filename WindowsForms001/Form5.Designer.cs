namespace WindowsForms001
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.conceptoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(325, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(457, 200);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(193, 43);
            this.botonAceptar.TabIndex = 1;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.Location = new System.Drawing.Point(550, 62);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(100, 22);
            this.numeroTextBox.TabIndex = 2;
            // 
            // conceptoTextBox
            // 
            this.conceptoTextBox.Location = new System.Drawing.Point(550, 101);
            this.conceptoTextBox.Name = "conceptoTextBox";
            this.conceptoTextBox.Size = new System.Drawing.Size(100, 22);
            this.conceptoTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Concepto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conceptoTextBox);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox conceptoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}