namespace pryMamondezLibro
{
    partial class frmGrilla
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
            this.dgvBiblioteca = new System.Windows.Forms.DataGridView();
            this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columna5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBiblioteca
            // 
            this.dgvBiblioteca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiblioteca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna1,
            this.Columna2,
            this.Columna3,
            this.Columna4,
            this.Columna5});
            this.dgvBiblioteca.Location = new System.Drawing.Point(12, 12);
            this.dgvBiblioteca.Name = "dgvBiblioteca";
            this.dgvBiblioteca.Size = new System.Drawing.Size(546, 388);
            this.dgvBiblioteca.TabIndex = 0;
            // 
            // Columna1
            // 
            this.Columna1.HeaderText = "Nombre Libro";
            this.Columna1.Name = "Columna1";
            // 
            // Columna2
            // 
            this.Columna2.HeaderText = "Codigo";
            this.Columna2.Name = "Columna2";
            // 
            // Columna3
            // 
            this.Columna3.HeaderText = "Codigo Editorial";
            this.Columna3.Name = "Columna3";
            // 
            // Columna4
            // 
            this.Columna4.HeaderText = "Codigo Autor";
            this.Columna4.Name = "Columna4";
            // 
            // Columna5
            // 
            this.Columna5.HeaderText = "Codigo Distribuidor";
            this.Columna5.Name = "Columna5";
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(471, 406);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(87, 32);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // frmGrilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 444);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvBiblioteca);
            this.Name = "frmGrilla";
            this.Text = "frmGrilla";
            this.Load += new System.EventHandler(this.frmGrilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiblioteca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBiblioteca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columna5;
        private System.Windows.Forms.Button cmdListar;
    }
}