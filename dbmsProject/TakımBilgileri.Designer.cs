namespace dbmsProject
{
    partial class TakımBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakımBilgileri));
            OyuncularıGöster = new Button();
            takımgolsıralamabtn = new Button();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // OyuncularıGöster
            // 
            OyuncularıGöster.BackColor = SystemColors.ActiveCaption;
            OyuncularıGöster.FlatStyle = FlatStyle.Popup;
            OyuncularıGöster.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OyuncularıGöster.Image = (Image)resources.GetObject("OyuncularıGöster.Image");
            OyuncularıGöster.ImageAlign = ContentAlignment.MiddleLeft;
            OyuncularıGöster.Location = new Point(14, 145);
            OyuncularıGöster.Margin = new Padding(4, 3, 4, 3);
            OyuncularıGöster.Name = "OyuncularıGöster";
            OyuncularıGöster.Size = new Size(256, 76);
            OyuncularıGöster.TabIndex = 1;
            OyuncularıGöster.Text = "      Oyuncuları Göster";
            OyuncularıGöster.UseVisualStyleBackColor = false;
            OyuncularıGöster.Click += OyuncularıGöster_Click;
            // 
            // takımgolsıralamabtn
            // 
            takımgolsıralamabtn.BackColor = SystemColors.ActiveCaption;
            takımgolsıralamabtn.FlatStyle = FlatStyle.Popup;
            takımgolsıralamabtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            takımgolsıralamabtn.Image = (Image)resources.GetObject("takımgolsıralamabtn.Image");
            takımgolsıralamabtn.ImageAlign = ContentAlignment.MiddleLeft;
            takımgolsıralamabtn.Location = new Point(14, 244);
            takımgolsıralamabtn.Margin = new Padding(4, 3, 4, 3);
            takımgolsıralamabtn.Name = "takımgolsıralamabtn";
            takımgolsıralamabtn.Size = new Size(256, 76);
            takımgolsıralamabtn.TabIndex = 2;
            takımgolsıralamabtn.Text = "        Takımların Gol Sıralaması";
            takımgolsıralamabtn.UseVisualStyleBackColor = false;
            takımgolsıralamabtn.Click += takımgolsıralamabtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(277, 85);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1111, 434);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 343);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(256, 76);
            button1.TabIndex = 5;
            button1.Text = "      Taraftar Sayısı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TakımBilgileri
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1440, 530);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(takımgolsıralamabtn);
            Controls.Add(OyuncularıGöster);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TakımBilgileri";
            Text = "Takım Bilgileri";
            Load += TakımBilgileri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button OyuncularıGöster;
        private Button takımgolsıralamabtn;
        private DataGridView dataGridView1;
        private Button button1;
    }
}