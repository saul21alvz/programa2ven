﻿namespace programa2ven
{
    partial class Productos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnguarda = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbfoto = new System.Windows.Forms.PictureBox();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btnbuscar);
            this.panel3.Controls.Add(this.pbfoto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 350);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnguarda);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 100);
            this.panel4.TabIndex = 2;
            // 
            // btnguarda
            // 
            this.btnguarda.Location = new System.Drawing.Point(174, 43);
            this.btnguarda.Name = "btnguarda";
            this.btnguarda.Size = new System.Drawing.Size(139, 23);
            this.btnguarda.TabIndex = 0;
            this.btnguarda.Text = "Guardar producto";
            this.btnguarda.UseVisualStyleBackColor = true;
            this.btnguarda.Click += new System.EventHandler(this.btnguarda_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pbfoto
            // 
            this.pbfoto.Location = new System.Drawing.Point(381, 62);
            this.pbfoto.Name = "pbfoto";
            this.pbfoto.Size = new System.Drawing.Size(100, 50);
            this.pbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfoto.TabIndex = 0;
            this.pbfoto.TabStop = false;
            // 
            // Btnbuscar
            // 
            this.Btnbuscar.Location = new System.Drawing.Point(381, 176);
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.Size = new System.Drawing.Size(126, 23);
            this.Btnbuscar.TabIndex = 1;
            this.Btnbuscar.Text = "Buscar imagen";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnguarda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.PictureBox pbfoto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}