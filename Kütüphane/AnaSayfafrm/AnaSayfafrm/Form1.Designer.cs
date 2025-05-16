namespace AnaSayfafrm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            btnUyeEkle = new Button();
            btnUyeListele = new Button();
            btnKitapListele = new Button();
            btnKitapEkle = new Button();
            btnEmanetListele = new Button();
            btnEmanetVer = new Button();
            button7 = new Button();
            btnEmanetİade = new Button();
            btnGrafik = new Button();
            btnSiralama = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUyeListele);
            groupBox1.Controls.Add(btnUyeEkle);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10.2F);
            groupBox1.Location = new Point(46, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Üye İşlemleri";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnKitapListele);
            groupBox2.Controls.Add(btnKitapEkle);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10.2F);
            groupBox2.Location = new Point(633, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(435, 139);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap İşlemleri";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(btnEmanetİade);
            groupBox3.Controls.Add(btnEmanetListele);
            groupBox3.Controls.Add(btnEmanetVer);
            groupBox3.Font = new Font("Microsoft Sans Serif", 10.2F);
            groupBox3.Location = new Point(46, 283);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(435, 260);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnGrafik);
            groupBox4.Controls.Add(btnSiralama);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10.2F);
            groupBox4.Location = new Point(633, 342);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(435, 139);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sıralama ve Grafikler";
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnUyeEkle.Location = new Point(27, 33);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(375, 36);
            btnUyeEkle.TabIndex = 0;
            btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            btnUyeEkle.UseVisualStyleBackColor = true;
            // 
            // btnUyeListele
            // 
            btnUyeListele.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnUyeListele.Location = new Point(27, 87);
            btnUyeListele.Name = "btnUyeListele";
            btnUyeListele.Size = new Size(375, 33);
            btnUyeListele.TabIndex = 0;
            btnUyeListele.Text = "Üye Listeleme İşlemleri";
            btnUyeListele.UseVisualStyleBackColor = true;
            // 
            // btnKitapListele
            // 
            btnKitapListele.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnKitapListele.Location = new Point(28, 87);
            btnKitapListele.Name = "btnKitapListele";
            btnKitapListele.Size = new Size(375, 33);
            btnKitapListele.TabIndex = 4;
            btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            btnKitapListele.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            btnKitapEkle.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnKitapEkle.Location = new Point(28, 33);
            btnKitapEkle.Name = "btnKitapEkle";
            btnKitapEkle.Size = new Size(375, 36);
            btnKitapEkle.TabIndex = 5;
            btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // btnEmanetListele
            // 
            btnEmanetListele.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnEmanetListele.Location = new Point(27, 80);
            btnEmanetListele.Name = "btnEmanetListele";
            btnEmanetListele.Size = new Size(375, 33);
            btnEmanetListele.TabIndex = 4;
            btnEmanetListele.Text = "Emanet Kitap Listeleme İşlemleri";
            btnEmanetListele.UseVisualStyleBackColor = true;
            // 
            // btnEmanetVer
            // 
            btnEmanetVer.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnEmanetVer.Location = new Point(27, 26);
            btnEmanetVer.Name = "btnEmanetVer";
            btnEmanetVer.Size = new Size(375, 36);
            btnEmanetVer.TabIndex = 5;
            btnEmanetVer.Text = "Emanet Kitap Verme İşlemleri";
            btnEmanetVer.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 10.2F);
            button7.Location = new Point(27, 187);
            button7.Name = "button7";
            button7.Size = new Size(375, 33);
            button7.TabIndex = 6;
            button7.Text = "Üye Listeleme İşlemleri";
            button7.UseVisualStyleBackColor = true;
            // 
            // btnEmanetİade
            // 
            btnEmanetİade.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnEmanetİade.Location = new Point(27, 133);
            btnEmanetİade.Name = "btnEmanetİade";
            btnEmanetİade.Size = new Size(375, 36);
            btnEmanetİade.TabIndex = 7;
            btnEmanetİade.Text = "Emanet Kitap İade İşlemleri";
            btnEmanetİade.UseVisualStyleBackColor = true;
            // 
            // btnGrafik
            // 
            btnGrafik.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnGrafik.Location = new Point(28, 80);
            btnGrafik.Name = "btnGrafik";
            btnGrafik.Size = new Size(375, 33);
            btnGrafik.TabIndex = 1;
            btnGrafik.Text = "Grafikler";
            btnGrafik.UseVisualStyleBackColor = true;
            // 
            // btnSiralama
            // 
            btnSiralama.Font = new Font("Microsoft Sans Serif", 10.2F);
            btnSiralama.Location = new Point(28, 26);
            btnSiralama.Name = "btnSiralama";
            btnSiralama.Size = new Size(375, 36);
            btnSiralama.TabIndex = 2;
            btnSiralama.Text = "Sıralama";
            btnSiralama.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 609);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "AnaSayfa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button btnUyeListele;
        private Button btnUyeEkle;
        private Button btnKitapListele;
        private Button btnKitapEkle;
        private Button btnEmanetListele;
        private Button btnEmanetVer;
        private Button button7;
        private Button btnEmanetİade;
        private Button btnGrafik;
        private Button btnSiralama;
    }
}
