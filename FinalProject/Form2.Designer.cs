namespace FinalProject
{
    partial class Form2
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
            attemptLabel = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // attemptLabel
            // 
            attemptLabel.Location = new Point(320, 174);
            attemptLabel.Name = "attemptLabel";
            attemptLabel.Size = new Size(161, 32);
            attemptLabel.TabIndex = 0;
            attemptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(176, 88);
            label1.Name = "label1";
            label1.Size = new Size(449, 86);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(383, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(35, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(274, 270);
            label2.Name = "label2";
            label2.Size = new Size(252, 50);
            label2.TabIndex = 3;
            label2.Text = "Enter a letter.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(attemptLabel);
            Name = "Form2";
            Text = "Hangman";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label attemptLabel;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}