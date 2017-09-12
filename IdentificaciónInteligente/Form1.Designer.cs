namespace IdentificaciónInteligente
{
    partial class Form1
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
            this.bt_examinar = new System.Windows.Forms.Button();
            this.bt_tratamiento = new System.Windows.Forms.Button();
            this.bt_ = new System.Windows.Forms.Button();
            this.bt_salir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 185);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_examinar
            // 
            this.bt_examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_examinar.Image = global::IdentificaciónInteligente.Properties.Resources.examinar;
            this.bt_examinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_examinar.Location = new System.Drawing.Point(23, 263);
            this.bt_examinar.Name = "bt_examinar";
            this.bt_examinar.Size = new System.Drawing.Size(141, 50);
            this.bt_examinar.TabIndex = 1;
            this.bt_examinar.Text = "Examinar";
            this.bt_examinar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_examinar.UseVisualStyleBackColor = true;
            this.bt_examinar.Click += new System.EventHandler(this.bt_examinar_Click);
            // 
            // bt_tratamiento
            // 
            this.bt_tratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tratamiento.Location = new System.Drawing.Point(214, 263);
            this.bt_tratamiento.Name = "bt_tratamiento";
            this.bt_tratamiento.Size = new System.Drawing.Size(139, 50);
            this.bt_tratamiento.TabIndex = 2;
            this.bt_tratamiento.Text = "Tratamiento";
            this.bt_tratamiento.UseVisualStyleBackColor = true;
            this.bt_tratamiento.Click += new System.EventHandler(this.bt_tratamiento_Click);
            // 
            // bt_
            // 
            this.bt_.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_.Image = global::IdentificaciónInteligente.Properties.Resources.cancelar;
            this.bt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_.Location = new System.Drawing.Point(390, 263);
            this.bt_.Name = "bt_";
            this.bt_.Size = new System.Drawing.Size(135, 50);
            this.bt_.TabIndex = 3;
            this.bt_.Text = "Cancelar";
            this.bt_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_.UseVisualStyleBackColor = true;
            // 
            // bt_salir
            // 
            this.bt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = global::IdentificaciónInteligente.Properties.Resources.salir;
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(429, 334);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(96, 50);
            this.bt_salir.TabIndex = 4;
            this.bt_salir.Text = "Salir";
            this.bt_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 185);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Procedimiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_salir);
            this.Controls.Add(this.bt_);
            this.Controls.Add(this.bt_tratamiento);
            this.Controls.Add(this.bt_examinar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_examinar;
        private System.Windows.Forms.Button bt_tratamiento;
        private System.Windows.Forms.Button bt_;
        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}