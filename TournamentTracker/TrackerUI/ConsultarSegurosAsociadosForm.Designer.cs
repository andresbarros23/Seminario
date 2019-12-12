namespace TrackerUI
{
    partial class ConsultarSegurosAsociadosForm
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
            this.ListadoDeSegurosLabel = new System.Windows.Forms.Label();
            this.ListaDeSegurosList = new System.Windows.Forms.ListView();
            this.IdSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AseguradoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompañiaColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoSeguroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObservacionesColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VolverButton = new System.Windows.Forms.Button();
            this.VerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListadoDeSegurosLabel
            // 
            this.ListadoDeSegurosLabel.AutoSize = true;
            this.ListadoDeSegurosLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListadoDeSegurosLabel.Location = new System.Drawing.Point(224, 9);
            this.ListadoDeSegurosLabel.Name = "ListadoDeSegurosLabel";
            this.ListadoDeSegurosLabel.Size = new System.Drawing.Size(291, 45);
            this.ListadoDeSegurosLabel.TabIndex = 0;
            this.ListadoDeSegurosLabel.Text = "Listado de Seguros";
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
            this.ListaDeSegurosList.Location = new System.Drawing.Point(12, 57);
            this.ListaDeSegurosList.Name = "ListaDeSegurosList";
            this.ListaDeSegurosList.Size = new System.Drawing.Size(725, 274);
            this.ListaDeSegurosList.TabIndex = 2;
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
            this.AseguradoColumn.Width = 100;
            // 
            // CompañiaColumn
            // 
            this.CompañiaColumn.Text = "Compañia";
            this.CompañiaColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CompañiaColumn.Width = 100;
            // 
            // TipoSeguroColumn
            // 
            this.TipoSeguroColumn.Text = "Tipo Seguro";
            this.TipoSeguroColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipoSeguroColumn.Width = 100;
            // 
            // EstadoSeguroColumn
            // 
            this.EstadoSeguroColumn.Text = "Estado";
            this.EstadoSeguroColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EstadoSeguroColumn.Width = 100;
            // 
            // ObservacionesColumn
            // 
            this.ObservacionesColumn.Text = "Observaciones";
            this.ObservacionesColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ObservacionesColumn.Width = 241;
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(481, 374);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(118, 42);
            this.VolverButton.TabIndex = 3;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            // 
            // VerButton
            // 
            this.VerButton.Location = new System.Drawing.Point(619, 374);
            this.VerButton.Name = "VerButton";
            this.VerButton.Size = new System.Drawing.Size(118, 42);
            this.VerButton.TabIndex = 4;
            this.VerButton.Text = "Ver";
            this.VerButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarSegurosAsociadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.VerButton);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.ListaDeSegurosList);
            this.Controls.Add(this.ListadoDeSegurosLabel);
            this.Name = "ConsultarSegurosAsociadosForm";
            this.Text = "Consultar Seguros Asociados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListadoDeSegurosLabel;
        private System.Windows.Forms.ListView ListaDeSegurosList;
        private System.Windows.Forms.ColumnHeader IdSeguroColumn;
        private System.Windows.Forms.ColumnHeader AseguradoColumn;
        private System.Windows.Forms.ColumnHeader CompañiaColumn;
        private System.Windows.Forms.ColumnHeader TipoSeguroColumn;
        private System.Windows.Forms.ColumnHeader EstadoSeguroColumn;
        private System.Windows.Forms.ColumnHeader ObservacionesColumn;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Button VerButton;
    }
}