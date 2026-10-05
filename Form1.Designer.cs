namespace clock
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 27);
            textBox1.TabIndex = 0;
            textBox1.Click += textBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 35);
            label1.Name = "label1";
            label1.Size = new Size(12, 19);
            label1.TabIndex = 1;
            label1.Text = ":";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 32);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(41, 27);
            textBox2.TabIndex = 2;
            textBox2.Click += textBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 35);
            label2.Name = "label2";
            label2.Size = new Size(12, 19);
            label2.TabIndex = 3;
            label2.Text = ":";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(128, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(41, 27);
            textBox3.TabIndex = 4;
            textBox3.Click += textBox3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            KeyDown += Form1_KeyDown;
            MouseClick += Form1_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
    }
}
