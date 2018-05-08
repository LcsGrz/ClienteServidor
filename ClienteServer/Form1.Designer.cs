namespace ClienteServer
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
            this.tbRecibido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbEnviarDato = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIPMIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRecibido
            // 
            this.tbRecibido.Location = new System.Drawing.Point(12, 26);
            this.tbRecibido.Multiline = true;
            this.tbRecibido.Name = "tbRecibido";
            this.tbRecibido.ReadOnly = true;
            this.tbRecibido.Size = new System.Drawing.Size(320, 117);
            this.tbRecibido.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(320, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "ENVIAR DESNUDOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbEnviarDato
            // 
            this.tbEnviarDato.Location = new System.Drawing.Point(12, 192);
            this.tbEnviarDato.Multiline = true;
            this.tbEnviarDato.Name = "tbEnviarDato";
            this.tbEnviarDato.Size = new System.Drawing.Size(320, 55);
            this.tbEnviarDato.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(12, 261);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(25, 13);
            this.lblRuta.TabIndex = 3;
            this.lblRuta.Text = "ruta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(36, 166);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(293, 20);
            this.tbIP.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Texto recibido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP";
            // 
            // lblIPMIA
            // 
            this.lblIPMIA.AutoSize = true;
            this.lblIPMIA.Location = new System.Drawing.Point(155, 385);
            this.lblIPMIA.Name = "lblIPMIA";
            this.lblIPMIA.Size = new System.Drawing.Size(35, 13);
            this.lblIPMIA.TabIndex = 7;
            this.lblIPMIA.Text = "label4";
            this.lblIPMIA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 410);
            this.Controls.Add(this.lblIPMIA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.tbEnviarDato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbRecibido);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRecibido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbEnviarDato;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIPMIA;
    }
}

