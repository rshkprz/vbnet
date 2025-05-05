namespace RegForm
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
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 441);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(41, 232);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Calculator";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 174);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(41, 114);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(181, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 76);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(156, 21);
            label1.Name = "label1";
            label1.Size = new Size(316, 30);
            label1.TabIndex = 0;
            label1.Text = "Simple Windows Application ";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(188, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(591, 346);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 67);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 83);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(334, 154);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "Stop Timer";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(167, 154);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "Start Timer";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Panel panel3;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
