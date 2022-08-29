namespace controlador_final
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
            this.BtnBuscarPuertos = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnEnviarDatos = new System.Windows.Forms.Button();
            this.CboPuertos = new System.Windows.Forms.ComboBox();
            this.CboBoudRate = new System.Windows.Forms.ComboBox();
            this.LblBoudRate = new System.Windows.Forms.Label();
            this.LblDatosIngreso = new System.Windows.Forms.Label();
            this.TxtDatosAEnviar = new System.Windows.Forms.TextBox();
            this.TxtDatosRecividos = new System.Windows.Forms.TextBox();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBuscarPuertos
            // 
            this.BtnBuscarPuertos.Location = new System.Drawing.Point(76, 56);
            this.BtnBuscarPuertos.Name = "BtnBuscarPuertos";
            this.BtnBuscarPuertos.Size = new System.Drawing.Size(119, 23);
            this.BtnBuscarPuertos.TabIndex = 0;
            this.BtnBuscarPuertos.Text = "BUSCAR PUERTOS";
            this.BtnBuscarPuertos.UseVisualStyleBackColor = true;
            this.BtnBuscarPuertos.Click += new System.EventHandler(this.BtnBuscarPuertos_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(475, 56);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 23);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "CONECTAR";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnEnviarDatos
            // 
            this.BtnEnviarDatos.Location = new System.Drawing.Point(76, 208);
            this.BtnEnviarDatos.Name = "BtnEnviarDatos";
            this.BtnEnviarDatos.Size = new System.Drawing.Size(119, 23);
            this.BtnEnviarDatos.TabIndex = 2;
            this.BtnEnviarDatos.Text = "Enviar Datos";
            this.BtnEnviarDatos.UseVisualStyleBackColor = true;
            this.BtnEnviarDatos.Click += new System.EventHandler(this.BtnEnviarDatos_Click);
            // 
            // CboPuertos
            // 
            this.CboPuertos.FormattingEnabled = true;
            this.CboPuertos.Location = new System.Drawing.Point(201, 58);
            this.CboPuertos.Name = "CboPuertos";
            this.CboPuertos.Size = new System.Drawing.Size(121, 21);
            this.CboPuertos.TabIndex = 3;
            // 
            // CboBoudRate
            // 
            this.CboBoudRate.FormattingEnabled = true;
            this.CboBoudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.CboBoudRate.Location = new System.Drawing.Point(201, 128);
            this.CboBoudRate.Name = "CboBoudRate";
            this.CboBoudRate.Size = new System.Drawing.Size(121, 21);
            this.CboBoudRate.TabIndex = 4;
            this.CboBoudRate.Text = "9600";
            // 
            // LblBoudRate
            // 
            this.LblBoudRate.AutoSize = true;
            this.LblBoudRate.Location = new System.Drawing.Point(110, 136);
            this.LblBoudRate.Name = "LblBoudRate";
            this.LblBoudRate.Size = new System.Drawing.Size(58, 13);
            this.LblBoudRate.TabIndex = 5;
            this.LblBoudRate.Text = "Baud Rate";
            // 
            // LblDatosIngreso
            // 
            this.LblDatosIngreso.AutoSize = true;
            this.LblDatosIngreso.Location = new System.Drawing.Point(110, 269);
            this.LblDatosIngreso.Name = "LblDatosIngreso";
            this.LblDatosIngreso.Size = new System.Drawing.Size(85, 13);
            this.LblDatosIngreso.TabIndex = 6;
            this.LblDatosIngreso.Text = "Datos Recividos";
            // 
            // TxtDatosAEnviar
            // 
            this.TxtDatosAEnviar.Location = new System.Drawing.Point(222, 210);
            this.TxtDatosAEnviar.Name = "TxtDatosAEnviar";
            this.TxtDatosAEnviar.Size = new System.Drawing.Size(306, 20);
            this.TxtDatosAEnviar.TabIndex = 7;
            // 
            // TxtDatosRecividos
            // 
            this.TxtDatosRecividos.Location = new System.Drawing.Point(222, 266);
            this.TxtDatosRecividos.Name = "TxtDatosRecividos";
            this.TxtDatosRecividos.Size = new System.Drawing.Size(306, 20);
            this.TxtDatosRecividos.TabIndex = 8;
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 68);
            this.button1.TabIndex = 9;
            this.button1.Text = "ENCENDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 78);
            this.button2.TabIndex = 10;
            this.button2.Text = "Apagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtDatosRecividos);
            this.Controls.Add(this.TxtDatosAEnviar);
            this.Controls.Add(this.LblDatosIngreso);
            this.Controls.Add(this.LblBoudRate);
            this.Controls.Add(this.CboBoudRate);
            this.Controls.Add(this.CboPuertos);
            this.Controls.Add(this.BtnEnviarDatos);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnBuscarPuertos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnEnviarDatos;
        private System.Windows.Forms.ComboBox CboPuertos;
        private System.Windows.Forms.ComboBox CboBoudRate;
        private System.Windows.Forms.Label LblBoudRate;
        private System.Windows.Forms.Label LblDatosIngreso;
        private System.Windows.Forms.TextBox TxtDatosAEnviar;
        private System.Windows.Forms.TextBox TxtDatosRecividos;
        private System.IO.Ports.SerialPort SpPuertos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

