namespace TrackerUI
{
    partial class AltaSeguroForm
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
            this.AltaSeguroLabel = new System.Windows.Forms.Label();
            this.ProductorLabel = new System.Windows.Forms.Label();
            this.ProductorCombo = new System.Windows.Forms.ComboBox();
            this.CompañiaLabel = new System.Windows.Forms.Label();
            this.CompañiaCombo = new System.Windows.Forms.ComboBox();
            this.EspecificacionesLabel = new System.Windows.Forms.Label();
            this.EspecificacionesTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SolicitarAltaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AltaSeguroLabel
            // 
            this.AltaSeguroLabel.AutoSize = true;
            this.AltaSeguroLabel.Location = new System.Drawing.Point(232, 9);
            this.AltaSeguroLabel.Name = "AltaSeguroLabel";
            this.AltaSeguroLabel.Size = new System.Drawing.Size(186, 45);
            this.AltaSeguroLabel.TabIndex = 0;
            this.AltaSeguroLabel.Text = "Alta Seguro";
            // 
            // ProductorLabel
            // 
            this.ProductorLabel.AutoSize = true;
            this.ProductorLabel.Location = new System.Drawing.Point(12, 72);
            this.ProductorLabel.Name = "ProductorLabel";
            this.ProductorLabel.Size = new System.Drawing.Size(168, 45);
            this.ProductorLabel.TabIndex = 1;
            this.ProductorLabel.Text = "Productor:";
            this.ProductorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductorCombo
            // 
            this.ProductorCombo.FormattingEnabled = true;
            this.ProductorCombo.ItemHeight = 45;
            this.ProductorCombo.Items.AddRange(new object[] {
            "Seleccione un productor...",
            "Andrés Barros"});
            this.ProductorCombo.Location = new System.Drawing.Point(186, 72);
            this.ProductorCombo.Name = "ProductorCombo";
            this.ProductorCombo.Size = new System.Drawing.Size(456, 53);
            this.ProductorCombo.TabIndex = 2;
            this.ProductorCombo.Text = "Seleccione un productor...";
            // 
            // CompañiaLabel
            // 
            this.CompañiaLabel.AutoSize = true;
            this.CompañiaLabel.Location = new System.Drawing.Point(12, 160);
            this.CompañiaLabel.Name = "CompañiaLabel";
            this.CompañiaLabel.Size = new System.Drawing.Size(171, 45);
            this.CompañiaLabel.TabIndex = 3;
            this.CompañiaLabel.Text = "Compañía:";
            this.CompañiaLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CompañiaCombo
            // 
            this.CompañiaCombo.FormattingEnabled = true;
            this.CompañiaCombo.ItemHeight = 45;
            this.CompañiaCombo.Items.AddRange(new object[] {
            "Andrés Barros"});
            this.CompañiaCombo.Location = new System.Drawing.Point(189, 160);
            this.CompañiaCombo.Name = "CompañiaCombo";
            this.CompañiaCombo.Size = new System.Drawing.Size(453, 53);
            this.CompañiaCombo.TabIndex = 4;
            this.CompañiaCombo.Text = "Seleccione una compañia...";
            // 
            // EspecificacionesLabel
            // 
            this.EspecificacionesLabel.AutoSize = true;
            this.EspecificacionesLabel.Location = new System.Drawing.Point(9, 241);
            this.EspecificacionesLabel.Name = "EspecificacionesLabel";
            this.EspecificacionesLabel.Size = new System.Drawing.Size(256, 45);
            this.EspecificacionesLabel.TabIndex = 5;
            this.EspecificacionesLabel.Text = "Especificaciones:";
            this.EspecificacionesLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // EspecificacionesTextBox
            // 
            this.EspecificacionesTextBox.Location = new System.Drawing.Point(257, 241);
            this.EspecificacionesTextBox.Multiline = true;
            this.EspecificacionesTextBox.Name = "EspecificacionesTextBox";
            this.EspecificacionesTextBox.Size = new System.Drawing.Size(385, 180);
            this.EspecificacionesTextBox.TabIndex = 6;
            this.EspecificacionesTextBox.Text = "Ingrese las especificaciones...";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(114, 479);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(151, 55);
            this.CancelarButton.TabIndex = 7;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // SolicitarAltaButton
            // 
            this.SolicitarAltaButton.Location = new System.Drawing.Point(319, 479);
            this.SolicitarAltaButton.Name = "SolicitarAltaButton";
            this.SolicitarAltaButton.Size = new System.Drawing.Size(245, 55);
            this.SolicitarAltaButton.TabIndex = 8;
            this.SolicitarAltaButton.Text = "Solicitar Alta";
            this.SolicitarAltaButton.UseVisualStyleBackColor = true;
            // 
            // AltaSeguroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 563);
            this.Controls.Add(this.SolicitarAltaButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EspecificacionesTextBox);
            this.Controls.Add(this.EspecificacionesLabel);
            this.Controls.Add(this.CompañiaCombo);
            this.Controls.Add(this.CompañiaLabel);
            this.Controls.Add(this.ProductorCombo);
            this.Controls.Add(this.ProductorLabel);
            this.Controls.Add(this.AltaSeguroLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "AltaSeguroForm";
            this.Text = "Alta Seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AltaSeguroLabel;
        private System.Windows.Forms.Label ProductorLabel;
        private System.Windows.Forms.ComboBox ProductorCombo;
        private System.Windows.Forms.Label CompañiaLabel;
        private System.Windows.Forms.ComboBox CompañiaCombo;
        private System.Windows.Forms.Label EspecificacionesLabel;
        private System.Windows.Forms.TextBox EspecificacionesTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SolicitarAltaButton;
    }
}