namespace Vista
{
    partial class Frm_agregarNonGrata
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
            this.dgv_agregarNonGrata = new System.Windows.Forms.DataGridView();
            this.btn_cancelarAgregarNonGrata = new System.Windows.Forms.Button();
            this.btn_confirmarAgregarNonGrata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarNonGrata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_agregarNonGrata
            // 
            this.dgv_agregarNonGrata.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.dgv_agregarNonGrata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_agregarNonGrata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agregarNonGrata.ColumnHeadersVisible = false;
            this.dgv_agregarNonGrata.Location = new System.Drawing.Point(12, 30);
            this.dgv_agregarNonGrata.Name = "dgv_agregarNonGrata";
            this.dgv_agregarNonGrata.RowTemplate.Height = 25;
            this.dgv_agregarNonGrata.Size = new System.Drawing.Size(601, 314);
            this.dgv_agregarNonGrata.TabIndex = 0;
            // 
            // btn_cancelarAgregarNonGrata
            // 
            this.btn_cancelarAgregarNonGrata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_cancelarAgregarNonGrata.FlatAppearance.BorderSize = 0;
            this.btn_cancelarAgregarNonGrata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarAgregarNonGrata.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarAgregarNonGrata.Location = new System.Drawing.Point(12, 374);
            this.btn_cancelarAgregarNonGrata.Name = "btn_cancelarAgregarNonGrata";
            this.btn_cancelarAgregarNonGrata.Size = new System.Drawing.Size(137, 64);
            this.btn_cancelarAgregarNonGrata.TabIndex = 1;
            this.btn_cancelarAgregarNonGrata.Text = "Cancelar";
            this.btn_cancelarAgregarNonGrata.UseVisualStyleBackColor = false;
            this.btn_cancelarAgregarNonGrata.Click += new System.EventHandler(this.btn_cancelarAgregarNonGrata_Click);
            // 
            // btn_confirmarAgregarNonGrata
            // 
            this.btn_confirmarAgregarNonGrata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_confirmarAgregarNonGrata.FlatAppearance.BorderSize = 0;
            this.btn_confirmarAgregarNonGrata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmarAgregarNonGrata.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmarAgregarNonGrata.Location = new System.Drawing.Point(476, 374);
            this.btn_confirmarAgregarNonGrata.Name = "btn_confirmarAgregarNonGrata";
            this.btn_confirmarAgregarNonGrata.Size = new System.Drawing.Size(137, 65);
            this.btn_confirmarAgregarNonGrata.TabIndex = 2;
            this.btn_confirmarAgregarNonGrata.Text = "Confirmar";
            this.btn_confirmarAgregarNonGrata.UseVisualStyleBackColor = false;
            this.btn_confirmarAgregarNonGrata.Click += new System.EventHandler(this.btn_confirmarAgregarNonGrata_Click);
            // 
            // Frm_agregarNonGrata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btn_confirmarAgregarNonGrata);
            this.Controls.Add(this.btn_cancelarAgregarNonGrata);
            this.Controls.Add(this.dgv_agregarNonGrata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_agregarNonGrata";
            this.Text = "Frm_agregarNonGrata";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarNonGrata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_agregarNonGrata;
        private System.Windows.Forms.Button btn_cancelarAgregarNonGrata;
        private System.Windows.Forms.Button btn_confirmarAgregarNonGrata;
    }
}