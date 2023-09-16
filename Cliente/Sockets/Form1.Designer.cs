namespace Sockets
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.getHostName = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtNeighboringIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getHostName
            // 
            this.getHostName.Cursor = System.Windows.Forms.Cursors.Default;
            this.getHostName.Location = new System.Drawing.Point(34, 67);
            this.getHostName.Name = "getHostName";
            this.getHostName.Size = new System.Drawing.Size(144, 38);
            this.getHostName.TabIndex = 0;
            this.getHostName.Text = "OPTENER NOMBRE DEL HOST";
            this.getHostName.UseVisualStyleBackColor = true;
            this.getHostName.Click += new System.EventHandler(this.getHostName_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(283, 111);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(130, 20);
            this.txtHostName.TabIndex = 1;
            // 
            // txtNeighboringIP
            // 
            this.txtNeighboringIP.Location = new System.Drawing.Point(283, 67);
            this.txtNeighboringIP.Name = "txtNeighboringIP";
            this.txtNeighboringIP.Size = new System.Drawing.Size(130, 20);
            this.txtNeighboringIP.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 225);
            this.Controls.Add(this.txtNeighboringIP);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.getHostName);
            this.Name = "Form1";
            this.Text = "Cliente Socket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getHostName;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtNeighboringIP;
    }
}

