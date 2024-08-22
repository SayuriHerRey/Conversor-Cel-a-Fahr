namespace Conversor_Cel_a_Fahr
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
            this.Convertir = new System.Windows.Forms.Button();
            this.Convertir2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdcelsius = new System.Windows.Forms.TextBox();
            this.grdfahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Convertir
            // 
            this.Convertir.BackColor = System.Drawing.Color.Lime;
            this.Convertir.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convertir.ForeColor = System.Drawing.Color.Black;
            this.Convertir.Location = new System.Drawing.Point(31, 140);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(264, 41);
            this.Convertir.TabIndex = 0;
            this.Convertir.Text = "Celsius - Fahrenheit";
            this.Convertir.UseVisualStyleBackColor = false;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // Convertir2
            // 
            this.Convertir2.BackColor = System.Drawing.Color.Lime;
            this.Convertir2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Convertir2.ForeColor = System.Drawing.Color.Black;
            this.Convertir2.Location = new System.Drawing.Point(387, 140);
            this.Convertir2.Name = "Convertir2";
            this.Convertir2.Size = new System.Drawing.Size(250, 41);
            this.Convertir2.TabIndex = 1;
            this.Convertir2.Text = "Fahrenheit - Celsius";
            this.Convertir2.UseVisualStyleBackColor = false;
            this.Convertir2.Click += new System.EventHandler(this.Convertir2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Crimson;
            this.clear.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(462, 227);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 36);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grados Celsius:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Grados Fahrenheit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // grdcelsius
            // 
            this.grdcelsius.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdcelsius.Location = new System.Drawing.Point(31, 102);
            this.grdcelsius.Name = "grdcelsius";
            this.grdcelsius.Size = new System.Drawing.Size(264, 28);
            this.grdcelsius.TabIndex = 6;
            // 
            // grdfahrenheit
            // 
            this.grdfahrenheit.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdfahrenheit.Location = new System.Drawing.Point(387, 102);
            this.grdfahrenheit.Name = "grdfahrenheit";
            this.grdfahrenheit.Size = new System.Drawing.Size(250, 28);
            this.grdfahrenheit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Conversor de Temperatura";
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(243, 232);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(198, 28);
            this.resultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Conversor_Cel_a_Fahr.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdfahrenheit);
            this.Controls.Add(this.grdcelsius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Convertir2);
            this.Controls.Add(this.Convertir);
            this.Name = "Form1";
            this.Text = "Conversor de Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.Button Convertir2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox grdcelsius;
        private System.Windows.Forms.TextBox grdfahrenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultado;
    }
}

