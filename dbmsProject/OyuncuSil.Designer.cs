namespace dbmsProject
{
    partial class OyuncuSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuSil));
            dataGridView1 = new DataGridView();
            OyuncuSilbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 83);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 425);
            dataGridView1.TabIndex = 0;
            // 
            // OyuncuSilbtn
            // 
            OyuncuSilbtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            OyuncuSilbtn.Image = (Image)resources.GetObject("OyuncuSilbtn.Image");
            OyuncuSilbtn.ImageAlign = ContentAlignment.MiddleLeft;
            OyuncuSilbtn.Location = new Point(356, 1);
            OyuncuSilbtn.Margin = new Padding(4, 3, 4, 3);
            OyuncuSilbtn.Name = "OyuncuSilbtn";
            OyuncuSilbtn.Size = new Size(256, 76);
            OyuncuSilbtn.TabIndex = 1;
            OyuncuSilbtn.Text = "Oyuncuyu Sil";
            OyuncuSilbtn.UseVisualStyleBackColor = true;
            OyuncuSilbtn.Click += OyuncuSilbtn_Click;
            // 
            // OyuncuSil
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1195, 580);
            Controls.Add(OyuncuSilbtn);
            Controls.Add(dataGridView1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "OyuncuSil";
            Text = "Oyuncu Kaldır";
            Load += OyuncuSil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button OyuncuSilbtn;
    }
}