namespace dbmsProject
{
    partial class TaraftarEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaraftarEkle));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            taraftaradtxt = new TextBox();
            taraftarsoyadtxt = new TextBox();
            taraftaryastxt = new TextBox();
            taraftartakımtxt = new TextBox();
            taraftartlftxt = new TextBox();
            taraftarkayıt = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 60);
            label1.Name = "label1";
            label1.Size = new Size(117, 19);
            label1.TabIndex = 0;
            label1.Text = "Taraftarın Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 101);
            label2.Name = "label2";
            label2.Size = new Size(145, 19);
            label2.TabIndex = 1;
            label2.Text = "Taraftarın Soyadı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 146);
            label3.Name = "label3";
            label3.Size = new Size(125, 19);
            label3.TabIndex = 2;
            label3.Text = "Taraftarın Yaşı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 193);
            label4.Name = "label4";
            label4.Size = new Size(140, 19);
            label4.TabIndex = 3;
            label4.Text = "Taraftarın Takımı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 242);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 4;
            label5.Text = "Taraftarın Telefon :";
            // 
            // taraftaradtxt
            // 
            taraftaradtxt.Location = new Point(280, 57);
            taraftaradtxt.Name = "taraftaradtxt";
            taraftaradtxt.Size = new Size(113, 27);
            taraftaradtxt.TabIndex = 6;
            // 
            // taraftarsoyadtxt
            // 
            taraftarsoyadtxt.Location = new Point(280, 98);
            taraftarsoyadtxt.Name = "taraftarsoyadtxt";
            taraftarsoyadtxt.Size = new Size(113, 27);
            taraftarsoyadtxt.TabIndex = 7;
            // 
            // taraftaryastxt
            // 
            taraftaryastxt.Location = new Point(280, 143);
            taraftaryastxt.Name = "taraftaryastxt";
            taraftaryastxt.Size = new Size(113, 27);
            taraftaryastxt.TabIndex = 8;
            // 
            // taraftartakımtxt
            // 
            taraftartakımtxt.Location = new Point(280, 191);
            taraftartakımtxt.Name = "taraftartakımtxt";
            taraftartakımtxt.Size = new Size(113, 27);
            taraftartakımtxt.TabIndex = 9;
            // 
            // taraftartlftxt
            // 
            taraftartlftxt.Location = new Point(280, 239);
            taraftartlftxt.Name = "taraftartlftxt";
            taraftartlftxt.Size = new Size(113, 27);
            taraftartlftxt.TabIndex = 10;
            // 
            // taraftarkayıt
            // 
            taraftarkayıt.BackColor = SystemColors.ActiveCaption;
            taraftarkayıt.FlatStyle = FlatStyle.Flat;
            taraftarkayıt.Font = new Font("Arial Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            taraftarkayıt.Image = (Image)resources.GetObject("taraftarkayıt.Image");
            taraftarkayıt.ImageAlign = ContentAlignment.MiddleLeft;
            taraftarkayıt.Location = new Point(166, 342);
            taraftarkayıt.Margin = new Padding(4, 3, 4, 3);
            taraftarkayıt.Name = "taraftarkayıt";
            taraftarkayıt.Size = new Size(227, 71);
            taraftarkayıt.TabIndex = 12;
            taraftarkayıt.Text = "Kaydet";
            taraftarkayıt.UseVisualStyleBackColor = false;
            taraftarkayıt.Click += taraftarkayıt_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(399, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(717, 356);
            dataGridView1.TabIndex = 13;
            // 
            // TaraftarEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1126, 531);
            Controls.Add(dataGridView1);
            Controls.Add(taraftarkayıt);
            Controls.Add(taraftartlftxt);
            Controls.Add(taraftartakımtxt);
            Controls.Add(taraftaryastxt);
            Controls.Add(taraftarsoyadtxt);
            Controls.Add(taraftaradtxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "TaraftarEkle";
            Text = "Taraftar Ekle";
            Load += TaraftarEkle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox taraftaradtxt;
        private TextBox taraftarsoyadtxt;
        private TextBox taraftaryastxt;
        private TextBox taraftartakımtxt;
        private TextBox taraftartlftxt;
        private Button taraftarkayıt;
        private DataGridView dataGridView1;
    }
}