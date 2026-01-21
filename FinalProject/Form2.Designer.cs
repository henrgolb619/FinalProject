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
            secretWordLabel = new Label();
            letterTextBox = new TextBox();
            label2 = new Label();
            inputButton = new Button();
            resetButton = new Button();
            loseLabel = new Label();
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
            // secretWordLabel
            // 
            secretWordLabel.Font = new Font("Yu Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            secretWordLabel.Location = new Point(131, 88);
            secretWordLabel.Name = "secretWordLabel";
            secretWordLabel.Size = new Size(539, 86);
            secretWordLabel.TabIndex = 1;
            secretWordLabel.TextAlign = ContentAlignment.MiddleCenter;
            secretWordLabel.Click += secretWordLabel_Click;
            // 
            // letterTextBox
            // 
            letterTextBox.Location = new Point(383, 323);
            letterTextBox.Name = "letterTextBox";
            letterTextBox.Size = new Size(35, 23);
            letterTextBox.TabIndex = 2;
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
            // inputButton
            // 
            inputButton.Location = new Point(331, 360);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(139, 31);
            inputButton.TabIndex = 4;
            inputButton.Text = "Input Letter";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Yu Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(284, 291);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(233, 100);
            resetButton.TabIndex = 5;
            resetButton.Text = "Try Again";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Visible = false;
            resetButton.Click += resetButton_Click;
            // 
            // loseLabel
            // 
            loseLabel.Font = new Font("Yu Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loseLabel.Location = new Point(291, 85);
            loseLabel.Name = "loseLabel";
            loseLabel.Size = new Size(218, 85);
            loseLabel.TabIndex = 6;
            loseLabel.TextAlign = ContentAlignment.MiddleCenter;
            loseLabel.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loseLabel);
            Controls.Add(resetButton);
            Controls.Add(inputButton);
            Controls.Add(label2);
            Controls.Add(letterTextBox);
            Controls.Add(secretWordLabel);
            Controls.Add(attemptLabel);
            Name = "Form2";
            Text = "Hangman";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label attemptLabel;
        private Label secretWordLabel;
        private TextBox letterTextBox;
        private Label label2;
        private Button inputButton;
        private Button resetButton;
        private Label loseLabel;
    }
}