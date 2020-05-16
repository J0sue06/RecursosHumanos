namespace RHH
{
    partial class Datos_Direccion
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
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.AllowUserToAddRows = false;
            this.dgvDireccion.AllowUserToDeleteRows = false;
            this.dgvDireccion.AllowUserToResizeColumns = false;
            this.dgvDireccion.AllowUserToResizeRows = false;
            this.dgvDireccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(12, 75);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(424, 254);
            this.dgvDireccion.TabIndex = 0;
            this.dgvDireccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDireccion_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione la Direccion";
            // 
            // Datos_Direccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDireccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Datos_Direccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos_Direccion";
            this.Load += new System.EventHandler(this.Datos_Direccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Label label1;
    }
}