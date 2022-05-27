namespace SeguridadInformacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Registro = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.vistaPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Registro);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_Registro
            // 
            this.btn_Registro.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Registro.FlatAppearance.BorderSize = 0;
            this.btn_Registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_Registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registro.Location = new System.Drawing.Point(453, 0);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Size = new System.Drawing.Size(75, 48);
            this.btn_Registro.TabIndex = 1;
            this.btn_Registro.Text = "Registro";
            this.btn_Registro.UseVisualStyleBackColor = true;
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // btn_login
            // 
            this.btn_login.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Location = new System.Drawing.Point(528, 0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 48);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_titulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(50, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 48);
            this.panel2.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(165, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(133, 23);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Criptología";
            // 
            // vistaPrincipal
            // 
            this.vistaPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.vistaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPrincipal.Location = new System.Drawing.Point(0, 50);
            this.vistaPrincipal.Name = "vistaPrincipal";
            this.vistaPrincipal.Size = new System.Drawing.Size(605, 283);
            this.vistaPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SeguridadInformacion.Properties.Resources.encriptado;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(605, 333);
            this.Controls.Add(this.vistaPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Registro;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel vistaPrincipal;
    }
}

