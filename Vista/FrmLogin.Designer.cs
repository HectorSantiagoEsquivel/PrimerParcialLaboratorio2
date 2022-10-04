namespace Vista
{
    partial class FrmLogin
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
            this.btn_entrar = new System.Windows.Forms.Button();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_backdoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(12, 238);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 0;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(12, 113);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.PlaceholderText = "Contraseña";
            this.tb_pass.Size = new System.Drawing.Size(100, 23);
            this.tb_pass.TabIndex = 1;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(12, 57);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.PlaceholderText = "Usuario";
            this.tb_usuario.Size = new System.Drawing.Size(100, 23);
            this.tb_usuario.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(12, 173);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(10, 15);
            this.lbl_login.TabIndex = 3;
            this.lbl_login.Text = " ";
            this.lbl_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_backdoor
            // 
            this.btn_backdoor.Location = new System.Drawing.Point(152, 238);
            this.btn_backdoor.Name = "btn_backdoor";
            this.btn_backdoor.Size = new System.Drawing.Size(75, 58);
            this.btn_backdoor.TabIndex = 4;
            this.btn_backdoor.Text = "Entrar sin Usuario";
            this.btn_backdoor.UseVisualStyleBackColor = true;
            this.btn_backdoor.Click += new System.EventHandler(this.btn_backdoor_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 314);
            this.Controls.Add(this.btn_backdoor);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.btn_entrar);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_backdoor;
    }
}