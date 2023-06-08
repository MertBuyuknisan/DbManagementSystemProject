namespace dbmsProject
{
    partial class TaraftarSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaraftarSil));
            TaraftarSilbtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TaraftarSilbtn
            // 
            TaraftarSilbtn.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TaraftarSilbtn.Image = (Image)resources.GetObject("TaraftarSilbtn.Image");
            TaraftarSilbtn.ImageAlign = ContentAlignment.MiddleLeft;
            TaraftarSilbtn.Location = new Point(325, 68);
            TaraftarSilbtn.Margin = new Padding(4, 3, 4, 3);
            TaraftarSilbtn.Name = "TaraftarSilbtn";
            TaraftarSilbtn.Size = new Size(256, 76);
            TaraftarSilbtn.TabIndex = 2;
            TaraftarSilbtn.Text = "Taraftarı Sil";
            TaraftarSilbtn.UseVisualStyleBackColor = true;
            TaraftarSilbtn.Click += TaraftarSilbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(848, 332);
            dataGridView1.TabIndex = 3;
            // 
            // TaraftarSil
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1094, 530);
            Controls.Add(dataGridView1);
            Controls.Add(TaraftarSilbtn);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TaraftarSil";
            Text = "Taraftar Sil";
            Load += TaraftarSil_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button TaraftarSilbtn;
        private DataGridView dataGridView1;
    }
}