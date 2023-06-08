namespace dbmsProject
{
    partial class OyuncuGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuGüncelle));
            OyuncuGuncelle = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            OyuncuTakımtxt = new TextBox();
            OyuncuDegertxt = new TextBox();
            OyuncuSoyadtxt = new TextBox();
            OyuncuAdtxt = new TextBox();
            dataGridView1 = new DataGridView();
            OyuncuYastxt = new Label();
            OyuncuYas = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // OyuncuGuncelle
            // 
            OyuncuGuncelle.BackColor = SystemColors.ActiveCaption;
            OyuncuGuncelle.FlatStyle = FlatStyle.Flat;
            OyuncuGuncelle.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OyuncuGuncelle.Image = (Image)resources.GetObject("OyuncuGuncelle.Image");
            OyuncuGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            OyuncuGuncelle.Location = new Point(815, 79);
            OyuncuGuncelle.Margin = new Padding(4, 3, 4, 3);
            OyuncuGuncelle.Name = "OyuncuGuncelle";
            OyuncuGuncelle.Size = new Size(227, 71);
            OyuncuGuncelle.TabIndex = 17;
            OyuncuGuncelle.Text = "Güncelle";
            OyuncuGuncelle.UseVisualStyleBackColor = false;
            OyuncuGuncelle.Click += OyuncuGuncelle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(328, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 22);
            label4.TabIndex = 16;
            label4.Text = "Oyuncunun Takımı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(328, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(171, 22);
            label3.TabIndex = 15;
            label3.Text = "Oyuncunun Değeri :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(328, 36);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 22);
            label2.TabIndex = 14;
            label2.Text = "Oyuncunun Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(328, 5);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 22);
            label1.TabIndex = 13;
            label1.Text = "Oyuncunun Adı :";
            // 
            // OyuncuTakımtxt
            // 
            OyuncuTakımtxt.Location = new Point(530, 94);
            OyuncuTakımtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuTakımtxt.Name = "OyuncuTakımtxt";
            OyuncuTakımtxt.Size = new Size(140, 27);
            OyuncuTakımtxt.TabIndex = 12;
            // 
            // OyuncuDegertxt
            // 
            OyuncuDegertxt.Location = new Point(530, 63);
            OyuncuDegertxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuDegertxt.Name = "OyuncuDegertxt";
            OyuncuDegertxt.Size = new Size(140, 27);
            OyuncuDegertxt.TabIndex = 11;
            // 
            // OyuncuSoyadtxt
            // 
            OyuncuSoyadtxt.Location = new Point(530, 31);
            OyuncuSoyadtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuSoyadtxt.Name = "OyuncuSoyadtxt";
            OyuncuSoyadtxt.Size = new Size(140, 27);
            OyuncuSoyadtxt.TabIndex = 10;
            // 
            // OyuncuAdtxt
            // 
            OyuncuAdtxt.Location = new Point(530, 0);
            OyuncuAdtxt.Margin = new Padding(4, 3, 4, 3);
            OyuncuAdtxt.Name = "OyuncuAdtxt";
            OyuncuAdtxt.Size = new Size(140, 27);
            OyuncuAdtxt.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 253);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(862, 277);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OyuncuYastxt
            // 
            OyuncuYastxt.AutoSize = true;
            OyuncuYastxt.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OyuncuYastxt.Location = new Point(328, 130);
            OyuncuYastxt.Margin = new Padding(4, 0, 4, 0);
            OyuncuYastxt.Name = "OyuncuYastxt";
            OyuncuYastxt.Size = new Size(152, 22);
            OyuncuYastxt.TabIndex = 19;
            OyuncuYastxt.Text = "Oyuncunun Yaşı :";
            // 
            // OyuncuYas
            // 
            OyuncuYas.Location = new Point(530, 125);
            OyuncuYas.Margin = new Padding(4, 3, 4, 3);
            OyuncuYas.Name = "OyuncuYas";
            OyuncuYas.Size = new Size(140, 27);
            OyuncuYas.TabIndex = 20;
            // 
            // OyuncuGüncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1193, 532);
            Controls.Add(OyuncuYas);
            Controls.Add(OyuncuYastxt);
            Controls.Add(dataGridView1);
            Controls.Add(OyuncuGuncelle);
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
            Name = "OyuncuGüncelle";
            Text = "Oyuncu Güncelle";
            Load += OyuncuGüncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OyuncuGuncelle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox OyuncuTakımtxt;
        private TextBox OyuncuDegertxt;
        private TextBox OyuncuSoyadtxt;
        private TextBox OyuncuAdtxt;
        private DataGridView dataGridView1;
        private Label OyuncuYastxt;
        private TextBox OyuncuYas;
    }
}