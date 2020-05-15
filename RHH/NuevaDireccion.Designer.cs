namespace RHH
{
    partial class NuevaDireccion
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDireccion = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(245, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(380, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Registrar Direccion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 179);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direccion del departamento";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Direccion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDireccion
            // 
            this.dgvDireccion.AllowUserToAddRows = false;
            this.dgvDireccion.AllowUserToDeleteRows = false;
            this.dgvDireccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvDireccion.Location = new System.Drawing.Point(196, 31);
            this.dgvDireccion.Name = "dgvDireccion";
            this.dgvDireccion.ReadOnly = true;
            this.dgvDireccion.Size = new System.Drawing.Size(271, 142);
            this.dgvDireccion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de Direccion";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(6, 65);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(184, 23);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(193, 70);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(294, 23);
            this.txtDepartamento.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Area Seleccionada";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Direccion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // NuevaDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 354);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaDireccion";
            this.Load += new System.EventHandler(this.NuevaDireccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDireccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}