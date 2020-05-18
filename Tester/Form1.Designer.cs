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
            this.btConnect = new System.Windows.Forms.Button();
            this.cbLed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(37, 38);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.BtConnect_Click);
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
            this.cbLed.CheckedChanged += new System.EventHandler(this.CbLed_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 90);
            this.Controls.Add(this.cbLed);
            this.Controls.Add(this.btConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.CheckBox cbLed;
    }
}

