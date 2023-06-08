namespace dbmsProject
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            KullanıcıAdı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            KullanıcıSifre = new TextBox();
            girisbtn = new Button();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // KullanıcıAdı
            // 
            KullanıcıAdı.Location = new Point(226, 206);
            KullanıcıAdı.Margin = new Padding(4, 3, 4, 3);
            KullanıcıAdı.Name = "KullanıcıAdı";
            KullanıcıAdı.Size = new Size(249, 28);
            KullanıcıAdı.TabIndex = 0;
            KullanıcıAdı.TextChanged += KullanıcıAdı_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(76, 208);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 22);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(61, 293);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 22);
            label2.TabIndex = 2;
            label2.Text = "Kullanıcı Şifre:";
            // 
            // KullanıcıSifre
            // 
            KullanıcıSifre.Location = new Point(226, 287);
            KullanıcıSifre.Margin = new Padding(4, 3, 4, 3);
            KullanıcıSifre.Name = "KullanıcıSifre";
            KullanıcıSifre.PasswordChar = '*';
            KullanıcıSifre.Size = new Size(249, 28);
            KullanıcıSifre.TabIndex = 3;
            // 
            // girisbtn
            // 
            girisbtn.BackColor = SystemColors.ActiveCaption;
            girisbtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            girisbtn.Location = new Point(281, 370);
            girisbtn.Margin = new Padding(4, 3, 4, 3);
            girisbtn.Name = "girisbtn";
            girisbtn.Size = new Size(129, 70);
            girisbtn.TabIndex = 5;
            girisbtn.Text = "Giriş";
            girisbtn.UseVisualStyleBackColor = false;
            girisbtn.Click += girisbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 52);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // AdminGiris
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(710, 650);
            Controls.Add(pictureBox1);
            Controls.Add(girisbtn);
            Controls.Add(KullanıcıSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(KullanıcıAdı);
            Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdminGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Girişi";
         
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KullanıcıAdı;
        private Label label1;
        private Label label2;
        private TextBox KullanıcıSifre;
        private Button girisbtn;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}