namespace Vista
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.lb_menuprincipal = new System.Windows.Forms.Label();
            this.btn_agregarVuelo = new System.Windows.Forms.Button();
            this.dgv_menuPrincipal = new System.Windows.Forms.DataGridView();
            this.btn_visualizarVuelos = new System.Windows.Forms.Button();
            this.btn_AgregarPasajero = new System.Windows.Forms.Button();
            this.btn_VisualizarNaves = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dgv_secundario = new System.Windows.Forms.DataGridView();
            this.t_tiemposDeVuelo = new System.Windows.Forms.Timer(this.components);
            this.btn_visualizarDestinos = new System.Windows.Forms.Button();
            this.lbl_estadisticas = new System.Windows.Forms.Label();
            this.btn_visualizarPasajeros = new System.Windows.Forms.Button();
            this.btn_visualizarClientes = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.btn_agregarNonGrata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_secundario)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_menuprincipal
            // 
            this.lb_menuprincipal.AutoSize = true;
            this.lb_menuprincipal.Font = new System.Drawing.Font("Montserrat Alternates", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_menuprincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lb_menuprincipal.Location = new System.Drawing.Point(12, 9);
            this.lb_menuprincipal.Name = "lb_menuprincipal";
            this.lb_menuprincipal.Size = new System.Drawing.Size(143, 28);
            this.lb_menuprincipal.TabIndex = 0;
            this.lb_menuprincipal.Text = "Bienvenido";
            this.lb_menuprincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_menuprincipal.Click += new System.EventHandler(this.lb_menuprincipal_Click);
            // 
            // btn_agregarVuelo
            // 
            this.btn_agregarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_agregarVuelo.FlatAppearance.BorderSize = 0;
            this.btn_agregarVuelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_agregarVuelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_agregarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarVuelo.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarVuelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_agregarVuelo.Location = new System.Drawing.Point(361, 9);
            this.btn_agregarVuelo.Name = "btn_agregarVuelo";
            this.btn_agregarVuelo.Size = new System.Drawing.Size(96, 63);
            this.btn_agregarVuelo.TabIndex = 1;
            this.btn_agregarVuelo.Text = "Agregar Vuelo";
            this.btn_agregarVuelo.UseVisualStyleBackColor = false;
            this.btn_agregarVuelo.Click += new System.EventHandler(this.btn_agregarVuelo_Click);
            // 
            // dgv_menuPrincipal
            // 
            this.dgv_menuPrincipal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dgv_menuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_menuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menuPrincipal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.dgv_menuPrincipal.Location = new System.Drawing.Point(361, 78);
            this.dgv_menuPrincipal.Name = "dgv_menuPrincipal";
            this.dgv_menuPrincipal.RowHeadersVisible = false;
            this.dgv_menuPrincipal.RowTemplate.Height = 25;
            this.dgv_menuPrincipal.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_menuPrincipal.Size = new System.Drawing.Size(643, 358);
            this.dgv_menuPrincipal.TabIndex = 2;
            this.dgv_menuPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menuPrincipal_CellContentClick);
            // 
            // btn_visualizarVuelos
            // 
            this.btn_visualizarVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_visualizarVuelos.FlatAppearance.BorderSize = 0;
            this.btn_visualizarVuelos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_visualizarVuelos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_visualizarVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarVuelos.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_visualizarVuelos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_visualizarVuelos.Location = new System.Drawing.Point(12, 178);
            this.btn_visualizarVuelos.Name = "btn_visualizarVuelos";
            this.btn_visualizarVuelos.Size = new System.Drawing.Size(96, 44);
            this.btn_visualizarVuelos.TabIndex = 3;
            this.btn_visualizarVuelos.Text = "Ver Vuelos";
            this.btn_visualizarVuelos.UseVisualStyleBackColor = false;
            this.btn_visualizarVuelos.Click += new System.EventHandler(this.btn_visualizarVuelos_Click);
            // 
            // btn_AgregarPasajero
            // 
            this.btn_AgregarPasajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_AgregarPasajero.FlatAppearance.BorderSize = 0;
            this.btn_AgregarPasajero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_AgregarPasajero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_AgregarPasajero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarPasajero.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarPasajero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(463, 9);
            this.btn_AgregarPasajero.Name = "btn_AgregarPasajero";
            this.btn_AgregarPasajero.Size = new System.Drawing.Size(96, 63);
            this.btn_AgregarPasajero.TabIndex = 4;
            this.btn_AgregarPasajero.Text = "Agregar Pasajero";
            this.btn_AgregarPasajero.UseVisualStyleBackColor = false;
            this.btn_AgregarPasajero.Click += new System.EventHandler(this.btn_AgregarPasajero_Click);
            // 
            // btn_VisualizarNaves
            // 
            this.btn_VisualizarNaves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_VisualizarNaves.FlatAppearance.BorderSize = 0;
            this.btn_VisualizarNaves.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_VisualizarNaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_VisualizarNaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VisualizarNaves.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_VisualizarNaves.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_VisualizarNaves.Location = new System.Drawing.Point(12, 278);
            this.btn_VisualizarNaves.Name = "btn_VisualizarNaves";
            this.btn_VisualizarNaves.Size = new System.Drawing.Size(96, 44);
            this.btn_VisualizarNaves.TabIndex = 5;
            this.btn_VisualizarNaves.Text = "Ver Naves";
            this.btn_VisualizarNaves.UseVisualStyleBackColor = false;
            this.btn_VisualizarNaves.Click += new System.EventHandler(this.btn_VisualizarNaves_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_salir.Location = new System.Drawing.Point(12, 409);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(96, 27);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_secundario
            // 
            this.dgv_secundario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.dgv_secundario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_secundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_secundario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.dgv_secundario.Location = new System.Drawing.Point(121, 78);
            this.dgv_secundario.Name = "dgv_secundario";
            this.dgv_secundario.RowHeadersVisible = false;
            this.dgv_secundario.RowTemplate.Height = 25;
            this.dgv_secundario.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_secundario.Size = new System.Drawing.Size(234, 358);
            this.dgv_secundario.TabIndex = 7;
            // 
            // t_tiemposDeVuelo
            // 
            this.t_tiemposDeVuelo.Tick += new System.EventHandler(this.t_salidaVuelo_Tick);
            // 
            // btn_visualizarDestinos
            // 
            this.btn_visualizarDestinos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_visualizarDestinos.FlatAppearance.BorderSize = 0;
            this.btn_visualizarDestinos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_visualizarDestinos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_visualizarDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarDestinos.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_visualizarDestinos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_visualizarDestinos.Location = new System.Drawing.Point(12, 128);
            this.btn_visualizarDestinos.Name = "btn_visualizarDestinos";
            this.btn_visualizarDestinos.Size = new System.Drawing.Size(96, 44);
            this.btn_visualizarDestinos.TabIndex = 8;
            this.btn_visualizarDestinos.Text = "Ver Destinos";
            this.btn_visualizarDestinos.UseVisualStyleBackColor = false;
            this.btn_visualizarDestinos.Click += new System.EventHandler(this.btn_visualizarDestinos_Click);
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AutoSize = true;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(60)))), ((int)(((byte)(77)))));
            this.lbl_estadisticas.Location = new System.Drawing.Point(667, 9);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(0, 22);
            this.lbl_estadisticas.TabIndex = 9;
            this.lbl_estadisticas.Click += new System.EventHandler(this.lbl_estadisticas_Click);
            // 
            // btn_visualizarPasajeros
            // 
            this.btn_visualizarPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_visualizarPasajeros.FlatAppearance.BorderSize = 0;
            this.btn_visualizarPasajeros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_visualizarPasajeros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_visualizarPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarPasajeros.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_visualizarPasajeros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_visualizarPasajeros.Location = new System.Drawing.Point(12, 228);
            this.btn_visualizarPasajeros.Name = "btn_visualizarPasajeros";
            this.btn_visualizarPasajeros.Size = new System.Drawing.Size(96, 44);
            this.btn_visualizarPasajeros.TabIndex = 10;
            this.btn_visualizarPasajeros.Text = "Ver Pasajeros";
            this.btn_visualizarPasajeros.UseVisualStyleBackColor = false;
            this.btn_visualizarPasajeros.Click += new System.EventHandler(this.btn_visualizarPasajeros_Click);
            // 
            // btn_visualizarClientes
            // 
            this.btn_visualizarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_visualizarClientes.FlatAppearance.BorderSize = 0;
            this.btn_visualizarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_visualizarClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_visualizarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visualizarClientes.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_visualizarClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_visualizarClientes.Location = new System.Drawing.Point(12, 78);
            this.btn_visualizarClientes.Name = "btn_visualizarClientes";
            this.btn_visualizarClientes.Size = new System.Drawing.Size(96, 44);
            this.btn_visualizarClientes.TabIndex = 11;
            this.btn_visualizarClientes.Text = "Ver Clientes";
            this.btn_visualizarClientes.UseVisualStyleBackColor = false;
            this.btn_visualizarClientes.Click += new System.EventHandler(this.btn_visualizarClientes_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_ayuda.FlatAppearance.BorderSize = 0;
            this.btn_ayuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_ayuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayuda.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ayuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.btn_ayuda.Location = new System.Drawing.Point(12, 359);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(96, 44);
            this.btn_ayuda.TabIndex = 12;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_agregarNonGrata
            // 
            this.btn_agregarNonGrata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.btn_agregarNonGrata.FlatAppearance.BorderSize = 0;
            this.btn_agregarNonGrata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(65)))), ((int)(((byte)(70)))));
            this.btn_agregarNonGrata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(154)))), ((int)(((byte)(150)))));
            this.btn_agregarNonGrata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarNonGrata.Font = new System.Drawing.Font("Montserrat SemiBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_agregarNonGrata.Location = new System.Drawing.Point(565, 9);
            this.btn_agregarNonGrata.Name = "btn_agregarNonGrata";
            this.btn_agregarNonGrata.Size = new System.Drawing.Size(96, 63);
            this.btn_agregarNonGrata.TabIndex = 13;
            this.btn_agregarNonGrata.Text = "Agregar Non Grata";
            this.btn_agregarNonGrata.UseVisualStyleBackColor = false;
            this.btn_agregarNonGrata.Click += new System.EventHandler(this.btn_agregarNonGrata_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(161)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1016, 448);
            this.Controls.Add(this.btn_agregarNonGrata);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.btn_visualizarClientes);
            this.Controls.Add(this.btn_visualizarPasajeros);
            this.Controls.Add(this.lbl_estadisticas);
            this.Controls.Add(this.btn_visualizarDestinos);
            this.Controls.Add(this.dgv_secundario);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_VisualizarNaves);
            this.Controls.Add(this.btn_AgregarPasajero);
            this.Controls.Add(this.btn_visualizarVuelos);
            this.Controls.Add(this.btn_agregarVuelo);
            this.Controls.Add(this.lb_menuprincipal);
            this.Controls.Add(this.dgv_menuPrincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuPrincipal";
            this.Text = "FrmMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_secundario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_menuprincipal;
        private System.Windows.Forms.Button btn_agregarVuelo;
        private System.Windows.Forms.DataGridView dgv_menuPrincipal;
        private System.Windows.Forms.Button btn_visualizarVuelos;
        private System.Windows.Forms.Button btn_AgregarPasajero;
        private System.Windows.Forms.Button btn_VisualizarNaves;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dgv_secundario;
        private System.Windows.Forms.Timer t_tiemposDeVuelo;
        private System.Windows.Forms.Button btn_visualizarDestinos;
        private System.Windows.Forms.Label lbl_estadisticas;
        private System.Windows.Forms.Button btn_visualizarPasajeros;
        private System.Windows.Forms.Button btn_visualizarClientes;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_agregarNonGrata;
    }
}