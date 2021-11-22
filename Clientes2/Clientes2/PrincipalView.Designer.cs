namespace Clientes2
{
    partial class PrincipalView
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
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.colID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.AllowUserToOrderColumns = true;
            this.grdClientes.AllowUserToResizeColumns = false;
            this.grdClientes.AllowUserToResizeRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID_Cliente,
            this.colRFC,
            this.colNombre,
            this.colPaterno,
            this.colMaterno});
            this.grdClientes.Location = new System.Drawing.Point(44, 80);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(685, 301);
            this.grdClientes.TabIndex = 0;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(143, 31);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(240, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(44, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // colID_Cliente
            // 
            this.colID_Cliente.DataPropertyName = "ID_Cliente";
            this.colID_Cliente.HeaderText = "";
            this.colID_Cliente.Name = "colID_Cliente";
            this.colID_Cliente.Visible = false;
            // 
            // colRFC
            // 
            this.colRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRFC.DataPropertyName = "RFC";
            this.colRFC.HeaderText = "RFC";
            this.colRFC.Name = "colRFC";
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colPaterno
            // 
            this.colPaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaterno.DataPropertyName = "Paterno";
            this.colPaterno.HeaderText = "Paterno";
            this.colPaterno.Name = "colPaterno";
            // 
            // colMaterno
            // 
            this.colMaterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaterno.DataPropertyName = "Materno";
            this.colMaterno.HeaderText = "Materno";
            this.colMaterno.Name = "colMaterno";
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.grdClientes);
            this.Name = "PrincipalView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PrincipalView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterno;
    }
}

