namespace RHH
{
    partial class NuevaAreaForm
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
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvArea = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento Seleccionado";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(288, 66);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(203, 23);
            this.txtDepartamento.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvArea);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Areas del departamento";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvArea
            // 
            this.dgvArea.AllowUserToAddRows = false;
            this.dgvArea.AllowUserToDeleteRows = false;
            this.dgvArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvArea.Location = new System.Drawing.Point(196, 18);
            this.dgvArea.Name = "dgvArea";
            this.dgvArea.ReadOnly = true;
            this.dgvArea.Size = new System.Drawing.Size(271, 142);
            this.dgvArea.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre area";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de area";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.Location = new System.Drawing.Point(6, 65);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(184, 23);
            this.txtArea.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(396, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Registrar Area";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(261, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NuevaAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 350);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaAreaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaAreaForm";
            this.Load += new System.EventHandler(this.NuevaAreaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}