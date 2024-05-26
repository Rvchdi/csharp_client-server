namespace C_S
{
    partial class AddProductForm
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            CodeTXT = new TextBox();
            label3 = new Label();
            QuantityTXT = new TextBox();
            label2 = new Label();
            TypeTXT = new TextBox();
            label1 = new Label();
            NameTXT = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(CodeTXT);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(QuantityTXT);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TypeTXT);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(NameTXT);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1187, 788);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 395);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1048, 351);
            dataGridView1.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(873, 319);
            button4.Name = "button4";
            button4.Size = new Size(150, 46);
            button4.TabIndex = 11;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(676, 319);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 319);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 9;
            button2.Text = "Clear fields";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(270, 319);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 8;
            button1.Text = "Add product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 113);
            label4.Name = "label4";
            label4.Size = new Size(164, 32);
            label4.TabIndex = 7;
            label4.Text = "Product CODE";
            // 
            // CodeTXT
            // 
            CodeTXT.Location = new Point(831, 110);
            CodeTXT.Name = "CodeTXT";
            CodeTXT.Size = new Size(304, 39);
            CodeTXT.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(696, 214);
            label3.Name = "label3";
            label3.Size = new Size(106, 32);
            label3.TabIndex = 5;
            label3.Text = "Quantity";
            // 
            // QuantityTXT
            // 
            QuantityTXT.Location = new Point(831, 207);
            QuantityTXT.Name = "QuantityTXT";
            QuantityTXT.Size = new Size(304, 39);
            QuantityTXT.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 210);
            label2.Name = "label2";
            label2.Size = new Size(154, 32);
            label2.TabIndex = 3;
            label2.Text = "Product Type";
            // 
            // TypeTXT
            // 
            TypeTXT.Location = new Point(203, 207);
            TypeTXT.Name = "TypeTXT";
            TypeTXT.Size = new Size(304, 39);
            TypeTXT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 110);
            label1.Name = "label1";
            label1.Size = new Size(167, 32);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // NameTXT
            // 
            NameTXT.Location = new Point(203, 107);
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(304, 39);
            NameTXT.TabIndex = 0;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 788);
            Controls.Add(panel1);
            Name = "AddProductForm";
            Text = "Add Product";
            Load += AddProductForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label4;
        private TextBox CodeTXT;
        private Label label3;
        private TextBox QuantityTXT;
        private Label label2;
        private TextBox TypeTXT;
        private Label label1;
        private TextBox NameTXT;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView1;
    }
}