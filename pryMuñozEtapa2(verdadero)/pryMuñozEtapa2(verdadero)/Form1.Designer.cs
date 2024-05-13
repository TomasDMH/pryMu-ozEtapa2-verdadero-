namespace pryMuñozEtapa2_verdadero_
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.pctAuto = new System.Windows.Forms.PictureBox();
            this.pctBarco = new System.Windows.Forms.PictureBox();
            this.pctAvion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Vehiculos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctAuto
            // 
            this.pctAuto.Location = new System.Drawing.Point(12, 12);
            this.pctAuto.Name = "pctAuto";
            this.pctAuto.Size = new System.Drawing.Size(215, 172);
            this.pctAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAuto.TabIndex = 1;
            this.pctAuto.TabStop = false;
            // 
            // pctBarco
            // 
            this.pctBarco.Location = new System.Drawing.Point(454, 12);
            this.pctBarco.Name = "pctBarco";
            this.pctBarco.Size = new System.Drawing.Size(215, 172);
            this.pctBarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBarco.TabIndex = 2;
            this.pctBarco.TabStop = false;
            // 
            // pctAvion
            // 
            this.pctAvion.Location = new System.Drawing.Point(233, 12);
            this.pctAvion.Name = "pctAvion";
            this.pctAvion.Size = new System.Drawing.Size(215, 172);
            this.pctAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAvion.TabIndex = 3;
            this.pctAvion.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 328);
            this.Controls.Add(this.pctAvion);
            this.Controls.Add(this.pctBarco);
            this.Controls.Add(this.pctAuto);
            this.Controls.Add(this.button1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etapa 2";
            ((System.ComponentModel.ISupportInitialize)(this.pctAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAvion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pctAuto;
        private System.Windows.Forms.PictureBox pctBarco;
        private System.Windows.Forms.PictureBox pctAvion;
    }
}

