
namespace Eventos1
{
    partial class FormAvisador
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbl_NombreCompleto = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(49, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(49, 139);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // lbl_NombreCompleto
            // 
            this.lbl_NombreCompleto.AutoSize = true;
            this.lbl_NombreCompleto.Location = new System.Drawing.Point(115, 265);
            this.lbl_NombreCompleto.Name = "lbl_NombreCompleto";
            this.lbl_NombreCompleto.Size = new System.Drawing.Size(91, 13);
            this.lbl_NombreCompleto.TabIndex = 2;
            this.lbl_NombreCompleto.Text = "Nombre Completo";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(52, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(189, 35);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Crear";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(107, 91);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 20);
            this.txbNombre.TabIndex = 4;
            // 
            // txbApe
            // 
            this.txbApe.Location = new System.Drawing.Point(107, 132);
            this.txbApe.Name = "txbApe";
            this.txbApe.Size = new System.Drawing.Size(100, 20);
            this.txbApe.TabIndex = 5;
            // 
            // FormAvisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(292, 339);
            this.Controls.Add(this.txbApe);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbl_NombreCompleto);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbName);
            this.Name = "FormAvisador";
            this.Text = "El Avisador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbl_NombreCompleto;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApe;
    }
}

