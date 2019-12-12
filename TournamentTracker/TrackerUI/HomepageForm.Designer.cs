namespace TrackerUI
{
    partial class HomepageForm
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
            this.BienvenidoLabel = new System.Windows.Forms.Label();
            this.QueNecesitoHacerLabel = new System.Windows.Forms.Label();
            this.NombreYApellidoLabel = new System.Windows.Forms.Label();
            this.ConsultarSegurosButton = new System.Windows.Forms.Button();
            this.ConsultarSeguroEspecificoButton = new System.Windows.Forms.Button();
            this.SolicitarCambiosButton = new System.Windows.Forms.Button();
            this.MiCuentaButton = new System.Windows.Forms.Button();
            this.CerrarSesionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BienvenidoLabel
            // 
            this.BienvenidoLabel.AutoSize = true;
            this.BienvenidoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BienvenidoLabel.Location = new System.Drawing.Point(47, 66);
            this.BienvenidoLabel.Name = "BienvenidoLabel";
            this.BienvenidoLabel.Size = new System.Drawing.Size(184, 45);
            this.BienvenidoLabel.TabIndex = 0;
            this.BienvenidoLabel.Text = "Bienvenido,";
            this.BienvenidoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // QueNecesitoHacerLabel
            // 
            this.QueNecesitoHacerLabel.AutoSize = true;
            this.QueNecesitoHacerLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueNecesitoHacerLabel.Location = new System.Drawing.Point(310, 186);
            this.QueNecesitoHacerLabel.Name = "QueNecesitoHacerLabel";
            this.QueNecesitoHacerLabel.Size = new System.Drawing.Size(332, 45);
            this.QueNecesitoHacerLabel.TabIndex = 1;
            this.QueNecesitoHacerLabel.Text = "¿Qué necesitas hacer?";
            // 
            // NombreYApellidoLabel
            // 
            this.NombreYApellidoLabel.AutoSize = true;
            this.NombreYApellidoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreYApellidoLabel.Location = new System.Drawing.Point(228, 66);
            this.NombreYApellidoLabel.Name = "NombreYApellidoLabel";
            this.NombreYApellidoLabel.Size = new System.Drawing.Size(334, 45);
            this.NombreYApellidoLabel.TabIndex = 2;
            this.NombreYApellidoLabel.Text = "<Nombre y Apellido>";
            this.NombreYApellidoLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConsultarSegurosButton
            // 
            this.ConsultarSegurosButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ConsultarSegurosButton.Location = new System.Drawing.Point(349, 285);
            this.ConsultarSegurosButton.Name = "ConsultarSegurosButton";
            this.ConsultarSegurosButton.Size = new System.Drawing.Size(254, 75);
            this.ConsultarSegurosButton.TabIndex = 3;
            this.ConsultarSegurosButton.Text = "Consultar Seguros Asociados";
            this.ConsultarSegurosButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarSeguroEspecificoButton
            // 
            this.ConsultarSeguroEspecificoButton.Location = new System.Drawing.Point(349, 402);
            this.ConsultarSeguroEspecificoButton.Name = "ConsultarSeguroEspecificoButton";
            this.ConsultarSeguroEspecificoButton.Size = new System.Drawing.Size(254, 75);
            this.ConsultarSeguroEspecificoButton.TabIndex = 4;
            this.ConsultarSeguroEspecificoButton.Text = "Consultar Seguro Específico";
            this.ConsultarSeguroEspecificoButton.UseVisualStyleBackColor = true;
            // 
            // SolicitarCambiosButton
            // 
            this.SolicitarCambiosButton.Location = new System.Drawing.Point(349, 516);
            this.SolicitarCambiosButton.Name = "SolicitarCambiosButton";
            this.SolicitarCambiosButton.Size = new System.Drawing.Size(254, 75);
            this.SolicitarCambiosButton.TabIndex = 5;
            this.SolicitarCambiosButton.Text = "Solicitar Cambios En Seguro";
            this.SolicitarCambiosButton.UseVisualStyleBackColor = true;
            this.SolicitarCambiosButton.Click += new System.EventHandler(this.SolicitarCambios_Click);
            // 
            // MiCuentaButton
            // 
            this.MiCuentaButton.Location = new System.Drawing.Point(666, 66);
            this.MiCuentaButton.Name = "MiCuentaButton";
            this.MiCuentaButton.Size = new System.Drawing.Size(114, 45);
            this.MiCuentaButton.TabIndex = 6;
            this.MiCuentaButton.Text = "Mi Cuenta";
            this.MiCuentaButton.UseVisualStyleBackColor = true;
            // 
            // CerrarSesionButton
            // 
            this.CerrarSesionButton.Location = new System.Drawing.Point(799, 66);
            this.CerrarSesionButton.Name = "CerrarSesionButton";
            this.CerrarSesionButton.Size = new System.Drawing.Size(115, 45);
            this.CerrarSesionButton.TabIndex = 7;
            this.CerrarSesionButton.Text = "Cerrar Sesión";
            this.CerrarSesionButton.UseVisualStyleBackColor = true;
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(926, 633);
            this.Controls.Add(this.CerrarSesionButton);
            this.Controls.Add(this.MiCuentaButton);
            this.Controls.Add(this.SolicitarCambiosButton);
            this.Controls.Add(this.ConsultarSeguroEspecificoButton);
            this.Controls.Add(this.ConsultarSegurosButton);
            this.Controls.Add(this.NombreYApellidoLabel);
            this.Controls.Add(this.QueNecesitoHacerLabel);
            this.Controls.Add(this.BienvenidoLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "HomepageForm";
            this.Text = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BienvenidoLabel;
        private System.Windows.Forms.Label QueNecesitoHacerLabel;
        private System.Windows.Forms.Label NombreYApellidoLabel;
        private System.Windows.Forms.Button ConsultarSegurosButton;
        private System.Windows.Forms.Button ConsultarSeguroEspecificoButton;
        private System.Windows.Forms.Button SolicitarCambiosButton;
        private System.Windows.Forms.Button MiCuentaButton;
        private System.Windows.Forms.Button CerrarSesionButton;
    }
}

