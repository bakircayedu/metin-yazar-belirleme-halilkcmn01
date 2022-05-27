
namespace VeriYapılarıOdev2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtYol = new System.Windows.Forms.TextBox();
            this.btnUploadText = new System.Windows.Forms.Button();
            this.btnHeap = new System.Windows.Forms.Button();
            this.txtCumle = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.txtFrekans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtYol
            // 
            this.txtYol.Location = new System.Drawing.Point(12, 82);
            this.txtYol.Name = "txtYol";
            this.txtYol.Size = new System.Drawing.Size(458, 20);
            this.txtYol.TabIndex = 0;
            // 
            // btnUploadText
            // 
            this.btnUploadText.Location = new System.Drawing.Point(498, 80);
            this.btnUploadText.Name = "btnUploadText";
            this.btnUploadText.Size = new System.Drawing.Size(75, 23);
            this.btnUploadText.TabIndex = 1;
            this.btnUploadText.Text = "Dosya Aç";
            this.btnUploadText.UseVisualStyleBackColor = true;
            this.btnUploadText.Click += new System.EventHandler(this.btnDosyaYukle_Click);
            // 
            // btnHeap
            // 
            this.btnHeap.Location = new System.Drawing.Point(688, 196);
            this.btnHeap.Name = "btnHeap";
            this.btnHeap.Size = new System.Drawing.Size(84, 126);
            this.btnHeap.TabIndex = 2;
            this.btnHeap.Text = "Heap";
            this.btnHeap.UseVisualStyleBackColor = true;
            // 
            // txtCumle
            // 
            this.txtCumle.Location = new System.Drawing.Point(172, 199);
            this.txtCumle.Name = "txtCumle";
            this.txtCumle.Size = new System.Drawing.Size(458, 20);
            this.txtCumle.TabIndex = 3;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(172, 255);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(458, 20);
            this.txtKelime.TabIndex = 3;
            // 
            // txtFrekans
            // 
            this.txtFrekans.Location = new System.Drawing.Point(172, 302);
            this.txtFrekans.Name = "txtFrekans";
            this.txtFrekans.Size = new System.Drawing.Size(458, 20);
            this.txtFrekans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cumle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kelime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Frekans";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrekans);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.txtCumle);
            this.Controls.Add(this.btnHeap);
            this.Controls.Add(this.btnUploadText);
            this.Controls.Add(this.txtYol);
            this.Name = "Form1";
            this.Text = "Kelime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtYol;
        private System.Windows.Forms.Button btnUploadText;
        private System.Windows.Forms.Button btnHeap;
        private System.Windows.Forms.TextBox txtCumle;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.TextBox txtFrekans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

