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
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 473);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.Label lblEscribir;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button cmdAsignar;
    }
}