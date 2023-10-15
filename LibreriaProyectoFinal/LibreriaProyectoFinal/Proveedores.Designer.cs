
namespace LibreriaProyectoFinal
{
    partial class Proveedores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboBuscarProveedor = new System.Windows.Forms.ComboBox();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.btnActualizarProveedor = new System.Windows.Forms.Button();
            this.btnGuardarProveedor = new System.Windows.Forms.Button();
            this.txtEmailProveedor = new System.Windows.Forms.TextBox();
            this.lblEmailProveedor = new System.Windows.Forms.Label();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eprProveedores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBuscarProveedor
            // 
            this.cboBuscarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarProveedor.FormattingEnabled = true;
            this.cboBuscarProveedor.Items.AddRange(new object[] {
            "NombreProveedor",
            "Telefono"});
            this.cboBuscarProveedor.Location = new System.Drawing.Point(159, 82);
            this.cboBuscarProveedor.Name = "cboBuscarProveedor";
            this.cboBuscarProveedor.Size = new System.Drawing.Size(196, 24);
            this.cboBuscarProveedor.TabIndex = 59;
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(361, 85);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(268, 22);
            this.txtBuscarProveedor.TabIndex = 58;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.BackColor = System.Drawing.Color.White;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(67, 85);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(56, 17);
            this.lblBuscarUsuario.TabIndex = 57;
            this.lblBuscarUsuario.Text = "Buscar:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-1, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1369, 48);
            this.label6.TabIndex = 56;
            this.label6.Text = "Proveedores:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.NombreProveedor,
            this.Telefonos,
            this.Direccion,
            this.Emails});
            this.dgvProveedores.Location = new System.Drawing.Point(48, 120);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.Size = new System.Drawing.Size(971, 454);
            this.dgvProveedores.TabIndex = 55;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "IdProveedor";
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.MinimumWidth = 6;
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            this.IdProveedor.Width = 50;
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataPropertyName = "NombreProveedor";
            this.NombreProveedor.HeaderText = "NombreProveedor";
            this.NombreProveedor.MinimumWidth = 6;
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Width = 200;
            // 
            // Telefonos
            // 
            this.Telefonos.DataPropertyName = "Telefono";
            this.Telefonos.HeaderText = "Telefono";
            this.Telefonos.MinimumWidth = 6;
            this.Telefonos.Name = "Telefonos";
            this.Telefonos.ReadOnly = true;
            this.Telefonos.Width = 200;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 200;
            // 
            // Emails
            // 
            this.Emails.DataPropertyName = "Email";
            this.Emails.HeaderText = "Email";
            this.Emails.MinimumWidth = 6;
            this.Emails.Name = "Emails";
            this.Emails.ReadOnly = true;
            this.Emails.Width = 200;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.BackColor = System.Drawing.Color.Red;
            this.btnEliminarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarProveedor.FlatAppearance.BorderSize = 3;
            this.btnEliminarProveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProveedor.Location = new System.Drawing.Point(1134, 522);
            this.btnEliminarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(150, 39);
            this.btnEliminarProveedor.TabIndex = 53;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = false;
            this.btnEliminarProveedor.Click += new System.EventHandler(this.btnEliminarProveedor_Click_1);
            // 
            // btnActualizarProveedor
            // 
            this.btnActualizarProveedor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarProveedor.FlatAppearance.BorderSize = 3;
            this.btnActualizarProveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnActualizarProveedor.Location = new System.Drawing.Point(1134, 477);
            this.btnActualizarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarProveedor.Name = "btnActualizarProveedor";
            this.btnActualizarProveedor.Size = new System.Drawing.Size(150, 37);
            this.btnActualizarProveedor.TabIndex = 52;
            this.btnActualizarProveedor.Text = "Actualizar";
            this.btnActualizarProveedor.UseVisualStyleBackColor = false;
            this.btnActualizarProveedor.Click += new System.EventHandler(this.btnActualizarProveedor_Click_1);
            // 
            // btnGuardarProveedor
            // 
            this.btnGuardarProveedor.BackColor = System.Drawing.Color.Green;
            this.btnGuardarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarProveedor.FlatAppearance.BorderSize = 3;
            this.btnGuardarProveedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnGuardarProveedor.Location = new System.Drawing.Point(1134, 414);
            this.btnGuardarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarProveedor.Name = "btnGuardarProveedor";
            this.btnGuardarProveedor.Size = new System.Drawing.Size(150, 39);
            this.btnGuardarProveedor.TabIndex = 30;
            this.btnGuardarProveedor.Text = "Guardar";
            this.btnGuardarProveedor.UseVisualStyleBackColor = false;
            this.btnGuardarProveedor.Click += new System.EventHandler(this.btnGuardarProveedor_Click_1);
            // 
            // txtEmailProveedor
            // 
            this.txtEmailProveedor.Location = new System.Drawing.Point(1081, 334);
            this.txtEmailProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailProveedor.Name = "txtEmailProveedor";
            this.txtEmailProveedor.Size = new System.Drawing.Size(267, 22);
            this.txtEmailProveedor.TabIndex = 49;
            // 
            // lblEmailProveedor
            // 
            this.lblEmailProveedor.AutoSize = true;
            this.lblEmailProveedor.BackColor = System.Drawing.Color.White;
            this.lblEmailProveedor.Location = new System.Drawing.Point(1089, 277);
            this.lblEmailProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailProveedor.Name = "lblEmailProveedor";
            this.lblEmailProveedor.Size = new System.Drawing.Size(46, 17);
            this.lblEmailProveedor.TabIndex = 48;
            this.lblEmailProveedor.Text = "Email:";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Location = new System.Drawing.Point(1081, 232);
            this.txtDireccionProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(266, 22);
            this.txtDireccionProveedor.TabIndex = 47;
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.BackColor = System.Drawing.Color.White;
            this.lblDireccionProveedor.Location = new System.Drawing.Point(1089, 182);
            this.lblDireccionProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(71, 17);
            this.lblDireccionProveedor.TabIndex = 46;
            this.lblDireccionProveedor.Text = "Direccion:";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(1080, 141);
            this.txtTelefonoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(267, 22);
            this.txtTelefonoProveedor.TabIndex = 45;
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.BackColor = System.Drawing.Color.White;
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(1089, 120);
            this.lblTelefonoProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(68, 17);
            this.lblTelefonoProveedor.TabIndex = 44;
            this.lblTelefonoProveedor.Text = "Telefono:";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(1081, 85);
            this.txtNombreProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(266, 22);
            this.txtNombreProveedor.TabIndex = 43;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.BackColor = System.Drawing.Color.White;
            this.lblNombreProveedor.Location = new System.Drawing.Point(1089, 64);
            this.lblNombreProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(132, 17);
            this.lblNombreProveedor.TabIndex = 42;
            this.lblNombreProveedor.Text = "Nombre Proveedor:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(1043, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 781);
            this.label5.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 50;
            // 
            // eprProveedores
            // 
            this.eprProveedores.ContainerControl = this;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 781);
            this.Controls.Add(this.cboBuscarProveedor);
            this.Controls.Add(this.txtBuscarProveedor);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.btnEliminarProveedor);
            this.Controls.Add(this.btnActualizarProveedor);
            this.Controls.Add(this.btnGuardarProveedor);
            this.Controls.Add(this.txtEmailProveedor);
            this.Controls.Add(this.lblEmailProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.lblDireccionProveedor);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.lblTelefonoProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eprProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnActualizarProveedor;
        private System.Windows.Forms.Button btnGuardarProveedor;
        private System.Windows.Forms.TextBox txtEmailProveedor;
        private System.Windows.Forms.Label lblEmailProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider eprProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emails;
    }
}