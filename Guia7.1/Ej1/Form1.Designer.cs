namespace Ej1
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
            this.bAgregar = new System.Windows.Forms.Button();
            this.bVer = new System.Windows.Forms.Button();
            this.lBregistros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(62, 24);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(80, 43);
            this.bAgregar.TabIndex = 0;
            this.bAgregar.Text = "Agregar registro";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bVer
            // 
            this.bVer.Location = new System.Drawing.Point(253, 24);
            this.bVer.Name = "bVer";
            this.bVer.Size = new System.Drawing.Size(80, 43);
            this.bVer.TabIndex = 1;
            this.bVer.Text = "Ver registros";
            this.bVer.UseVisualStyleBackColor = true;
            this.bVer.Click += new System.EventHandler(this.bVer_Click);
            // 
            // lBregistros
            // 
            this.lBregistros.FormattingEnabled = true;
            this.lBregistros.Location = new System.Drawing.Point(12, 83);
            this.lBregistros.Name = "lBregistros";
            this.lBregistros.Size = new System.Drawing.Size(379, 160);
            this.lBregistros.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 292);
            this.Controls.Add(this.lBregistros);
            this.Controls.Add(this.bVer);
            this.Controls.Add(this.bAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bVer;
        private System.Windows.Forms.ListBox lBregistros;
    }
}

