namespace SeguridadInformacion
{
    partial class FormEncriptado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.txtM2 = new System.Windows.Forms.TextBox();
            this.rtbCodificado = new System.Windows.Forms.RichTextBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SeguridadInformacion.Properties.Resources.encriptar_telefono_movil;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtb2);
            this.panel1.Controls.Add(this.txtM2);
            this.panel1.Controls.Add(this.rtbCodificado);
            this.panel1.Controls.Add(this.btnEncriptar);
            this.panel1.Controls.Add(this.txtMensaje);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 374);
            this.panel1.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(306, 262);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(352, 23);
            this.btn.TabIndex = 12;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(284, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Escribe El Codigo A DesEncriptar";
            // 
            // rtb2
            // 
            this.rtb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb2.Location = new System.Drawing.Point(306, 293);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(352, 60);
            this.rtb2.TabIndex = 10;
            this.rtb2.Text = "";
            // 
            // txtM2
            // 
            this.txtM2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM2.Location = new System.Drawing.Point(306, 235);
            this.txtM2.Name = "txtM2";
            this.txtM2.Size = new System.Drawing.Size(352, 20);
            this.txtM2.TabIndex = 8;
            // 
            // rtbCodificado
            // 
            this.rtbCodificado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbCodificado.Location = new System.Drawing.Point(310, 130);
            this.rtbCodificado.Name = "rtbCodificado";
            this.rtbCodificado.Size = new System.Drawing.Size(352, 60);
            this.rtbCodificado.TabIndex = 7;
            this.rtbCodificado.Text = "";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEncriptar.FlatAppearance.BorderSize = 0;
            this.btnEncriptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Location = new System.Drawing.Point(310, 98);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(352, 26);
            this.btnEncriptar.TabIndex = 6;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMensaje.Location = new System.Drawing.Point(310, 72);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(352, 20);
            this.txtMensaje.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensaje.Location = new System.Drawing.Point(312, 35);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(346, 21);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Escribe La Frase A Encriptar";
            // 
            // FormEncriptado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 374);
            this.Controls.Add(this.panel1);
            this.Name = "FormEncriptado";
            this.Text = "FormEncriptado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbCodificado;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.TextBox txtM2;
        private System.Windows.Forms.Button btn;
    }
}