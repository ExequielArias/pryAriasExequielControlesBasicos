namespace pryAriasExequielControlesBasicos
{
    partial class frmSecundario
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
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.lblEscribir = new System.Windows.Forms.Label();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.cmdAsignar = new System.Windows.Forms.Button();
            this.chkLeche = new System.Windows.Forms.CheckBox();
            this.chkArroz = new System.Windows.Forms.CheckBox();
            this.chkAceite = new System.Windows.Forms.CheckBox();
            this.lblEscriba = new System.Windows.Forms.Label();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.gpbAdicional = new System.Windows.Forms.GroupBox();
            this.cboMostrar = new System.Windows.Forms.ComboBox();
            this.gpbAdicional.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEscribir
            // 
            this.txtEscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEscribir.Location = new System.Drawing.Point(122, 25);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(350, 20);
            this.txtEscribir.TabIndex = 0;
            this.txtEscribir.Click += new System.EventHandler(this.textBox1_Click);
            this.txtEscribir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEscribir
            // 
            this.lblEscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEscribir.AutoSize = true;
            this.lblEscribir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscribir.Location = new System.Drawing.Point(189, 140);
            this.lblEscribir.Name = "lblEscribir";
            this.lblEscribir.Size = new System.Drawing.Size(234, 23);
            this.lblEscribir.TabIndex = 1;
            this.lblEscribir.Text = "El texto escrito figurarà aquì";
            // 
            // optRojo
            // 
            this.optRojo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(158, 85);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 2;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(232, 85);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // cmdAsignar
            // 
            this.cmdAsignar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdAsignar.Location = new System.Drawing.Point(325, 85);
            this.cmdAsignar.Name = "cmdAsignar";
            this.cmdAsignar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsignar.TabIndex = 4;
            this.cmdAsignar.Text = "Asignar";
            this.cmdAsignar.UseVisualStyleBackColor = true;
            this.cmdAsignar.Click += new System.EventHandler(this.cmdAsignar_Click);
            // 
            // chkLeche
            // 
            this.chkLeche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkLeche.AutoSize = true;
            this.chkLeche.Location = new System.Drawing.Point(12, 19);
            this.chkLeche.Name = "chkLeche";
            this.chkLeche.Size = new System.Drawing.Size(56, 17);
            this.chkLeche.TabIndex = 6;
            this.chkLeche.Text = "Leche";
            this.chkLeche.UseVisualStyleBackColor = true;
            // 
            // chkArroz
            // 
            this.chkArroz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkArroz.AutoSize = true;
            this.chkArroz.Location = new System.Drawing.Point(12, 42);
            this.chkArroz.Name = "chkArroz";
            this.chkArroz.Size = new System.Drawing.Size(50, 17);
            this.chkArroz.TabIndex = 7;
            this.chkArroz.Text = "Arroz";
            this.chkArroz.UseVisualStyleBackColor = true;
            // 
            // chkAceite
            // 
            this.chkAceite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAceite.AutoSize = true;
            this.chkAceite.Location = new System.Drawing.Point(12, 65);
            this.chkAceite.Name = "chkAceite";
            this.chkAceite.Size = new System.Drawing.Size(56, 17);
            this.chkAceite.TabIndex = 8;
            this.chkAceite.Text = "Aceite";
            this.chkAceite.UseVisualStyleBackColor = true;
            // 
            // lblEscriba
            // 
            this.lblEscriba.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEscriba.AutoSize = true;
            this.lblEscriba.Location = new System.Drawing.Point(302, 262);
            this.lblEscriba.Name = "lblEscriba";
            this.lblEscriba.Size = new System.Drawing.Size(37, 13);
            this.lblEscriba.TabIndex = 9;
            this.lblEscriba.Text = "_____";
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdMostrar.Location = new System.Drawing.Point(24, 281);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 10;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // gpbAdicional
            // 
            this.gpbAdicional.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gpbAdicional.Controls.Add(this.chkAceite);
            this.gpbAdicional.Controls.Add(this.chkArroz);
            this.gpbAdicional.Controls.Add(this.chkLeche);
            this.gpbAdicional.Location = new System.Drawing.Point(12, 168);
            this.gpbAdicional.Name = "gpbAdicional";
            this.gpbAdicional.Size = new System.Drawing.Size(136, 107);
            this.gpbAdicional.TabIndex = 11;
            this.gpbAdicional.TabStop = false;
            this.gpbAdicional.Text = "Adicional";
            // 
            // cboMostrar
            // 
            this.cboMostrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMostrar.FormattingEnabled = true;
            this.cboMostrar.Location = new System.Drawing.Point(12, 310);
            this.cboMostrar.Name = "cboMostrar";
            this.cboMostrar.Size = new System.Drawing.Size(121, 21);
            this.cboMostrar.TabIndex = 12;
            // 
            // frmSecundario
            // 
            this.AcceptButton = this.cmdMostrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 473);
            this.Controls.Add(this.cboMostrar);
            this.Controls.Add(this.gpbAdicional);
            this.Controls.Add(this.cmdMostrar);
            this.Controls.Add(this.lblEscriba);
            this.Controls.Add(this.cmdAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.lblEscribir);
            this.Controls.Add(this.txtEscribir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSecundario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secundario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSecundario_Load);
            this.gpbAdicional.ResumeLayout(false);
            this.gpbAdicional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
        private System.Windows.Forms.CheckBox chkLeche;
        private System.Windows.Forms.CheckBox chkArroz;
        private System.Windows.Forms.CheckBox chkAceite;
        private System.Windows.Forms.Label lblEscriba;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.GroupBox gpbAdicional;
        private System.Windows.Forms.ComboBox cboMostrar;
    }
}