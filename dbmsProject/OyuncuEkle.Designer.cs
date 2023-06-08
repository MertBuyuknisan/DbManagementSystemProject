namespace dbmsProject
{
    partial class OyuncuEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuEkle));
            OyuncuAdtxt = new TextBox();
            OyuncuSoyadtxt = new TextBox();
            OyuncuDegertxt = new TextBox();
            OyuncuTakımtxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            oyuncukayıt = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            OyuncuYastxt = new TextBox();
            AtılanGoltxt = new TextBox();
            label6 = new Label();
            asisttxt = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // OyuncuAdtxt
            // 
            OyuncuAdtxt.Location = new Point(446, 11);
            OyuncuAdtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuAdtxt.Name = "OyuncuAdtxt";
            OyuncuAdtxt.Size = new Size(140, 27);
            OyuncuAdtxt.TabIndex = 0;
            OyuncuAdtxt.TextChanged += OyuncuAdtxt_TextChanged;
            // 
            // OyuncuSoyadtxt
            // 
            OyuncuSoyadtxt.Location = new Point(446, 66);
            OyuncuSoyadtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuSoyadtxt.Name = "OyuncuSoyadtxt";
            OyuncuSoyadtxt.Size = new Size(140, 27);
            OyuncuSoyadtxt.TabIndex = 1;
            // 
            // OyuncuDegertxt
            // 
            OyuncuDegertxt.Location = new Point(446, 130);
            OyuncuDegertxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuDegertxt.Name = "OyuncuDegertxt";
            OyuncuDegertxt.Size = new Size(140, 27);
            OyuncuDegertxt.TabIndex = 2;
            // 
            // OyuncuTakımtxt
            // 
            OyuncuTakımtxt.Location = new Point(446, 197);
            OyuncuTakımtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuTakımtxt.Name = "OyuncuTakımtxt";
            OyuncuTakımtxt.Size = new Size(140, 27);
            OyuncuTakımtxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(248, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 4;
            label1.Text = "Oyuncunun Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(248, 70);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 5;
            label2.Text = "Oyuncunun Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(248, 134);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 6;
            label3.Text = "Oyuncunun Değeri :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(248, 201);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 22);
            label4.TabIndex = 7;
            label4.Text = "Oyuncunun Takımı :";
            // 
            // oyuncukayıt
            // 
            oyuncukayıt.BackColor = SystemColors.ActiveCaption;
            oyuncukayıt.FlatStyle = FlatStyle.Flat;
            oyuncukayıt.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            oyuncukayıt.Image = (Image)resources.GetObject("oyuncukayıt.Image");
            oyuncukayıt.ImageAlign = ContentAlignment.MiddleLeft;
            oyuncukayıt.Location = new Point(361, 455);
            oyuncukayıt.Margin = new Padding(4, 3, 4, 3);
            oyuncukayıt.Name = "oyuncukayıt";
            oyuncukayıt.Size = new Size(227, 71);
            oyuncukayıt.TabIndex = 8;
            oyuncukayıt.Text = "Kaydet";
            oyuncukayıt.UseVisualStyleBackColor = false;
            oyuncukayıt.Click += oyuncukayıt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(620, 11);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(817, 351);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(248, 266);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 22);
            label5.TabIndex = 10;
            label5.Text = "Oyuncunun Yaşı :";
            // 
            // OyuncuYastxt
            // 
            OyuncuYastxt.Location = new Point(448, 261);
            OyuncuYastxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuYastxt.Name = "OyuncuYastxt";
            OyuncuYastxt.Size = new Size(140, 27);
            OyuncuYastxt.TabIndex = 11;
            // 
            // AtılanGoltxt
            // 
            AtılanGoltxt.Location = new Point(446, 332);
            AtılanGoltxt.Margin = new Padding(4, 3, 4, 3);
            AtılanGoltxt.Name = "AtılanGoltxt";
            AtılanGoltxt.Size = new Size(140, 27);
            AtılanGoltxt.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(248, 336);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 22);
            label6.TabIndex = 12;
            label6.Text = "Atılan Gol :";
            // 
            // asisttxt
            // 
            asisttxt.Location = new Point(446, 400);
            asisttxt.Margin = new Padding(4, 3, 4, 3);
            asisttxt.Name = "asisttxt";
            asisttxt.Size = new Size(140, 27);
            asisttxt.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(248, 405);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(128, 22);
            label7.TabIndex = 14;
            label7.Text = "Yapılan Asist :";
            label7.Click += label7_Click;
            // 
            // OyuncuEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1732, 613);
            Controls.Add(asisttxt);
            Controls.Add(label7);
            Controls.Add(AtılanGoltxt);
            Controls.Add(label6);
            Controls.Add(OyuncuYastxt);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(oyuncukayıt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OyuncuTakımtxt);
            Controls.Add(OyuncuDegertxt);
            Controls.Add(OyuncuSoyadtxt);
            Controls.Add(OyuncuAdtxt);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "OyuncuEkle";
            Text = "Oyuncu Ekle";
            Load += OyuncuEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OyuncuAdtxt;
        private TextBox OyuncuSoyadtxt;
        private TextBox OyuncuDegertxt;
        private TextBox OyuncuTakımtxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button oyuncukayıt;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox OyuncuYastxt;
        private TextBox AtılanGoltxt;
        private Label label6;
        private TextBox asisttxt;
        private Label label7;
    }
}