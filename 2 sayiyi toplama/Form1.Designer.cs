namespace _2_sayiyi_toplama
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
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.txtboxBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtboxİkinciSayi = new System.Windows.Forms.TextBox();
            this.btnToplama = new System.Windows.Forms.Button();
            this.tabGenel = new System.Windows.Forms.TabControl();
            this.tabToplama = new System.Windows.Forms.TabPage();
            this.txtboxToplam = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.tabLoglama = new System.Windows.Forms.TabPage();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.lvLog = new System.Windows.Forms.ListView();
            this.btnLoglama = new System.Windows.Forms.Button();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.btnEkranTemizle = new System.Windows.Forms.Button();
            this.tabGenel.SuspendLayout();
            this.tabToplama.SuspendLayout();
            this.tabLoglama.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(35, 42);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 0;
            this.lblBirinciSayi.Text = "Birinci Sayi";
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(35, 91);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 1;
            this.lblİkinciSayi.Text = "İkinci Sayi";
            // 
            // txtboxBirinciSayi
            // 
            this.txtboxBirinciSayi.Location = new System.Drawing.Point(113, 39);
            this.txtboxBirinciSayi.Name = "txtboxBirinciSayi";
            this.txtboxBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtboxBirinciSayi.TabIndex = 2;
            this.txtboxBirinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxBirinciSayi_KeyPress);
            // 
            // txtboxİkinciSayi
            // 
            this.txtboxİkinciSayi.Location = new System.Drawing.Point(113, 88);
            this.txtboxİkinciSayi.Name = "txtboxİkinciSayi";
            this.txtboxİkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtboxİkinciSayi.TabIndex = 3;
            this.txtboxİkinciSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxİkinciSayi_KeyPress);
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(38, 128);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(175, 23);
            this.btnToplama.TabIndex = 4;
            this.btnToplama.Text = "Topla";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // tabGenel
            // 
            this.tabGenel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGenel.Controls.Add(this.tabToplama);
            this.tabGenel.Controls.Add(this.tabLoglama);
            this.tabGenel.Location = new System.Drawing.Point(12, 12);
            this.tabGenel.Name = "tabGenel";
            this.tabGenel.SelectedIndex = 0;
            this.tabGenel.Size = new System.Drawing.Size(560, 429);
            this.tabGenel.TabIndex = 5;
            // 
            // tabToplama
            // 
            this.tabToplama.Controls.Add(this.btnEkranTemizle);
            this.tabToplama.Controls.Add(this.btnLoglama);
            this.tabToplama.Controls.Add(this.txtboxToplam);
            this.tabToplama.Controls.Add(this.lblToplam);
            this.tabToplama.Controls.Add(this.txtboxİkinciSayi);
            this.tabToplama.Controls.Add(this.lblİkinciSayi);
            this.tabToplama.Controls.Add(this.txtboxBirinciSayi);
            this.tabToplama.Controls.Add(this.btnToplama);
            this.tabToplama.Controls.Add(this.lblBirinciSayi);
            this.tabToplama.Location = new System.Drawing.Point(4, 22);
            this.tabToplama.Name = "tabToplama";
            this.tabToplama.Padding = new System.Windows.Forms.Padding(3);
            this.tabToplama.Size = new System.Drawing.Size(552, 403);
            this.tabToplama.TabIndex = 0;
            this.tabToplama.Text = "Toplama";
            this.tabToplama.UseVisualStyleBackColor = true;
            // 
            // txtboxToplam
            // 
            this.txtboxToplam.Enabled = false;
            this.txtboxToplam.Location = new System.Drawing.Point(116, 186);
            this.txtboxToplam.Name = "txtboxToplam";
            this.txtboxToplam.Size = new System.Drawing.Size(100, 20);
            this.txtboxToplam.TabIndex = 6;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(38, 189);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(45, 13);
            this.lblToplam.TabIndex = 5;
            this.lblToplam.Text = "Toplam:";
            // 
            // tabLoglama
            // 
            this.tabLoglama.Controls.Add(this.btnGeriGit);
            this.tabLoglama.Controls.Add(this.btnHepsiniSil);
            this.tabLoglama.Controls.Add(this.btnSecileniSil);
            this.tabLoglama.Controls.Add(this.lvLog);
            this.tabLoglama.Location = new System.Drawing.Point(4, 22);
            this.tabLoglama.Name = "tabLoglama";
            this.tabLoglama.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoglama.Size = new System.Drawing.Size(552, 403);
            this.tabLoglama.TabIndex = 1;
            this.tabLoglama.Text = "Loglama";
            this.tabLoglama.UseVisualStyleBackColor = true;
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.Location = new System.Drawing.Point(443, 349);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(92, 35);
            this.btnHepsiniSil.TabIndex = 2;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = true;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Location = new System.Drawing.Point(345, 349);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(92, 35);
            this.btnSecileniSil.TabIndex = 1;
            this.btnSecileniSil.Text = "Secileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            this.btnSecileniSil.Click += new System.EventHandler(this.btnSecileniSil_Click);
            // 
            // lvLog
            // 
            this.lvLog.Location = new System.Drawing.Point(6, 6);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(540, 391);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // btnLoglama
            // 
            this.btnLoglama.Location = new System.Drawing.Point(137, 242);
            this.btnLoglama.Name = "btnLoglama";
            this.btnLoglama.Size = new System.Drawing.Size(76, 23);
            this.btnLoglama.TabIndex = 7;
            this.btnLoglama.Text = ">> ileri >>";
            this.btnLoglama.UseVisualStyleBackColor = true;
            this.btnLoglama.Click += new System.EventHandler(this.btnLoglama_Click);
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.Location = new System.Drawing.Point(247, 349);
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.Size = new System.Drawing.Size(92, 35);
            this.btnGeriGit.TabIndex = 3;
            this.btnGeriGit.Text = "Geri Git";
            this.btnGeriGit.UseVisualStyleBackColor = true;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // btnEkranTemizle
            // 
            this.btnEkranTemizle.Location = new System.Drawing.Point(38, 242);
            this.btnEkranTemizle.Name = "btnEkranTemizle";
            this.btnEkranTemizle.Size = new System.Drawing.Size(76, 23);
            this.btnEkranTemizle.TabIndex = 8;
            this.btnEkranTemizle.Text = "Temizle";
            this.btnEkranTemizle.UseVisualStyleBackColor = true;
            this.btnEkranTemizle.Click += new System.EventHandler(this.btnEkranTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 453);
            this.Controls.Add(this.tabGenel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toplama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabGenel.ResumeLayout(false);
            this.tabToplama.ResumeLayout(false);
            this.tabToplama.PerformLayout();
            this.tabLoglama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.TextBox txtboxBirinciSayi;
        private System.Windows.Forms.TextBox txtboxİkinciSayi;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.TabControl tabGenel;
        private System.Windows.Forms.TabPage tabToplama;
        private System.Windows.Forms.TabPage tabLoglama;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.TextBox txtboxToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.Button btnLoglama;
        private System.Windows.Forms.Button btnGeriGit;
        private System.Windows.Forms.Button btnEkranTemizle;
    }
}

