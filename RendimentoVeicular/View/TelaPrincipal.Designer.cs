
namespace RendimentoVeicular.View
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimentos = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.lblRendimentoResul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(207, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(236, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cálculo de combustível";
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKM.Location = new System.Drawing.Point(56, 146);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(33, 19);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "KM:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLitros.Location = new System.Drawing.Point(56, 210);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(46, 19);
            this.lblLitros.TabIndex = 3;
            this.lblLitros.Text = "Litros:";
            // 
            // lblRendimentos
            // 
            this.lblRendimentos.AutoSize = true;
            this.lblRendimentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRendimentos.Location = new System.Drawing.Point(353, 119);
            this.lblRendimentos.Name = "lblRendimentos";
            this.lblRendimentos.Size = new System.Drawing.Size(156, 19);
            this.lblRendimentos.TabIndex = 4;
            this.lblRendimentos.Text = "Rendimento - Km/Litros";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConsumo.Location = new System.Drawing.Point(353, 184);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(142, 19);
            this.lblConsumo.TabIndex = 5;
            this.lblConsumo.Text = "Consumo - Litros/KM";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(113, 146);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(110, 23);
            this.tbxKM.TabIndex = 6;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(113, 210);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(110, 23);
            this.tbxLitros.TabIndex = 7;
            // 
            // lblCalculo
            // 
            this.lblCalculo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblCalculo.Location = new System.Drawing.Point(353, 213);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(135, 23);
            this.lblCalculo.TabIndex = 9;
            this.lblCalculo.Tag = "1";
            // 
            // lblRendimentoResul
            // 
            this.lblRendimentoResul.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRendimentoResul.Location = new System.Drawing.Point(353, 146);
            this.lblRendimentoResul.Name = "lblRendimentoResul";
            this.lblRendimentoResul.Size = new System.Drawing.Size(135, 23);
            this.lblRendimentoResul.TabIndex = 10;
            this.lblRendimentoResul.Tag = "1";
            this.lblRendimentoResul.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(179, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRendimentoResul);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimentos);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "Sistema de consumo de combustível";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaPrincipal_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimentos;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Label lblRendimentoCalculo;
        private System.Windows.Forms.Label lblCalculo;
        private System.Windows.Forms.Label lblRendimentoResul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}