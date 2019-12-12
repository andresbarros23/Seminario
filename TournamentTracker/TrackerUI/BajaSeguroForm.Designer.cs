namespace TrackerUI
{
    partial class BajaSeguroForm
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
            this.SeleccionarSeguroLabel = new System.Windows.Forms.Label();
            this.ListaDeSegurosList = new System.Windows.Forms.ListView();
            this.IdSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AseguradoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompañiaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObservacionesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListadoDeSegurosLabel = new System.Windows.Forms.Label();
            this.SolicitarBajaButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeleccionarSeguroLabel
            // 
            this.SeleccionarSeguroLabel.AutoSize = true;
            this.SeleccionarSeguroLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarSeguroLabel.Location = new System.Drawing.Point(3, 65);
            this.SeleccionarSeguroLabel.Name = "SeleccionarSeguroLabel";
            this.SeleccionarSeguroLabel.Size = new System.Drawing.Size(483, 45);
            this.SeleccionarSeguroLabel.TabIndex = 8;
            this.SeleccionarSeguroLabel.Text = "Seleccione un seguro de la lista: ";
            // 
            // ListaDeSegurosList
            // 
            this.ListaDeSegurosList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdSeguroColumn,
            this.AseguradoColumn,
            this.CompañiaColumn,
            this.TipoSeguroColumn,
            this.EstadoSeguroColumn,
            this.ObservacionesColumn});
            this.ListaDeSegurosList.HideSelection = false;
            this.ListaDeSegurosList.Location = new System.Drawing.Point(3, 113);
            this.ListaDeSegurosList.Name = "ListaDeSegurosList";
            this.ListaDeSegurosList.Size = new System.Drawing.Size(1024, 274);
            this.ListaDeSegurosList.TabIndex = 7;
            this.ListaDeSegurosList.UseCompatibleStateImageBehavior = false;
            this.ListaDeSegurosList.View = System.Windows.Forms.View.Details;
            // 
            // IdSeguroColumn
            // 
            this.IdSeguroColumn.Text = "Id";
            this.IdSeguroColumn.Width = 80;
            // 
            // AseguradoColumn
            // 
            this.AseguradoColumn.Text = "Asegurado";
            this.AseguradoColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AseguradoColumn.Width = 195;
            // 
            // CompañiaColumn
            // 
            this.CompañiaColumn.Text = "Compañia";
            this.CompañiaColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompañiaColumn.Width = 176;
            // 
            // TipoSeguroColumn
            // 
            this.TipoSeguroColumn.Text = "Tipo Seguro";
            this.TipoSeguroColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipoSeguroColumn.Width = 199;
            // 
            // EstadoSeguroColumn
            // 
            this.EstadoSeguroColumn.Text = "Estado";
            this.EstadoSeguroColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EstadoSeguroColumn.Width = 134;
            // 
            // ObservacionesColumn
            // 
            this.ObservacionesColumn.Text = "Observaciones";
            this.ObservacionesColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ObservacionesColumn.Width = 241;
            // 
            // ListadoDeSegurosLabel
            // 
            this.ListadoDeSegurosLabel.AutoSize = true;
            this.ListadoDeSegurosLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadoDeSegurosLabel.Location = new System.Drawing.Point(349, 9);
            this.ListadoDeSegurosLabel.Name = "ListadoDeSegurosLabel";
            this.ListadoDeSegurosLabel.Size = new System.Drawing.Size(291, 45);
            this.ListadoDeSegurosLabel.TabIndex = 6;
            this.ListadoDeSegurosLabel.Text = "Listado de Seguros";
            // 
            // SolicitarBajaButton
            // 
            this.SolicitarBajaButton.Location = new System.Drawing.Point(509, 432);
            this.SolicitarBajaButton.Name = "SolicitarBajaButton";
            this.SolicitarBajaButton.Size = new System.Drawing.Size(336, 55);
            this.SolicitarBajaButton.TabIndex = 11;
            this.SolicitarBajaButton.Text = "Solicitar Baja";
            this.SolicitarBajaButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(232, 432);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(151, 55);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // BajaSeguroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 499);
            this.Controls.Add(this.SolicitarBajaButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.SeleccionarSeguroLabel);
            this.Controls.Add(this.ListaDeSegurosList);
            this.Controls.Add(this.ListadoDeSegurosLabel);
            this.Name = "BajaSeguroForm";
            this.Text = "Baja Seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SeleccionarSeguroLabel;
        private System.Windows.Forms.ListView ListaDeSegurosList;
        private System.Windows.Forms.ColumnHeader IdSeguroColumn;
        private System.Windows.Forms.ColumnHeader AseguradoColumn;
        private System.Windows.Forms.ColumnHeader CompañiaColumn;
        private System.Windows.Forms.ColumnHeader TipoSeguroColumn;
        private System.Windows.Forms.ColumnHeader EstadoSeguroColumn;
        private System.Windows.Forms.ColumnHeader ObservacionesColumn;
        private System.Windows.Forms.Label ListadoDeSegurosLabel;
        private System.Windows.Forms.Button SolicitarBajaButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}