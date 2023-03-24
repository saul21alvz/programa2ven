namespace programa2ven
{
    partial class datos
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.btngua = new System.Windows.Forms.Button();
            this.txtpass2 = new System.Windows.Forms.TextBox();
            this.txtusuario2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(170, 154);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(100, 47);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngua
            // 
            this.btngua.Location = new System.Drawing.Point(31, 154);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(100, 47);
            this.btngua.TabIndex = 11;
            this.btngua.Text = "Guardar";
            this.btngua.UseVisualStyleBackColor = true;
            this.btngua.Click += new System.EventHandler(this.btnacep_Click);
            // 
            // txtpass2
            // 
            this.txtpass2.Location = new System.Drawing.Point(104, 76);
            this.txtpass2.Name = "txtpass2";
            this.txtpass2.Size = new System.Drawing.Size(73, 22);
            this.txtpass2.TabIndex = 10;
            this.txtpass2.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpass2_KeyPress);
            // 
            // txtusuario2
            // 
            this.txtusuario2.Location = new System.Drawing.Point(104, 13);
            this.txtusuario2.Name = "txtusuario2";
            this.txtusuario2.Size = new System.Drawing.Size(73, 22);
            this.txtusuario2.TabIndex = 9;
            this.txtusuario2.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            this.txtusuario2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngua);
            this.Controls.Add(this.txtpass2);
            this.Controls.Add(this.txtusuario2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "datos";
            this.Text = "datos";
            this.Load += new System.EventHandler(this.datos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.TextBox txtpass2;
        private System.Windows.Forms.TextBox txtusuario2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}