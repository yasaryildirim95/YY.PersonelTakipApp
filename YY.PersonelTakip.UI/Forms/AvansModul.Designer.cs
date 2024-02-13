namespace YY.PersonelTakip.UI.Forms
{
    partial class AvansModul
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
            button3 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(175, 73);
            button3.Name = "button3";
            button3.Size = new Size(82, 27);
            button3.TabIndex = 10;
            button3.Text = "Getir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 8;
            label1.Text = "Personel TC No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 119);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 11;
            label2.Text = "Avans Miktarı";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 13;
            label3.Text = "Avans Vadesi";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(12, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 28);
            comboBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(69, 270);
            button1.Name = "button1";
            button1.Size = new Size(131, 58);
            button1.TabIndex = 15;
            button1.Text = "Avans Ver";
            button1.UseVisualStyleBackColor = true;
            // 
            // AvansModul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AvansModul";
            Text = "AvansModul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
    }
}