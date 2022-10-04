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
            this.cb_naves.FormattingEnabled = true;
            this.cb_naves.Location = new System.Drawing.Point(39, 62);
            this.cb_naves.Name = "cb_naves";
            this.cb_naves.Size = new System.Drawing.Size(121, 23);
            this.cb_naves.TabIndex = 0;
            // 
            // cb_destinos
            // 
            this.cb_destinos.FormattingEnabled = true;
            this.cb_destinos.Location = new System.Drawing.Point(39, 150);
            this.cb_destinos.Name = "cb_destinos";
            this.cb_destinos.Size = new System.Drawing.Size(121, 23);
            this.cb_destinos.TabIndex = 1;
            // 
            // btn_confirmarAgregarVuelo
            // 
            this.btn_confirmarAgregarVuelo.Location = new System.Drawing.Point(317, 293);
            this.btn_confirmarAgregarVuelo.Name = "btn_confirmarAgregarVuelo";
            this.btn_confirmarAgregarVuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmarAgregarVuelo.TabIndex = 2;
            this.btn_confirmarAgregarVuelo.Text = "Agregar";
            this.btn_confirmarAgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_confirmarAgregarVuelo.Click += new System.EventHandler(this.btn_confirmarAgregarVuelo_Click);
            // 
            // btn_cancelarAgregarVuelo
            // 
            this.btn_cancelarAgregarVuelo.Location = new System.Drawing.Point(29, 293);
            this.btn_cancelarAgregarVuelo.Name = "btn_cancelarAgregarVuelo";
            this.btn_cancelarAgregarVuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarAgregarVuelo.TabIndex = 3;
            this.btn_cancelarAgregarVuelo.Text = "Cancelar";
            this.btn_cancelarAgregarVuelo.UseVisualStyleBackColor = true;
            this.btn_cancelarAgregarVuelo.Click += new System.EventHandler(this.btn_cancelarAgregarVuelo_Click);
            // 
            // dtp_AgregarVuelo
            // 
            this.dtp_AgregarVuelo.Location = new System.Drawing.Point(192, 62);
            this.dtp_AgregarVuelo.MinDate = new System.DateTime(2022, 10, 4, 4, 30, 38, 0);
            this.dtp_AgregarVuelo.Name = "dtp_AgregarVuelo";
            this.dtp_AgregarVuelo.Size = new System.Drawing.Size(200, 23);
            this.dtp_AgregarVuelo.TabIndex = 4;
            this.dtp_AgregarVuelo.Value = new System.DateTime(2022, 10, 4, 4, 30, 38, 0);
            // 
            // FrmAgregarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 347);
            this.Controls.Add(this.dtp_AgregarVuelo);
            this.Controls.Add(this.btn_cancelarAgregarVuelo);
            this.Controls.Add(this.btn_confirmarAgregarVuelo);
            this.Controls.Add(this.cb_destinos);
            this.Controls.Add(this.cb_naves);
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