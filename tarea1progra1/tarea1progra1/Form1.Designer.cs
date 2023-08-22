
namespace tarea1progra1
{
    partial class Form1
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
            this.lbltipo = new System.Windows.Forms.Label();
            this.LblRespuestaConversores = new System.Windows.Forms.Label();
            this.CboTipoConversor = new System.Windows.Forms.ComboBox();
            this.CboDeConversor = new System.Windows.Forms.ComboBox();
            this.CboAConversores = new System.Windows.Forms.ComboBox();
            this.TxtCantidadConversores = new System.Windows.Forms.TextBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.LblDeConversor = new System.Windows.Forms.Label();
            this.LblAConversor = new System.Windows.Forms.Label();
            this.LblCantidadConversores = new System.Windows.Forms.Label();
            this.Btn_ConvertirConversores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(135, 96);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(0, 17);
            this.lbltipo.TabIndex = 0;
            // 
            // LblRespuestaConversores
            // 
            this.LblRespuestaConversores.AutoSize = true;
            this.LblRespuestaConversores.Location = new System.Drawing.Point(135, 305);
            this.LblRespuestaConversores.Name = "LblRespuestaConversores";
            this.LblRespuestaConversores.Size = new System.Drawing.Size(84, 17);
            this.LblRespuestaConversores.TabIndex = 4;
            this.LblRespuestaConversores.Text = "Respuesta: ";
            // 
            // CboTipoConversor
            // 
            this.CboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoConversor.FormattingEnabled = true;
            this.CboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.CboTipoConversor.Location = new System.Drawing.Point(172, 93);
            this.CboTipoConversor.Name = "CboTipoConversor";
            this.CboTipoConversor.Size = new System.Drawing.Size(206, 24);
            this.CboTipoConversor.TabIndex = 9;
            this.CboTipoConversor.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // CboDeConversor
            // 
            this.CboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDeConversor.FormattingEnabled = true;
            this.CboDeConversor.Location = new System.Drawing.Point(172, 140);
            this.CboDeConversor.Name = "CboDeConversor";
            this.CboDeConversor.Size = new System.Drawing.Size(206, 24);
            this.CboDeConversor.TabIndex = 10;
            // 
            // CboAConversores
            // 
            this.CboAConversores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAConversores.FormattingEnabled = true;
            this.CboAConversores.Location = new System.Drawing.Point(162, 189);
            this.CboAConversores.Name = "CboAConversores";
            this.CboAConversores.Size = new System.Drawing.Size(206, 24);
            this.CboAConversores.TabIndex = 11;
            // 
            // TxtCantidadConversores
            // 
            this.TxtCantidadConversores.Location = new System.Drawing.Point(205, 248);
            this.TxtCantidadConversores.Name = "TxtCantidadConversores";
            this.TxtCantidadConversores.Size = new System.Drawing.Size(206, 22);
            this.TxtCantidadConversores.TabIndex = 12;
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Location = new System.Drawing.Point(126, 96);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(40, 17);
            this.lblTipoConversor.TabIndex = 13;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // LblDeConversor
            // 
            this.LblDeConversor.AutoSize = true;
            this.LblDeConversor.Location = new System.Drawing.Point(126, 143);
            this.LblDeConversor.Name = "LblDeConversor";
            this.LblDeConversor.Size = new System.Drawing.Size(30, 17);
            this.LblDeConversor.TabIndex = 14;
            this.LblDeConversor.Text = "De:";
            // 
            // LblAConversor
            // 
            this.LblAConversor.AutoSize = true;
            this.LblAConversor.Location = new System.Drawing.Point(135, 196);
            this.LblAConversor.Name = "LblAConversor";
            this.LblAConversor.Size = new System.Drawing.Size(21, 17);
            this.LblAConversor.TabIndex = 15;
            this.LblAConversor.Text = "A:";
            // 
            // LblCantidadConversores
            // 
            this.LblCantidadConversores.AutoSize = true;
            this.LblCantidadConversores.Location = new System.Drawing.Point(126, 253);
            this.LblCantidadConversores.Name = "LblCantidadConversores";
            this.LblCantidadConversores.Size = new System.Drawing.Size(64, 17);
            this.LblCantidadConversores.TabIndex = 16;
            this.LblCantidadConversores.Text = "Cantidad";
            // 
            // Btn_ConvertirConversores
            // 
            this.Btn_ConvertirConversores.Location = new System.Drawing.Point(219, 342);
            this.Btn_ConvertirConversores.Name = "Btn_ConvertirConversores";
            this.Btn_ConvertirConversores.Size = new System.Drawing.Size(132, 45);
            this.Btn_ConvertirConversores.TabIndex = 17;
            this.Btn_ConvertirConversores.Text = "Convertir";
            this.Btn_ConvertirConversores.UseVisualStyleBackColor = true;
            this.Btn_ConvertirConversores.Click += new System.EventHandler(this.Btn_ConvertirConversores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ConvertirConversores);
            this.Controls.Add(this.LblCantidadConversores);
            this.Controls.Add(this.LblAConversor);
            this.Controls.Add(this.LblDeConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.TxtCantidadConversores);
            this.Controls.Add(this.CboAConversores);
            this.Controls.Add(this.CboDeConversor);
            this.Controls.Add(this.CboTipoConversor);
            this.Controls.Add(this.LblRespuestaConversores);
            this.Controls.Add(this.lbltipo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label LblRespuestaConversores;
        private System.Windows.Forms.ComboBox CboTipoConversor;
        private System.Windows.Forms.ComboBox CboDeConversor;
        private System.Windows.Forms.ComboBox CboAConversores;
        private System.Windows.Forms.TextBox TxtCantidadConversores;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label LblDeConversor;
        private System.Windows.Forms.Label LblAConversor;
        private System.Windows.Forms.Label LblCantidadConversores;
        private System.Windows.Forms.Button Btn_ConvertirConversores;
    }
}

