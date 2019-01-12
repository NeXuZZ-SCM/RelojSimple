namespace PrincipalReloj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.lbl_anio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDataTime = new System.Windows.Forms.Label();
            this.lbl_ciudad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_temp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_humedad = new System.Windows.Forms.Label();
            this.lbl_presion = new System.Windows.Forms.Label();
            this.lbl_uPr = new System.Windows.Forms.Label();
            this.lbl_cielo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(329, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Parar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.ForeColor = System.Drawing.Color.White;
            this.btn_iniciar.Location = new System.Drawing.Point(329, 65);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 2;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Visible = false;
            this.btn_iniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Mes.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mes.ForeColor = System.Drawing.Color.White;
            this.lbl_Mes.Location = new System.Drawing.Point(161, 124);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(56, 42);
            this.lbl_Mes.TabIndex = 3;
            this.lbl_Mes.Text = "00";
            // 
            // lbl_anio
            // 
            this.lbl_anio.AutoSize = true;
            this.lbl_anio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_anio.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anio.ForeColor = System.Drawing.Color.White;
            this.lbl_anio.Location = new System.Drawing.Point(160, 178);
            this.lbl_anio.Name = "lbl_anio";
            this.lbl_anio.Size = new System.Drawing.Size(94, 42);
            this.lbl_anio.TabIndex = 4;
            this.lbl_anio.Text = "0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Año:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mes:";
            // 
            // lblDataTime
            // 
            this.lblDataTime.AutoSize = true;
            this.lblDataTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDataTime.Font = new System.Drawing.Font("DS-Digital", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTime.ForeColor = System.Drawing.Color.White;
            this.lblDataTime.Location = new System.Drawing.Point(108, 37);
            this.lblDataTime.Name = "lblDataTime";
            this.lblDataTime.Size = new System.Drawing.Size(241, 63);
            this.lblDataTime.TabIndex = 0;
            this.lblDataTime.Text = "00:00:00";
            this.lblDataTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ciudad
            // 
            this.lbl_ciudad.AutoSize = true;
            this.lbl_ciudad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ciudad.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ciudad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_ciudad.Location = new System.Drawing.Point(32, 237);
            this.lbl_ciudad.Name = "lbl_ciudad";
            this.lbl_ciudad.Size = new System.Drawing.Size(328, 33);
            this.lbl_ciudad.TabIndex = 8;
            this.lbl_ciudad.Text = "Ciudad de Buenos Aires";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(50, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Temperatura:";
            // 
            // lbl_temp
            // 
            this.lbl_temp.AutoSize = true;
            this.lbl_temp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_temp.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_temp.Location = new System.Drawing.Point(240, 283);
            this.lbl_temp.Name = "lbl_temp";
            this.lbl_temp.Size = new System.Drawing.Size(45, 33);
            this.lbl_temp.TabIndex = 10;
            this.lbl_temp.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(77, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Humedad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(106, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Presión:";
            // 
            // lbl_humedad
            // 
            this.lbl_humedad.AutoSize = true;
            this.lbl_humedad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_humedad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_humedad.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_humedad.Location = new System.Drawing.Point(193, 364);
            this.lbl_humedad.Name = "lbl_humedad";
            this.lbl_humedad.Size = new System.Drawing.Size(47, 22);
            this.lbl_humedad.TabIndex = 17;
            this.lbl_humedad.Text = "Min:";
            // 
            // lbl_presion
            // 
            this.lbl_presion.AutoSize = true;
            this.lbl_presion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_presion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presion.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_presion.Location = new System.Drawing.Point(193, 392);
            this.lbl_presion.Name = "lbl_presion";
            this.lbl_presion.Size = new System.Drawing.Size(47, 22);
            this.lbl_presion.TabIndex = 18;
            this.lbl_presion.Text = "Min:";
            // 
            // lbl_uPr
            // 
            this.lbl_uPr.AutoSize = true;
            this.lbl_uPr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uPr.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uPr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_uPr.Location = new System.Drawing.Point(261, 392);
            this.lbl_uPr.Name = "lbl_uPr";
            this.lbl_uPr.Size = new System.Drawing.Size(47, 22);
            this.lbl_uPr.TabIndex = 19;
            this.lbl_uPr.Text = "Min:";
            // 
            // lbl_cielo
            // 
            this.lbl_cielo.AutoSize = true;
            this.lbl_cielo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cielo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cielo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_cielo.Location = new System.Drawing.Point(125, 325);
            this.lbl_cielo.Name = "lbl_cielo";
            this.lbl_cielo.Size = new System.Drawing.Size(149, 30);
            this.lbl_cielo.TabIndex = 20;
            this.lbl_cielo.Text = "Cielo Claro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::PrincipalReloj.Resource1.asd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 439);
            this.Controls.Add(this.lbl_cielo);
            this.Controls.Add(this.lbl_uPr);
            this.Controls.Add(this.lbl_presion);
            this.Controls.Add(this.lbl_humedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ciudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_anio);
            this.Controls.Add(this.lbl_Mes);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblDataTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reloj Simple";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.Label lbl_anio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataTime;
        private System.Windows.Forms.Label lbl_ciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_temp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_humedad;
        private System.Windows.Forms.Label lbl_presion;
        private System.Windows.Forms.Label lbl_uPr;
        private System.Windows.Forms.Label lbl_cielo;
    }
}

