namespace pryMamondezLibro
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
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigoEditorial = new System.Windows.Forms.Label();
            this.lblCodigoAutor = new System.Windows.Forms.Label();
            this.lblCodigoDistribuidor = new System.Windows.Forms.Label();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoEditorial = new System.Windows.Forms.TextBox();
            this.txtCodigoAutor = new System.Windows.Forms.TextBox();
            this.txtCodigoDistribuidor = new System.Windows.Forms.TextBox();
            this.lblConsultaBiblioteca = new System.Windows.Forms.Label();
            this.cmdAnterior = new System.Windows.Forms.Button();
            this.cmdSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLibro.Location = new System.Drawing.Point(23, 105);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(118, 22);
            this.lblNombreLibro.TabIndex = 0;
            this.lblNombreLibro.Text = "Nombre Libro";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(23, 150);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(67, 22);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblCodigoEditorial
            // 
            this.lblCodigoEditorial.AutoSize = true;
            this.lblCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoEditorial.Location = new System.Drawing.Point(23, 195);
            this.lblCodigoEditorial.Name = "lblCodigoEditorial";
            this.lblCodigoEditorial.Size = new System.Drawing.Size(75, 22);
            this.lblCodigoEditorial.TabIndex = 2;
            this.lblCodigoEditorial.Text = "Editorial";
            // 
            // lblCodigoAutor
            // 
            this.lblCodigoAutor.AutoSize = true;
            this.lblCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAutor.Location = new System.Drawing.Point(23, 240);
            this.lblCodigoAutor.Name = "lblCodigoAutor";
            this.lblCodigoAutor.Size = new System.Drawing.Size(115, 22);
            this.lblCodigoAutor.TabIndex = 3;
            this.lblCodigoAutor.Text = "Codigo Autor";
            // 
            // lblCodigoDistribuidor
            // 
            this.lblCodigoDistribuidor.AutoSize = true;
            this.lblCodigoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDistribuidor.Location = new System.Drawing.Point(23, 285);
            this.lblCodigoDistribuidor.Name = "lblCodigoDistribuidor";
            this.lblCodigoDistribuidor.Size = new System.Drawing.Size(101, 22);
            this.lblCodigoDistribuidor.TabIndex = 4;
            this.lblCodigoDistribuidor.Text = "Distribuidor";
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreLibro.Location = new System.Drawing.Point(192, 105);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.ReadOnly = true;
            this.txtNombreLibro.Size = new System.Drawing.Size(244, 23);
            this.txtNombreLibro.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(192, 150);
            this.txtCodigo.MaxLength = 1;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(39, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtCodigoEditorial
            // 
            this.txtCodigoEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoEditorial.Location = new System.Drawing.Point(192, 195);
            this.txtCodigoEditorial.MaxLength = 1;
            this.txtCodigoEditorial.Name = "txtCodigoEditorial";
            this.txtCodigoEditorial.ReadOnly = true;
            this.txtCodigoEditorial.Size = new System.Drawing.Size(244, 23);
            this.txtCodigoEditorial.TabIndex = 7;
            // 
            // txtCodigoAutor
            // 
            this.txtCodigoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAutor.Location = new System.Drawing.Point(192, 240);
            this.txtCodigoAutor.MaxLength = 1;
            this.txtCodigoAutor.Name = "txtCodigoAutor";
            this.txtCodigoAutor.ReadOnly = true;
            this.txtCodigoAutor.Size = new System.Drawing.Size(39, 23);
            this.txtCodigoAutor.TabIndex = 8;
            // 
            // txtCodigoDistribuidor
            // 
            this.txtCodigoDistribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoDistribuidor.Location = new System.Drawing.Point(192, 285);
            this.txtCodigoDistribuidor.MaxLength = 1;
            this.txtCodigoDistribuidor.Name = "txtCodigoDistribuidor";
            this.txtCodigoDistribuidor.ReadOnly = true;
            this.txtCodigoDistribuidor.Size = new System.Drawing.Size(244, 23);
            this.txtCodigoDistribuidor.TabIndex = 9;
            // 
            // lblConsultaBiblioteca
            // 
            this.lblConsultaBiblioteca.AutoSize = true;
            this.lblConsultaBiblioteca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaBiblioteca.Location = new System.Drawing.Point(125, 9);
            this.lblConsultaBiblioteca.Name = "lblConsultaBiblioteca";
            this.lblConsultaBiblioteca.Size = new System.Drawing.Size(247, 31);
            this.lblConsultaBiblioteca.TabIndex = 10;
            this.lblConsultaBiblioteca.Text = "Consulta Biblioteca";
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnterior.Location = new System.Drawing.Point(307, 336);
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Size = new System.Drawing.Size(50, 33);
            this.cmdAnterior.TabIndex = 11;
            this.cmdAnterior.Text = "<<";
            this.cmdAnterior.UseVisualStyleBackColor = true;
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSiguiente.Location = new System.Drawing.Point(386, 336);
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Size = new System.Drawing.Size(50, 33);
            this.cmdSiguiente.TabIndex = 12;
            this.cmdSiguiente.Text = ">>";
            this.cmdSiguiente.UseVisualStyleBackColor = true;
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 383);
            this.Controls.Add(this.cmdSiguiente);
            this.Controls.Add(this.cmdAnterior);
            this.Controls.Add(this.lblConsultaBiblioteca);
            this.Controls.Add(this.txtCodigoDistribuidor);
            this.Controls.Add(this.txtCodigoAutor);
            this.Controls.Add(this.txtCodigoEditorial);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombreLibro);
            this.Controls.Add(this.lblCodigoDistribuidor);
            this.Controls.Add(this.lblCodigoAutor);
            this.Controls.Add(this.lblCodigoEditorial);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombreLibro);
            this.Name = "frmMain";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigoEditorial;
        private System.Windows.Forms.Label lblCodigoAutor;
        private System.Windows.Forms.Label lblCodigoDistribuidor;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoEditorial;
        private System.Windows.Forms.TextBox txtCodigoAutor;
        private System.Windows.Forms.TextBox txtCodigoDistribuidor;
        private System.Windows.Forms.Label lblConsultaBiblioteca;
        private System.Windows.Forms.Button cmdAnterior;
        private System.Windows.Forms.Button cmdSiguiente;
    }
}

