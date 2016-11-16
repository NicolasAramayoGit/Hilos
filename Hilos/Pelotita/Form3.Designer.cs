namespace Pelotita
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_pausar = new System.Windows.Forms.Button();
            this.btn_reanuda = new System.Windows.Forms.Button();
            this.btn_destruir = new System.Windows.Forms.Button();
            this.lbl_contador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(613, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(12, 209);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(166, 23);
            this.btn_Crear.TabIndex = 1;
            this.btn_Crear.Text = "Crear &Pelotita";
            this.btn_Crear.UseVisualStyleBackColor = true;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_pausar
            // 
            this.btn_pausar.Location = new System.Drawing.Point(193, 209);
            this.btn_pausar.Name = "btn_pausar";
            this.btn_pausar.Size = new System.Drawing.Size(107, 23);
            this.btn_pausar.TabIndex = 2;
            this.btn_pausar.Text = "pausar";
            this.btn_pausar.UseVisualStyleBackColor = true;
            this.btn_pausar.Click += new System.EventHandler(this.btn_pausar_Click);
            // 
            // btn_reanuda
            // 
            this.btn_reanuda.Location = new System.Drawing.Point(306, 209);
            this.btn_reanuda.Name = "btn_reanuda";
            this.btn_reanuda.Size = new System.Drawing.Size(97, 23);
            this.btn_reanuda.TabIndex = 3;
            this.btn_reanuda.Text = "reanuda";
            this.btn_reanuda.UseVisualStyleBackColor = true;
            this.btn_reanuda.Click += new System.EventHandler(this.btn_reanuda_Click);
            // 
            // btn_destruir
            // 
            this.btn_destruir.Location = new System.Drawing.Point(478, 209);
            this.btn_destruir.Name = "btn_destruir";
            this.btn_destruir.Size = new System.Drawing.Size(98, 23);
            this.btn_destruir.TabIndex = 4;
            this.btn_destruir.Text = "Destruir Pelotita";
            this.btn_destruir.UseVisualStyleBackColor = true;
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Location = new System.Drawing.Point(420, 214);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(35, 13);
            this.lbl_contador.TabIndex = 5;
            this.lbl_contador.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 262);
            this.Controls.Add(this.lbl_contador);
            this.Controls.Add(this.btn_destruir);
            this.Controls.Add(this.btn_reanuda);
            this.Controls.Add(this.btn_pausar);
            this.Controls.Add(this.btn_Crear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.Button btn_pausar;
        private System.Windows.Forms.Button btn_reanuda;
        private System.Windows.Forms.Button btn_destruir;
        private System.Windows.Forms.Label lbl_contador;
    }
}