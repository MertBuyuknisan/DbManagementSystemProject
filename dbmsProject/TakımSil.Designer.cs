namespace dbmsProject
{
    partial class TakımSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakımSil));
            TakımSilbtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TakımSilbtn
            // 
            TakımSilbtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TakımSilbtn.Image = (Image)resources.GetObject("TakımSilbtn.Image");
            TakımSilbtn.ImageAlign = ContentAlignment.MiddleLeft;
            TakımSilbtn.Location = new Point(379, 11);
            TakımSilbtn.Margin = new Padding(4, 3, 4, 3);
            TakımSilbtn.Name = "TakımSilbtn";
            TakımSilbtn.Size = new Size(256, 76);
            TakımSilbtn.TabIndex = 2;
            TakımSilbtn.Text = "Takım Sil";
            TakımSilbtn.UseVisualStyleBackColor = true;
            TakımSilbtn.Click += TakımSilbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1143, 425);
            dataGridView1.TabIndex = 3;
            // 
            // TakımSil
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1310, 532);
            Controls.Add(dataGridView1);
            Controls.Add(TakımSilbtn);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TakımSil";
            Text = "Takım Sil";
            Load += TakımSil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button TakımSilbtn;
        private DataGridView dataGridView1;
    }
}