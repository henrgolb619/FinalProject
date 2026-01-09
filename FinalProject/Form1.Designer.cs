namespace FinalProject
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
            playButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.Font = new Font("SimSun", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            playButton.Location = new Point(272, 289);
            playButton.Name = "playButton";
            playButton.Size = new Size(257, 105);
            playButton.TabIndex = 3;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // label1
            // 
            label1.Font = new Font("SimSun", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 57);
            label1.Name = "label1";
            label1.Size = new Size(394, 125);
            label1.TabIndex = 2;
            label1.Text = "Hangman";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(playButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Title Screen";
            ResumeLayout(false);
        }

        #endregion

        private Button playButton;
        private Label label1;
    }
}
