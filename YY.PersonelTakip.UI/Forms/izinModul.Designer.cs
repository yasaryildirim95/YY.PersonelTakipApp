namespace YY.PersonelTakip.UI.Forms
{
    partial class izinModul
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
            button5 = new Button();
            textBox6 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(363, 36);
            button5.Name = "button5";
            button5.Size = new Size(57, 27);
            button5.TabIndex = 24;
            button5.Text = "Getir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 36);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(345, 27);
            textBox6.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 13);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 22;
            label7.Text = "Personel TC No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 106);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 25;
            label1.Text = "Kalan İzin Hakkı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 143);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 26;
            label2.Text = "İzin Başlangıç";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 175);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 27);
            dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 268);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(408, 27);
            dateTimePicker2.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 236);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 28;
            label3.Text = "İzin Bitiş";
            // 
            // button1
            // 
            button1.Location = new Point(12, 325);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 379);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(408, 224);
            listBox1.TabIndex = 31;
            // 
            // button2
            // 
            button2.Location = new Point(326, 325);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 32;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(160, 325);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 33;
            button3.Text = "Düzenle";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 34;
            label4.Text = "Ad Soyad:";
            // 
            // izinModul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 626);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Name = "izinModul";
            Text = "izinModul";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox6;
        private Label label7;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Button button3;
        private Label label4;
    }
}