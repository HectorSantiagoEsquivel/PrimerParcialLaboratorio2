namespace Vista
{
    partial class FrmAgregarPasajero
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.dgv_agregarPasajero = new System.Windows.Forms.DataGridView();
            this.chb_esPremium = new System.Windows.Forms.CheckBox();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.btn_agregarPasajeroConfirmar = new System.Windows.Forms.Button();
            this.btn_agregarPasajeroCancelar = new System.Windows.Forms.Button();
            this.dtp_fechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarPasajero)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.tb_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nombre.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.tb_nombre.Location = new System.Drawing.Point(36, 12);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.PlaceholderText = "Nombre";
            this.tb_nombre.Size = new System.Drawing.Size(121, 22);
            this.tb_nombre.TabIndex = 1;
            // 
            // tb_apellido
            // 
            this.tb_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.tb_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_apellido.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.tb_apellido.Location = new System.Drawing.Point(36, 41);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.PlaceholderText = "Apellido";
            this.tb_apellido.Size = new System.Drawing.Size(121, 22);
            this.tb_apellido.TabIndex = 2;
            // 
            // dgv_agregarPasajero
            // 
            this.dgv_agregarPasajero.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dgv_agregarPasajero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_agregarPasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agregarPasajero.Location = new System.Drawing.Point(184, 12);
            this.dgv_agregarPasajero.Name = "dgv_agregarPasajero";
            this.dgv_agregarPasajero.RowHeadersVisible = false;
            this.dgv_agregarPasajero.RowTemplate.Height = 25;
            this.dgv_agregarPasajero.Size = new System.Drawing.Size(288, 242);
            this.dgv_agregarPasajero.TabIndex = 4;
            // 
            // chb_esPremium
            // 
            this.chb_esPremium.AutoSize = true;
            this.chb_esPremium.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chb_esPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.chb_esPremium.Location = new System.Drawing.Point(36, 150);
            this.chb_esPremium.Name = "chb_esPremium";
            this.chb_esPremium.Size = new System.Drawing.Size(85, 21);
            this.chb_esPremium.TabIndex = 5;
            this.chb_esPremium.Text = "Premium";
            this.chb_esPremium.UseVisualStyleBackColor = true;
            this.chb_esPremium.CheckedChanged += new System.EventHandler(this.chb_esPremium_CheckedChanged);
            // 
            // tb_DNI
            // 
            this.tb_DNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.tb_DNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_DNI.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_DNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.tb_DNI.Location = new System.Drawing.Point(36, 70);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.PlaceholderText = "DNI";
            this.tb_DNI.Size = new System.Drawing.Size(121, 22);
            this.tb_DNI.TabIndex = 6;
            // 
            // btn_agregarPasajeroConfirmar
            // 
            this.btn_agregarPasajeroConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_agregarPasajeroConfirmar.FlatAppearance.BorderSize = 0;
            this.btn_agregarPasajeroConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarPasajeroConfirmar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarPasajeroConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_agregarPasajeroConfirmar.Location = new System.Drawing.Point(36, 263);
            this.btn_agregarPasajeroConfirmar.Name = "btn_agregarPasajeroConfirmar";
            this.btn_agregarPasajeroConfirmar.Size = new System.Drawing.Size(85, 23);
            this.btn_agregarPasajeroConfirmar.TabIndex = 7;
            this.btn_agregarPasajeroConfirmar.Text = "Agregar";
            this.btn_agregarPasajeroConfirmar.UseVisualStyleBackColor = false;
            this.btn_agregarPasajeroConfirmar.Click += new System.EventHandler(this.btn_agregarPasajeroConfirmar_Click);
            // 
            // btn_agregarPasajeroCancelar
            // 
            this.btn_agregarPasajeroCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_agregarPasajeroCancelar.FlatAppearance.BorderSize = 0;
            this.btn_agregarPasajeroCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarPasajeroCancelar.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarPasajeroCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.btn_agregarPasajeroCancelar.Location = new System.Drawing.Point(397, 263);
            this.btn_agregarPasajeroCancelar.Name = "btn_agregarPasajeroCancelar";
            this.btn_agregarPasajeroCancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregarPasajeroCancelar.TabIndex = 8;
            this.btn_agregarPasajeroCancelar.Text = "Cancelar";
            this.btn_agregarPasajeroCancelar.UseVisualStyleBackColor = false;
            this.btn_agregarPasajeroCancelar.Click += new System.EventHandler(this.btn_agregarPasajeroCancelar_Click);
            // 
            // dtp_fechaDeNacimiento
            // 
            this.dtp_fechaDeNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.dtp_fechaDeNacimiento.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_fechaDeNacimiento.Location = new System.Drawing.Point(36, 121);
            this.dtp_fechaDeNacimiento.MaxDate = new System.DateTime(2022, 10, 4, 0, 0, 0, 0);
            this.dtp_fechaDeNacimiento.Name = "dtp_fechaDeNacimiento";
            this.dtp_fechaDeNacimiento.Size = new System.Drawing.Size(121, 21);
            this.dtp_fechaDeNacimiento.TabIndex = 9;
            this.dtp_fechaDeNacimiento.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.AutoSize = true;
            this.lbl_fechaNacimiento.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fechaNacimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(38, 103);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(137, 17);
            this.lbl_fechaNacimiento.TabIndex = 10;
            this.lbl_fechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // FrmAgregarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(484, 298);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.dtp_fechaDeNacimiento);
            this.Controls.Add(this.btn_agregarPasajeroCancelar);
            this.Controls.Add(this.btn_agregarPasajeroConfirmar);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.chb_esPremium);
            this.Controls.Add(this.dgv_agregarPasajero);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.tb_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarPasajero";
            this.Text = "FrmAgregarPasajero";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregarPasajero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.DataGridView dgv_agregarPasajero;
        private System.Windows.Forms.CheckBox chb_esPremium;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.Button btn_agregarPasajeroConfirmar;
        private System.Windows.Forms.Button btn_agregarPasajeroCancelar;
        private System.Windows.Forms.DateTimePicker dtp_fechaDeNacimiento;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
    }
}