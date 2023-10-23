namespace Ders13_WindowsService_TCkimlik_Kontrol
{
    partial class TcKimlikSorgulama
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tckimlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Soyisim = new System.Windows.Forms.TextBox();
            this.txt_doğum = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(186, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TCKİMLİK :";
            // 
            // txt_tckimlik
            // 
            this.txt_tckimlik.ForeColor = System.Drawing.Color.Blue;
            this.txt_tckimlik.Location = new System.Drawing.Point(419, 51);
            this.txt_tckimlik.Name = "txt_tckimlik";
            this.txt_tckimlik.Size = new System.Drawing.Size(100, 20);
            this.txt_tckimlik.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(186, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "İSİM :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(186, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOYİSİM :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOĞUM YILI :";
            // 
            // txt_Soyisim
            // 
            this.txt_Soyisim.ForeColor = System.Drawing.Color.Blue;
            this.txt_Soyisim.Location = new System.Drawing.Point(419, 121);
            this.txt_Soyisim.Name = "txt_Soyisim";
            this.txt_Soyisim.Size = new System.Drawing.Size(100, 20);
            this.txt_Soyisim.TabIndex = 5;
            // 
            // txt_doğum
            // 
            this.txt_doğum.ForeColor = System.Drawing.Color.Blue;
            this.txt_doğum.Location = new System.Drawing.Point(419, 156);
            this.txt_doğum.Name = "txt_doğum";
            this.txt_doğum.Size = new System.Drawing.Size(100, 20);
            this.txt_doğum.TabIndex = 6;
            this.txt_doğum.TextChanged += new System.EventHandler(this.txt_doğum_TextChanged);
            // 
            // txt_isim
            // 
            this.txt_isim.ForeColor = System.Drawing.Color.Blue;
            this.txt_isim.Location = new System.Drawing.Point(419, 86);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_isim.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_save.Location = new System.Drawing.Point(267, 277);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(198, 66);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "KAYDET ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // TcKimlikSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(699, 386);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_doğum);
            this.Controls.Add(this.txt_Soyisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tckimlik);
            this.Controls.Add(this.label1);
            this.Name = "TcKimlikSorgulama";
            this.Text = "Tc Kimlik Sorgusu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tckimlik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Soyisim;
        private System.Windows.Forms.TextBox txt_doğum;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Button btn_save;
    }
}

