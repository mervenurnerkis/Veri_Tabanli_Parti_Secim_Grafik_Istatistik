
namespace Veri_Tabanlı_Parti_Secim_Grafik_Istatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIlce = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnGrafikler = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE AD:";
            // 
            // TxtIlce
            // 
            this.TxtIlce.Location = new System.Drawing.Point(165, 51);
            this.TxtIlce.Name = "TxtIlce";
            this.TxtIlce.Size = new System.Drawing.Size(402, 34);
            this.TxtIlce.TabIndex = 1;
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(165, 236);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(402, 34);
            this.TxtC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "C PARTİ:";
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(165, 347);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(402, 34);
            this.TxtE.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // TxtD
            // 
            this.TxtD.Location = new System.Drawing.Point(165, 290);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(402, 34);
            this.TxtD.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "E PARTİ:";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(165, 187);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(402, 34);
            this.TxtB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(165, 129);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(402, 34);
            this.TxtA.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "A PARTİ:";
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(165, 406);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(402, 51);
            this.BtnGiris.TabIndex = 12;
            this.BtnGiris.Text = "OY GİRİŞİ YAP";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnGrafikler
            // 
            this.BtnGrafikler.Location = new System.Drawing.Point(165, 463);
            this.BtnGrafikler.Name = "BtnGrafikler";
            this.BtnGrafikler.Size = new System.Drawing.Size(203, 57);
            this.BtnGrafikler.TabIndex = 13;
            this.BtnGrafikler.Text = "GRAFİKLER";
            this.BtnGrafikler.UseVisualStyleBackColor = true;
            this.BtnGrafikler.Click += new System.EventHandler(this.BtnGrafikler_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(374, 463);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(193, 57);
            this.BtnCikis.TabIndex = 14;
            this.BtnCikis.Text = "ÇIKIŞ YAP";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 575);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnGrafikler);
            this.Controls.Add(this.BtnGiris);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIlce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "VTGS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIlce;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnGrafikler;
        private System.Windows.Forms.Button BtnCikis;
    }
}

