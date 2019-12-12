namespace TrackerUI
{
    partial class ModificarSeguroForm
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
            this.ListaDeSegurosList = new System.Windows.Forms.ListView();
            this.IdSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AseguradoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompañiaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObservacionesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListadoDeSegurosLabel = new System.Windows.Forms.Label();
            this.SeleccionarSeguroLabel = new System.Windows.Forms.Label();
            this.ModificacionesLabel = new System.Windows.Forms.Label();
            this.EspecificacionesTextBox = new System.Windows.Forms.TextBox();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SolicitarModificacionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.ListaDeSegurosList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDeSegurosList.HideSelection = false;
            this.ListaDeSegurosList.Location = new System.Drawing.Point(12, 113);
            this.ListaDeSegurosList.Name = "ListaDeSegurosList";
            this.ListaDeSegurosList.Size = new System.Drawing.Size(1024, 274);
            this.ListaDeSegurosList.TabIndex = 4;
            this.ListaDeSegurosList.UseCompatibleStateImageBehavior = false;
            this.ListaDeSegurosList.View = System.Windows.Forms.View.Details;
            this.ListaDeSegurosList.SelectedIndexChanged += new System.EventHandler(this.ListaDeSegurosList_SelectedIndexChanged);
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
            this.ListadoDeSegurosLabel.Location = new System.Drawing.Point(358, 9);
            this.ListadoDeSegurosLabel.Name = "ListadoDeSegurosLabel";
            this.ListadoDeSegurosLabel.Size = new System.Drawing.Size(291, 45);
            this.ListadoDeSegurosLabel.TabIndex = 3;
            this.ListadoDeSegurosLabel.Text = "Listado de Seguros";
            // 
            // SeleccionarSeguroLabel
            // 
            this.SeleccionarSeguroLabel.AutoSize = true;
            this.SeleccionarSeguroLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionarSeguroLabel.Location = new System.Drawing.Point(12, 65);
            this.SeleccionarSeguroLabel.Name = "SeleccionarSeguroLabel";
            this.SeleccionarSeguroLabel.Size = new System.Drawing.Size(483, 45);
            this.SeleccionarSeguroLabel.TabIndex = 5;
            this.SeleccionarSeguroLabel.Text = "Seleccione un seguro de la lista: ";
            // 
            // ModificacionesLabel
            // 
            this.ModificacionesLabel.AutoSize = true;
            this.ModificacionesLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionesLabel.Location = new System.Drawing.Point(12, 411);
            this.ModificacionesLabel.Name = "ModificacionesLabel";
            this.ModificacionesLabel.Size = new System.Drawing.Size(295, 45);
            this.ModificacionesLabel.TabIndex = 6;
            this.ModificacionesLabel.Text = "Cambios a realizar: ";
            // 
            // EspecificacionesTextBox
            // 
            this.EspecificacionesTextBox.Location = new System.Drawing.Point(292, 411);
            this.EspecificacionesTextBox.Multiline = true;
            this.EspecificacionesTextBox.Name = "EspecificacionesTextBox";
            this.EspecificacionesTextBox.Size = new System.Drawing.Size(744, 180);
            this.EspecificacionesTextBox.TabIndex = 7;
            this.EspecificacionesTextBox.Text = "Ingrese las especificaciones...";
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(230, 636);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(151, 55);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            // 
            // SolicitarModificacionButton
            // 
            this.SolicitarModificacionButton.Location = new System.Drawing.Point(507, 636);
            this.SolicitarModificacionButton.Name = "SolicitarModificacionButton";
            this.SolicitarModificacionButton.Size = new System.Drawing.Size(336, 55);
            this.SolicitarModificacionButton.TabIndex = 9;
            this.SolicitarModificacionButton.Text = "Solicitar Modificación";
            this.SolicitarModificacionButton.UseVisualStyleBackColor = true;
            // 
            // ModificarSeguroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 722);
            this.Controls.Add(this.SolicitarModificacionButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EspecificacionesTextBox);
            this.Controls.Add(this.ModificacionesLabel);
            this.Controls.Add(this.SeleccionarSeguroLabel);
            this.Controls.Add(this.ListaDeSegurosList);
            this.Controls.Add(this.ListadoDeSegurosLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.Name = "ModificarSeguroForm";
            this.Text = "Modificar Seguro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListaDeSegurosList;
        private System.Windows.Forms.ColumnHeader IdSeguroColumn;
        private System.Windows.Forms.ColumnHeader AseguradoColumn;
        private System.Windows.Forms.ColumnHeader CompañiaColumn;
        private System.Windows.Forms.ColumnHeader TipoSeguroColumn;
        private System.Windows.Forms.ColumnHeader EstadoSeguroColumn;
        private System.Windows.Forms.ColumnHeader ObservacionesColumn;
        private System.Windows.Forms.Label ListadoDeSegurosLabel;
        private System.Windows.Forms.Label SeleccionarSeguroLabel;
        private System.Windows.Forms.Label ModificacionesLabel;
        private System.Windows.Forms.TextBox EspecificacionesTextBox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button SolicitarModificacionButton;
    }
}