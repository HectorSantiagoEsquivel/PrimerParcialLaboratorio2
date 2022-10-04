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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menuPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_secundario)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_menuprincipal
            // 
            this.lb_menuprincipal.AutoSize = true;
            this.lb_menuprincipal.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_menuprincipal.Location = new System.Drawing.Point(93, 9);
            this.lb_menuprincipal.Name = "lb_menuprincipal";
            this.lb_menuprincipal.Size = new System.Drawing.Size(127, 31);
            this.lb_menuprincipal.TabIndex = 0;
            this.lb_menuprincipal.Text = "Bienvenido";
            this.lb_menuprincipal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_menuprincipal.Click += new System.EventHandler(this.lb_menuprincipal_Click);
            // 
            // btn_agregarVuelo
            // 
            this.btn_agregarVuelo.Location = new System.Drawing.Point(12, 78);
            this.btn_agregarVuelo.Name = "btn_agregarVuelo";
            this.btn_agregarVuelo.Size = new System.Drawing.Size(96, 43);
            this.btn_agregarVuelo.TabIndex = 1;
            this.btn_agregarVuelo.Text = "Agregar Vuelo";
            this.btn_agregarVuelo.UseVisualStyleBackColor = true;
            this.btn_agregarVuelo.Click += new System.EventHandler(this.btn_agregarVuelo_Click);
            // 
            // dgv_menuPrincipal
            // 
            this.dgv_menuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menuPrincipal.Location = new System.Drawing.Point(361, 78);
            this.dgv_menuPrincipal.Name = "dgv_menuPrincipal";
            this.dgv_menuPrincipal.RowTemplate.Height = 25;
            this.dgv_menuPrincipal.Size = new System.Drawing.Size(643, 368);
            this.dgv_menuPrincipal.TabIndex = 2;
            this.dgv_menuPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menuPrincipal_CellContentClick);
            // 
            // btn_visualizarVuelos
            // 
            this.btn_visualizarVuelos.Location = new System.Drawing.Point(541, 7);
            this.btn_visualizarVuelos.Name = "btn_visualizarVuelos";
            this.btn_visualizarVuelos.Size = new System.Drawing.Size(101, 65);
            this.btn_visualizarVuelos.TabIndex = 3;
            this.btn_visualizarVuelos.Text = "Ver Vuelos";
            this.btn_visualizarVuelos.UseVisualStyleBackColor = true;
            this.btn_visualizarVuelos.Click += new System.EventHandler(this.btn_visualizarVuelos_Click);
            // 
            // btn_AgregarPasajero
            // 
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(12, 127);
            this.btn_AgregarPasajero.Name = "btn_AgregarPasajero";
            this.btn_AgregarPasajero.Size = new System.Drawing.Size(96, 40);
            this.btn_AgregarPasajero.TabIndex = 4;
            this.btn_AgregarPasajero.Text = "Agregar Pasajero";
            this.btn_AgregarPasajero.UseVisualStyleBackColor = true;
            this.btn_AgregarPasajero.Click += new System.EventHandler(this.btn_AgregarPasajero_Click);
            // 
            // btn_VisualizarNaves
            // 
            this.btn_VisualizarNaves.Location = new System.Drawing.Point(451, 44);
            this.btn_VisualizarNaves.Name = "btn_VisualizarNaves";
            this.btn_VisualizarNaves.Size = new System.Drawing.Size(84, 28);
            this.btn_VisualizarNaves.TabIndex = 5;
            this.btn_VisualizarNaves.Text = "Ver Naves";
            this.btn_VisualizarNaves.UseVisualStyleBackColor = true;
            this.btn_VisualizarNaves.Click += new System.EventHandler(this.btn_VisualizarNaves_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(12, 397);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(93, 39);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dgv_secundario
            // 
            this.dgv_secundario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_secundario.Location = new System.Drawing.Point(121, 78);
            this.dgv_secundario.Name = "dgv_secundario";
            this.dgv_secundario.RowTemplate.Height = 25;
            this.dgv_secundario.Size = new System.Drawing.Size(234, 358);
            this.dgv_secundario.TabIndex = 7;
            // 
            // t_tiemposDeVuelo
            // 
            this.t_tiemposDeVuelo.Tick += new System.EventHandler(this.t_salidaVuelo_Tick);
            // 
            // btn_visualizarDestinos
            // 
            this.btn_visualizarDestinos.Location = new System.Drawing.Point(451, 7);
            this.btn_visualizarDestinos.Name = "btn_visualizarDestinos";
            this.btn_visualizarDestinos.Size = new System.Drawing.Size(84, 26);
            this.btn_visualizarDestinos.TabIndex = 8;
            this.btn_visualizarDestinos.Text = "Ver Destinos";
            this.btn_visualizarDestinos.UseVisualStyleBackColor = true;
            this.btn_visualizarDestinos.Click += new System.EventHandler(this.btn_visualizarDestinos_Click);
            // 
            // lbl_estadisticas
            // 
            this.lbl_estadisticas.AutoSize = true;
            this.lbl_estadisticas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_estadisticas.Location = new System.Drawing.Point(744, 9);
            this.lbl_estadisticas.Name = "lbl_estadisticas";
            this.lbl_estadisticas.Size = new System.Drawing.Size(16, 21);
            this.lbl_estadisticas.TabIndex = 9;
            this.lbl_estadisticas.Text = "-";
            // 
            // btn_visualizarPasajeros
            // 
            this.btn_visualizarPasajeros.Location = new System.Drawing.Point(361, 7);
            this.btn_visualizarPasajeros.Name = "btn_visualizarPasajeros";
            this.btn_visualizarPasajeros.Size = new System.Drawing.Size(84, 28);
            this.btn_visualizarPasajeros.TabIndex = 10;
            this.btn_visualizarPasajeros.Text = "Ver Pasajeros";
            this.btn_visualizarPasajeros.UseVisualStyleBackColor = true;
            this.btn_visualizarPasajeros.Click += new System.EventHandler(this.btn_visualizarPasajeros_Click);
            // 
            // btn_visualizarClientes
            // 
            this.btn_visualizarClientes.Location = new System.Drawing.Point(361, 44);
            this.btn_visualizarClientes.Name = "btn_visualizarClientes";
            this.btn_visualizarClientes.Size = new System.Drawing.Size(84, 28);
            this.btn_visualizarClientes.TabIndex = 11;
            this.btn_visualizarClientes.Text = "Ver Clientes";
            this.btn_visualizarClientes.UseVisualStyleBackColor = true;
            this.btn_visualizarClientes.Click += new System.EventHandler(this.btn_visualizarClientes_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(12, 173);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(96, 43);
            this.btn_ayuda.TabIndex = 12;
            this.btn_ayuda.Text = "Ayuda";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 448);
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
    }
}