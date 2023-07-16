namespace FoerachOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(326, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 21);
            button1.TabIndex = 0;
            button1.Text = "Tıkla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(37, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 214);
            listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 14;
            listBox2.Location = new Point(436, 95);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(249, 214);
            listBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 78);
            label1.Name = "label1";
            label1.Size = new Size(126, 14);
            label1.TabIndex = 3;
            label1.Text = "4'E TAM BÖLÜNENLER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 78);
            label2.Name = "label2";
            label2.Size = new Size(151, 14);
            label2.TabIndex = 4;
            label2.Text = "4'E TAM BÖLÜNMEYENLER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 330);
            label3.Name = "label3";
            label3.Size = new Size(117, 14);
            label3.TabIndex = 5;
            label3.Text = "4'e Bölünebilen sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 330);
            label4.Name = "label4";
            label4.Size = new Size(126, 14);
            label4.TabIndex = 6;
            label4.Text = "4'e Bölünemeyen sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 362);
            label5.Name = "label5";
            label5.Size = new Size(181, 14);
            label5.TabIndex = 7;
            label5.Text = "4'e Bölünebilen sayıların toplamı: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 362);
            label6.Name = "label6";
            label6.Size = new Size(190, 14);
            label6.TabIndex = 8;
            label6.Text = "4'e Bölünemeyen sayıların toplamı: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 420);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Font = new Font("Corbel", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}