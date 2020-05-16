namespace Tester
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cbLed = new System.Windows.Forms.CheckBox();
            this.arduino = new BqBusNet.BqBus(this.components);
            this.SuspendLayout();
            // 
            // serial
            // 
            this.serial.PortName = "COM7";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbLed
            // 
            this.cbLed.AutoSize = true;
            this.cbLed.Location = new System.Drawing.Point(178, 42);
            this.cbLed.Name = "cbLed";
            this.cbLed.Size = new System.Drawing.Size(44, 17);
            this.cbLed.TabIndex = 1;
            this.cbLed.Tag = "0";
            this.cbLed.Text = "Led";
            this.cbLed.UseVisualStyleBackColor = true;
            this.cbLed.CheckedChanged += new System.EventHandler(this.cbLed_CheckedChanged);
            // 
            // arduino
            // 
            this.arduino.Serial = this.serial;
            this.arduino.Size = ((ushort)(1));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 90);
            this.Controls.Add(this.cbLed);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbLed;
        private BqBusNet.BqBus arduino;
    }
}

