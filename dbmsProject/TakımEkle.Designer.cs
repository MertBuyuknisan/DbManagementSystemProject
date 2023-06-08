namespace dbmsProject
{
    partial class TakımEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakımEkle));
            takımkayıt = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            takımstadıtxt = new TextBox();
            Transferbütcetxt = new TextBox();
            Takımülketxt = new TextBox();
            Takımadtxt = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // takımkayıt
            // 
            takımkayıt.BackColor = SystemColors.ActiveCaption;
            takımkayıt.FlatStyle = FlatStyle.Flat;
            takımkayıt.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            takımkayıt.Image = (Image)resources.GetObject("takımkayıt.Image");
            takımkayıt.ImageAlign = ContentAlignment.MiddleLeft;
            takımkayıt.Location = new Point(455, 284);
            takımkayıt.Margin = new Padding(4, 3, 4, 3);
            takımkayıt.Name = "takımkayıt";
            takımkayıt.Size = new Size(227, 71);
            takımkayıt.TabIndex = 24;
            takımkayıt.Text = "   Takım Ekle";
            takımkayıt.UseVisualStyleBackColor = false;
            takımkayıt.Click += takımkayıt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(310, 209);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 23;
            label4.Text = "Takımın Stadı :\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(310, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 22);
            label3.TabIndex = 22;
            label3.Text = "Transfer Bütçesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(310, 78);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 22);
            label2.TabIndex = 21;
            label2.Text = "Ülke :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(310, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 22);
            label1.TabIndex = 20;
            label1.Text = "Takım Adı :";
            // 
            // takımstadıtxt
            // 
            takımstadıtxt.Location = new Point(508, 209);
            takımstadıtxt.Margin = new Padding(4, 3, 4, 3);
            takımstadıtxt.Name = "takımstadıtxt";
            takımstadıtxt.Size = new Size(140, 27);
            takımstadıtxt.TabIndex = 19;
            // 
            // Transferbütcetxt
            // 
            Transferbütcetxt.Location = new Point(508, 142);
            Transferbütcetxt.Margin = new Padding(4, 3, 4, 3);
            Transferbütcetxt.Name = "Transferbütcetxt";
            Transferbütcetxt.Size = new Size(140, 27);
            Transferbütcetxt.TabIndex = 18;
            // 
            // Takımülketxt
            // 
            Takımülketxt.Location = new Point(508, 78);
            Takımülketxt.Margin = new Padding(4, 3, 4, 3);
            Takımülketxt.Name = "Takımülketxt";
            Takımülketxt.Size = new Size(140, 27);
            Takımülketxt.TabIndex = 17;
            // 
            // Takımadtxt
            // 
            Takımadtxt.Location = new Point(508, 24);
            Takımadtxt.Margin = new Padding(4, 3, 4, 3);
            Takımadtxt.Name = "Takımadtxt";
            Takımadtxt.Size = new Size(140, 27);
            Takımadtxt.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(748, 24);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(860, 332);
            dataGridView1.TabIndex = 25;
            // 
            // TakımEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1612, 556);
            Controls.Add(dataGridView1);
            Controls.Add(takımkayıt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(takımstadıtxt);
            Controls.Add(Transferbütcetxt);
            Controls.Add(Takımülketxt);
            Controls.Add(Takımadtxt);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TakımEkle";
            Text = "Takım Ekle";
            Load += TakımEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button takımkayıt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox takımstadıtxt;
        private TextBox Transferbütcetxt;
        private TextBox Takımülketxt;
        private TextBox Takımadtxt;
        private DataGridView dataGridView1;
    }
}