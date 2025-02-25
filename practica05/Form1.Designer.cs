namespace practica05
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
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtestatura = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.Edad = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbhombre = new System.Windows.Forms.RadioButton();
            this.rbmujer = new System.Windows.Forms.RadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(160, 64);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 26);
            this.txtedad.TabIndex = 0;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(160, 117);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 26);
            this.txttelefono.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(160, 175);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(160, 233);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(100, 26);
            this.txtapellidos.TabIndex = 3;
            // 
            // txtestatura
            // 
            this.txtestatura.Location = new System.Drawing.Point(160, 285);
            this.txtestatura.Name = "txtestatura";
            this.txtestatura.Size = new System.Drawing.Size(100, 26);
            this.txtestatura.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnguardar.Location = new System.Drawing.Point(527, 123);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 42);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // Edad
            // 
            this.Edad.AllowDrop = true;
            this.Edad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Edad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Edad.Enabled = false;
            this.Edad.Font = new System.Drawing.Font("Jokerman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edad.Location = new System.Drawing.Point(309, 56);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(106, 55);
            this.Edad.TabIndex = 6;
            this.Edad.Text = "Edad";
            this.Edad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Edad.Click += new System.EventHandler(this.Edad_Click);
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Showcard Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(318, 123);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(97, 20);
            this.Telefono.TabIndex = 7;
            this.Telefono.Text = "Telefono";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Ravie", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(318, 181);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 22);
            this.Nombre.TabIndex = 8;
            this.Nombre.Text = "Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.Font = new System.Drawing.Font("Bauhaus 93", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(315, 233);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(74, 18);
            this.Apellidos.TabIndex = 9;
            this.Apellidos.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estatura";
            // 
            // rbhombre
            // 
            this.rbhombre.AutoSize = true;
            this.rbhombre.Location = new System.Drawing.Point(556, 203);
            this.rbhombre.Name = "rbhombre";
            this.rbhombre.Size = new System.Drawing.Size(91, 24);
            this.rbhombre.TabIndex = 11;
            this.rbhombre.TabStop = true;
            this.rbhombre.Text = "Hombre";
            this.rbhombre.UseVisualStyleBackColor = true;
            // 
            // rbmujer
            // 
            this.rbmujer.AutoSize = true;
            this.rbmujer.Location = new System.Drawing.Point(556, 258);
            this.rbmujer.Name = "rbmujer";
            this.rbmujer.Size = new System.Drawing.Size(73, 24);
            this.rbmujer.TabIndex = 12;
            this.rbmujer.TabStop = true;
            this.rbmujer.Text = "Mujer";
            this.rbmujer.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncancelar.Location = new System.Drawing.Point(527, 56);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(105, 42);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(787, 444);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.rbmujer);
            this.Controls.Add(this.rbhombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtestatura);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtedad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtestatura;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbhombre;
        private System.Windows.Forms.RadioButton rbmujer;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label Edad;
    }
}

