namespace SistemaFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.lblGenerar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegAlumno = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblRegPapás = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblFactEmitidas = new System.Windows.Forms.Label();
            this.lblEstadisticas = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblEstadistica = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnEmisores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(196, 9);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(353, 32);
            this.lblOperaciones.TabIndex = 0;
            this.lblOperaciones.Text = "¿Que operacion desea realizar?";
            // 
            // lblGenerar
            // 
            this.lblGenerar.AutoSize = true;
            this.lblGenerar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerar.Location = new System.Drawing.Point(5, 73);
            this.lblGenerar.Name = "lblGenerar";
            this.lblGenerar.Size = new System.Drawing.Size(146, 25);
            this.lblGenerar.TabIndex = 1;
            this.lblGenerar.Text = "Generar Factura";
            this.lblGenerar.Click += new System.EventHandler(this.lblGenerar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.lblGenerar_Click);
            // 
            // lblRegAlumno
            // 
            this.lblRegAlumno.AutoSize = true;
            this.lblRegAlumno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegAlumno.Location = new System.Drawing.Point(527, 77);
            this.lblRegAlumno.Name = "lblRegAlumno";
            this.lblRegAlumno.Size = new System.Drawing.Size(137, 21);
            this.lblRegAlumno.TabIndex = 3;
            this.lblRegAlumno.Text = "Datos de Alumnos";
            this.lblRegAlumno.Click += new System.EventHandler(this.lblRegAlumno_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(542, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lblRegAlumno_Click);
            // 
            // lblRegPapás
            // 
            this.lblRegPapás.AutoSize = true;
            this.lblRegPapás.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPapás.Location = new System.Drawing.Point(310, 77);
            this.lblRegPapás.Name = "lblRegPapás";
            this.lblRegPapás.Size = new System.Drawing.Size(121, 21);
            this.lblRegPapás.TabIndex = 5;
            this.lblRegPapás.Text = "Datos de Padres";
            this.lblRegPapás.Click += new System.EventHandler(this.lblRegPapás_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(309, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 124);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.lblRegPapás_Click);
            // 
            // lblFactEmitidas
            // 
            this.lblFactEmitidas.AutoSize = true;
            this.lblFactEmitidas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactEmitidas.Location = new System.Drawing.Point(7, 252);
            this.lblFactEmitidas.Name = "lblFactEmitidas";
            this.lblFactEmitidas.Size = new System.Drawing.Size(157, 25);
            this.lblFactEmitidas.TabIndex = 7;
            this.lblFactEmitidas.Text = "Facturas Emitidas";
            this.lblFactEmitidas.Click += new System.EventHandler(this.lblFactEmitidas_Click);
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadisticas.Location = new System.Drawing.Point(526, 252);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(150, 25);
            this.lblEstadisticas.TabIndex = 8;
            this.lblEstadisticas.Text = "Salir del Sistema";
            this.lblEstadisticas.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 292);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(115, 124);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.lblFactEmitidas_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(549, 292);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(115, 124);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // lblEstadistica
            // 
            this.lblEstadistica.AutoSize = true;
            this.lblEstadistica.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadistica.Location = new System.Drawing.Point(316, 252);
            this.lblEstadistica.Name = "lblEstadistica";
            this.lblEstadistica.Size = new System.Drawing.Size(108, 25);
            this.lblEstadistica.TabIndex = 11;
            this.lblEstadistica.Text = "Estadisticas";
            this.lblEstadistica.Click += new System.EventHandler(this.lblEstadistica_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(309, 292);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(115, 124);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.lblEstadistica_Click);
            // 
            // btnEmisores
            // 
            this.btnEmisores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmisores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEmisores.Location = new System.Drawing.Point(10, 12);
            this.btnEmisores.Name = "btnEmisores";
            this.btnEmisores.Size = new System.Drawing.Size(180, 32);
            this.btnEmisores.TabIndex = 13;
            this.btnEmisores.Text = "Configurar Emisor";
            this.btnEmisores.UseVisualStyleBackColor = true;
            this.btnEmisores.Click += new System.EventHandler(this.btnEmisores_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(713, 456);
            this.Controls.Add(this.btnEmisores);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblEstadistica);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblEstadisticas);
            this.Controls.Add(this.lblFactEmitidas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblRegPapás);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRegAlumno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGenerar);
            this.Controls.Add(this.lblOperaciones);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form2";
            this.Text = "Sistema de Facturacion - Menú de Operaciones ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.Label lblGenerar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegAlumno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRegPapás;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblFactEmitidas;
        private System.Windows.Forms.Label lblEstadisticas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblEstadistica;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnEmisores;
    }
}