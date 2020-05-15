namespace RHH
{
    partial class DireccionDGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione el Area";
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.AllowUserToAddRows = false;
            this.dgvDireccion.AllowUserToDeleteRows = false;
            this.dgvDireccion.AllowUserToResizeColumns = false;
            this.dgvDireccion.AllowUserToResizeRows = false;
            this.dgvDireccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Location = new System.Drawing.Point(12, 79);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.Size = new System.Drawing.Size(430, 300);
            this.dgvDireccion.TabIndex = 5;
            this.dgvDireccion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArea_CellMouseClick);
            // 
            // DireccionDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDireccion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DireccionDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DireccionDGV";
            this.Load += new System.EventHandler(this.DireccionDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvDireccion;
    }
}