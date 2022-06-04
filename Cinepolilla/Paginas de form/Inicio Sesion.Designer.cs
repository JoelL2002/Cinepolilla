namespace Cinepolilla
{
    partial class Inicio_Sesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio_Sesion));
            this.textBoxN_Usuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.linkLabelCrearCuenta = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.checkBoxVercontra = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxN_Usuario
            // 
            this.textBoxN_Usuario.Location = new System.Drawing.Point(203, 116);
            this.textBoxN_Usuario.Margin = new System.Windows.Forms.Padding(6, 2, 2, 2);
            this.textBoxN_Usuario.Name = "textBoxN_Usuario";
            this.textBoxN_Usuario.Size = new System.Drawing.Size(146, 20);
            this.textBoxN_Usuario.TabIndex = 0;
            this.textBoxN_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(203, 153);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(146, 20);
            this.textBoxContraseña.TabIndex = 1;
            this.textBoxContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxContraseña.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(50, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(77, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(91, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.MinimumSize = new System.Drawing.Size(150, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 64);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cinepolilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(358, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(244, 234);
            this.buttonIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(75, 37);
            this.buttonIngreso.TabIndex = 6;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // linkLabelCrearCuenta
            // 
            this.linkLabelCrearCuenta.AutoSize = true;
            this.linkLabelCrearCuenta.Location = new System.Drawing.Point(291, 194);
            this.linkLabelCrearCuenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelCrearCuenta.Name = "linkLabelCrearCuenta";
            this.linkLabelCrearCuenta.Size = new System.Drawing.Size(77, 15);
            this.linkLabelCrearCuenta.TabIndex = 7;
            this.linkLabelCrearCuenta.TabStop = true;
            this.linkLabelCrearCuenta.Text = "Crear cuenta";
            this.linkLabelCrearCuenta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearCuenta_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(166, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(472, 331);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(72, 22);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // checkBoxVercontra
            // 
            this.checkBoxVercontra.AutoSize = true;
            this.checkBoxVercontra.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBoxVercontra.Location = new System.Drawing.Point(371, 156);
            this.checkBoxVercontra.Name = "checkBoxVercontra";
            this.checkBoxVercontra.Size = new System.Drawing.Size(111, 19);
            this.checkBoxVercontra.TabIndex = 10;
            this.checkBoxVercontra.Text = "Ver contraseña";
            this.checkBoxVercontra.UseVisualStyleBackColor = true;
            this.checkBoxVercontra.CheckedChanged += new System.EventHandler(this.checkBoxVercontra_CheckedChanged);
            // 
            // Inicio_Sesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 377);
            this.Controls.Add(this.checkBoxVercontra);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabelCrearCuenta);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxN_Usuario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio_Sesion";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.LinkLabel linkLabelCrearCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.CheckBox checkBoxVercontra;
        public System.Windows.Forms.TextBox textBoxN_Usuario;
        public System.Windows.Forms.TextBox textBoxContraseña;
    }
}

