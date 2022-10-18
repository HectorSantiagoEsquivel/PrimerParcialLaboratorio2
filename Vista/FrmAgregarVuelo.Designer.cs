namespace Vista
{
    partial class FrmAgregarVuelo
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
            this.cb_naves = new System.Windows.Forms.ComboBox();
            this.cb_destinos = new System.Windows.Forms.ComboBox();
            this.btn_confirmarAgregarVuelo = new System.Windows.Forms.Button();
            this.btn_cancelarAgregarVuelo = new System.Windows.Forms.Button();
            this.dtp_AgregarVuelo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cb_naves
            // 
            this.cb_naves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.cb_naves.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_naves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.cb_naves.FormattingEnabled = true;
            this.cb_naves.Location = new System.Drawing.Point(39, 62);
            this.cb_naves.Name = "cb_naves";
            this.cb_naves.Size = new System.Drawing.Size(121, 24);
            this.cb_naves.TabIndex = 0;
            // 
            // cb_destinos
            // 
            this.cb_destinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.cb_destinos.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_destinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.cb_destinos.FormattingEnabled = true;
            this.cb_destinos.Location = new System.Drawing.Point(39, 150);
            this.cb_destinos.Name = "cb_destinos";
            this.cb_destinos.Size = new System.Drawing.Size(121, 24);
            this.cb_destinos.TabIndex = 1;
            // 
            // btn_confirmarAgregarVuelo
            // 
            this.btn_confirmarAgregarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_confirmarAgregarVuelo.FlatAppearance.BorderSize = 0;
            this.btn_confirmarAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmarAgregarVuelo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_confirmarAgregarVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_confirmarAgregarVuelo.Location = new System.Drawing.Point(317, 293);
            this.btn_confirmarAgregarVuelo.Name = "btn_confirmarAgregarVuelo";
            this.btn_confirmarAgregarVuelo.Size = new System.Drawing.Size(75, 31);
            this.btn_confirmarAgregarVuelo.TabIndex = 2;
            this.btn_confirmarAgregarVuelo.Text = "Agregar";
            this.btn_confirmarAgregarVuelo.UseVisualStyleBackColor = false;
            this.btn_confirmarAgregarVuelo.Click += new System.EventHandler(this.btn_confirmarAgregarVuelo_Click);
            // 
            // btn_cancelarAgregarVuelo
            // 
            this.btn_cancelarAgregarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_cancelarAgregarVuelo.FlatAppearance.BorderSize = 0;
            this.btn_cancelarAgregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarAgregarVuelo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cancelarAgregarVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_cancelarAgregarVuelo.Location = new System.Drawing.Point(29, 293);
            this.btn_cancelarAgregarVuelo.Name = "btn_cancelarAgregarVuelo";
            this.btn_cancelarAgregarVuelo.Size = new System.Drawing.Size(75, 31);
            this.btn_cancelarAgregarVuelo.TabIndex = 3;
            this.btn_cancelarAgregarVuelo.Text = "Cancelar";
            this.btn_cancelarAgregarVuelo.UseVisualStyleBackColor = false;
            this.btn_cancelarAgregarVuelo.Click += new System.EventHandler(this.btn_cancelarAgregarVuelo_Click);
            // 
            // dtp_AgregarVuelo
            // 
            this.dtp_AgregarVuelo.CalendarFont = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_AgregarVuelo.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_AgregarVuelo.Location = new System.Drawing.Point(192, 62);
            this.dtp_AgregarVuelo.MinDate = new System.DateTime(2022, 10, 4, 4, 30, 38, 0);
            this.dtp_AgregarVuelo.Name = "dtp_AgregarVuelo";
            this.dtp_AgregarVuelo.Size = new System.Drawing.Size(200, 22);
            this.dtp_AgregarVuelo.TabIndex = 4;
            this.dtp_AgregarVuelo.Value = new System.DateTime(2022, 10, 4, 4, 30, 38, 0);
            // 
            // FrmAgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(418, 347);
            this.Controls.Add(this.dtp_AgregarVuelo);
            this.Controls.Add(this.btn_cancelarAgregarVuelo);
            this.Controls.Add(this.btn_confirmarAgregarVuelo);
            this.Controls.Add(this.cb_destinos);
            this.Controls.Add(this.cb_naves);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarVuelo";
            this.Text = "FrmAgregarVuelo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_naves;
        private System.Windows.Forms.ComboBox cb_destinos;
        private System.Windows.Forms.Button btn_confirmarAgregarVuelo;
        private System.Windows.Forms.Button btn_cancelarAgregarVuelo;
        private System.Windows.Forms.DateTimePicker dtp_AgregarVuelo;
    }
}