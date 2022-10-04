namespace Vista
{
    partial class Frm_confirmacionAgregarPasajero
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
            this.lbl_costoDeVuelo = new System.Windows.Forms.Label();
            this.btn_confirmarPasajeroEnVuelo = new System.Windows.Forms.Button();
            this.btn_cancelarPasajeroEnVuelo = new System.Windows.Forms.Button();
            this.nud_pesoEquipajeUno = new System.Windows.Forms.NumericUpDown();
            this.nud_pesoEquipajeDos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pesoEquipajeUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pesoEquipajeDos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_costoDeVuelo
            // 
            this.lbl_costoDeVuelo.AutoSize = true;
            this.lbl_costoDeVuelo.Location = new System.Drawing.Point(46, 166);
            this.lbl_costoDeVuelo.Name = "lbl_costoDeVuelo";
            this.lbl_costoDeVuelo.Size = new System.Drawing.Size(38, 15);
            this.lbl_costoDeVuelo.TabIndex = 2;
            this.lbl_costoDeVuelo.Text = "label1";
            // 
            // btn_confirmarPasajeroEnVuelo
            // 
            this.btn_confirmarPasajeroEnVuelo.Location = new System.Drawing.Point(12, 209);
            this.btn_confirmarPasajeroEnVuelo.Name = "btn_confirmarPasajeroEnVuelo";
            this.btn_confirmarPasajeroEnVuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_confirmarPasajeroEnVuelo.TabIndex = 3;
            this.btn_confirmarPasajeroEnVuelo.Text = "Confirmar";
            this.btn_confirmarPasajeroEnVuelo.UseVisualStyleBackColor = true;
            this.btn_confirmarPasajeroEnVuelo.Click += new System.EventHandler(this.btn_confirmarPasajeroEnVuelo_Click);
            // 
            // btn_cancelarPasajeroEnVuelo
            // 
            this.btn_cancelarPasajeroEnVuelo.Location = new System.Drawing.Point(126, 209);
            this.btn_cancelarPasajeroEnVuelo.Name = "btn_cancelarPasajeroEnVuelo";
            this.btn_cancelarPasajeroEnVuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarPasajeroEnVuelo.TabIndex = 4;
            this.btn_cancelarPasajeroEnVuelo.Text = "Cancelar";
            this.btn_cancelarPasajeroEnVuelo.UseVisualStyleBackColor = true;
            this.btn_cancelarPasajeroEnVuelo.Click += new System.EventHandler(this.btn_cancelarPasajeroEnVuelo_Click);
            // 
            // nud_pesoEquipajeUno
            // 
            this.nud_pesoEquipajeUno.Location = new System.Drawing.Point(46, 59);
            this.nud_pesoEquipajeUno.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_pesoEquipajeUno.Name = "nud_pesoEquipajeUno";
            this.nud_pesoEquipajeUno.Size = new System.Drawing.Size(120, 23);
            this.nud_pesoEquipajeUno.TabIndex = 5;
            // 
            // nud_pesoEquipajeDos
            // 
            this.nud_pesoEquipajeDos.Location = new System.Drawing.Point(46, 110);
            this.nud_pesoEquipajeDos.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.nud_pesoEquipajeDos.Name = "nud_pesoEquipajeDos";
            this.nud_pesoEquipajeDos.Size = new System.Drawing.Size(120, 23);
            this.nud_pesoEquipajeDos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Peso Valija(s)";
            // 
            // Frm_confirmacionAgregarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_pesoEquipajeDos);
            this.Controls.Add(this.nud_pesoEquipajeUno);
            this.Controls.Add(this.btn_cancelarPasajeroEnVuelo);
            this.Controls.Add(this.btn_confirmarPasajeroEnVuelo);
            this.Controls.Add(this.lbl_costoDeVuelo);
            this.Name = "Frm_confirmacionAgregarPasajero";
            this.Text = "Frm_confirmacionAgregarPasajero";
            ((System.ComponentModel.ISupportInitialize)(this.nud_pesoEquipajeUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pesoEquipajeDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_costoDeVuelo;
        private System.Windows.Forms.Button btn_confirmarPasajeroEnVuelo;
        private System.Windows.Forms.Button btn_cancelarPasajeroEnVuelo;
        private System.Windows.Forms.NumericUpDown nud_pesoEquipajeUno;
        private System.Windows.Forms.NumericUpDown nud_pesoEquipajeDos;
        private System.Windows.Forms.Label label1;
    }
}