namespace dbmsProject
{
    partial class TakımGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakımGüncelle));
            dataGridView1 = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Takımstadgüncelletxt = new TextBox();
            Takımbütcegüncelletxt = new TextBox();
            Takımülkegüncelletxt = new TextBox();
            TakımAdgüncelletxt = new TextBox();
            TakımGüncellebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 288);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1161, 234);
            dataGridView1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(322, 210);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 28;
            label4.Text = "Takımın Stadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(322, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 22);
            label3.TabIndex = 27;
            label3.Text = "Takımın Bütçesi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(322, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 22);
            label2.TabIndex = 26;
            label2.Text = "Bulunduğu Ülke :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(322, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 25;
            label1.Text = "Takım Adı :";
            // 
            // Takımstadgüncelletxt
            // 
            Takımstadgüncelletxt.Location = new Point(524, 206);
            Takımstadgüncelletxt.Margin = new Padding(4, 3, 4, 3);
            Takımstadgüncelletxt.Name = "Takımstadgüncelletxt";
            Takımstadgüncelletxt.Size = new Size(140, 27);
            Takımstadgüncelletxt.TabIndex = 24;
            // 
            // Takımbütcegüncelletxt
            // 
            Takımbütcegüncelletxt.Location = new Point(524, 174);
            Takımbütcegüncelletxt.Margin = new Padding(4, 3, 4, 3);
            Takımbütcegüncelletxt.Name = "Takımbütcegüncelletxt";
            Takımbütcegüncelletxt.Size = new Size(140, 27);
            Takımbütcegüncelletxt.TabIndex = 23;
            // 
            // Takımülkegüncelletxt
            // 
            Takımülkegüncelletxt.Location = new Point(524, 142);
            Takımülkegüncelletxt.Margin = new Padding(4, 3, 4, 3);
            Takımülkegüncelletxt.Name = "Takımülkegüncelletxt";
            Takımülkegüncelletxt.Size = new Size(140, 27);
            Takımülkegüncelletxt.TabIndex = 22;
            // 
            // TakımAdgüncelletxt
            // 
            TakımAdgüncelletxt.Location = new Point(524, 111);
            TakımAdgüncelletxt.Margin = new Padding(4, 3, 4, 3);
            TakımAdgüncelletxt.Name = "TakımAdgüncelletxt";
            TakımAdgüncelletxt.Size = new Size(140, 27);
            TakımAdgüncelletxt.TabIndex = 21;
            // 
            // TakımGüncellebtn
            // 
            TakımGüncellebtn.BackColor = SystemColors.ActiveCaption;
            TakımGüncellebtn.FlatStyle = FlatStyle.Flat;
            TakımGüncellebtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TakımGüncellebtn.Image = (Image)resources.GetObject("TakımGüncellebtn.Image");
            TakımGüncellebtn.ImageAlign = ContentAlignment.MiddleLeft;
            TakımGüncellebtn.Location = new Point(757, 160);
            TakımGüncellebtn.Margin = new Padding(4, 3, 4, 3);
            TakımGüncellebtn.Name = "TakımGüncellebtn";
            TakımGüncellebtn.Size = new Size(227, 71);
            TakımGüncellebtn.TabIndex = 29;
            TakımGüncellebtn.Text = "Güncelle";
            TakımGüncellebtn.UseVisualStyleBackColor = false;
            TakımGüncellebtn.Click += TakımGüncellebtn_Click;
            // 
            // TakımGüncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1188, 534);
            Controls.Add(TakımGüncellebtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Takımstadgüncelletxt);
            Controls.Add(Takımbütcegüncelletxt);
            Controls.Add(Takımülkegüncelletxt);
            Controls.Add(TakımAdgüncelletxt);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TakımGüncelle";
            Text = "Takım Güncelle";
            Load += TakımGüncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Takımstadgüncelletxt;
        private TextBox Takımbütcegüncelletxt;
        private TextBox Takımülkegüncelletxt;
        private TextBox TakımAdgüncelletxt;
        private Button TakımGüncellebtn;
    }
}