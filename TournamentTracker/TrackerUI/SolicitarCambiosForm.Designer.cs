namespace TrackerUI
{
    partial class SolicitarCambiosForm
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
            this.TipoDeCambioLabel = new System.Windows.Forms.Label();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ModificarButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TipoDeCambioLabel
            // 
            this.TipoDeCambioLabel.AutoSize = true;
            this.TipoDeCambioLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoDeCambioLabel.Location = new System.Drawing.Point(49, 25);
            this.TipoDeCambioLabel.Name = "TipoDeCambioLabel";
            this.TipoDeCambioLabel.Size = new System.Drawing.Size(534, 45);
            this.TipoDeCambioLabel.TabIndex = 0;
            this.TipoDeCambioLabel.Text = "¿Qué tipo de cambio desea realizar?";
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(238, 107);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(186, 62);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // ModificarButton
            // 
            this.ModificarButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificarButton.Location = new System.Drawing.Point(238, 203);
            this.ModificarButton.Name = "ModificarButton";
            this.ModificarButton.Size = new System.Drawing.Size(186, 62);
            this.ModificarButton.TabIndex = 2;
            this.ModificarButton.Text = "Modificar";
            this.ModificarButton.UseVisualStyleBackColor = true;
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(238, 302);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(186, 62);
            this.BajaButton.TabIndex = 3;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            this.VolverButton.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverButton.Location = new System.Drawing.Point(465, 384);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(118, 54);
            this.VolverButton.TabIndex = 4;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SolicitarCambiosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificarButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.TipoDeCambioLabel);
            this.Name = "SolicitarCambiosForm";
            this.Text = "Solicitar Cambios de Seguros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipoDeCambioLabel;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button ModificarButton;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button VolverButton;
    }
}