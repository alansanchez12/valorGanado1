namespace Sistema_Pizzeria
{
    partial class FrmPedido
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.dgvEmpeños = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpeños)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(260, 376);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(81, 42);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(359, 376);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(99, 42);
            this.btnAgregarPedido.TabIndex = 9;
            this.btnAgregarPedido.Text = "Agregar Pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // dgvEmpeños
            // 
            this.dgvEmpeños.AllowUserToAddRows = false;
            this.dgvEmpeños.AllowUserToDeleteRows = false;
            this.dgvEmpeños.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpeños.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvEmpeños.Location = new System.Drawing.Point(12, 12);
            this.dgvEmpeños.Name = "dgvEmpeños";
            this.dgvEmpeños.ReadOnly = true;
            this.dgvEmpeños.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpeños.Size = new System.Drawing.Size(727, 348);
            this.dgvEmpeños.TabIndex = 8;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 421);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.dgvEmpeños);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpeños)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.DataGridView dgvEmpeños;
    }
}