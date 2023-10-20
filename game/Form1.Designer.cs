namespace game
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            exitButton = new Button();
            restartButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(0, 45);
            button1.Margin = new Padding(3, 0, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(170, 170);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(170, 45);
            button2.Margin = new Padding(3, 0, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(170, 170);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(340, 45);
            button3.Margin = new Padding(3, 0, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(170, 170);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(0, 215);
            button4.Name = "button4";
            button4.Size = new Size(170, 170);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(170, 215);
            button5.Name = "button5";
            button5.Size = new Size(170, 170);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(340, 215);
            button6.Name = "button6";
            button6.Size = new Size(170, 170);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(0, 385);
            button7.Name = "button7";
            button7.Size = new Size(170, 170);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(170, 385);
            button8.Name = "button8";
            button8.Size = new Size(170, 170);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(340, 385);
            button9.Name = "button9";
            button9.Size = new Size(170, 170);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.Control;
            exitButton.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            exitButton.ForeColor = Color.Black;
            exitButton.Location = new Point(0, 555);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(255, 85);
            exitButton.TabIndex = 9;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // restartButton
            // 
            restartButton.BackColor = SystemColors.Control;
            restartButton.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            restartButton.ForeColor = Color.Black;
            restartButton.Location = new Point(255, 555);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(255, 85);
            restartButton.TabIndex = 10;
            restartButton.Text = "Restart";
            restartButton.UseVisualStyleBackColor = false;
            restartButton.Click += restartButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 45);
            textBox1.TabIndex = 11;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 640);
            Controls.Add(textBox1);
            Controls.Add(restartButton);
            Controls.Add(exitButton);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button exitButton;
        private Button restartButton;
        private TextBox textBox1;
    }
}