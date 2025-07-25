namespace CourseWork
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
        private void InitializeComponent() {
            label1 = new Label();
            createQuizBtn = new Button();
            playGameBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 79);
            label1.Name = "label1";
            label1.Size = new Size(248, 71);
            label1.TabIndex = 0;
            label1.Text = "Quiz Game";
            // 
            // createQuizBtn
            // 
            createQuizBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createQuizBtn.Location = new Point(235, 210);
            createQuizBtn.Name = "createQuizBtn";
            createQuizBtn.Size = new Size(177, 59);
            createQuizBtn.TabIndex = 1;
            createQuizBtn.Text = "Create Quiz";
            createQuizBtn.UseVisualStyleBackColor = true;
            createQuizBtn.Click += createQuizBtn_Click;
            // 
            // playGameBtn
            // 
            playGameBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            playGameBtn.Location = new Point(504, 210);
            playGameBtn.Name = "playGameBtn";
            playGameBtn.Size = new Size(175, 59);
            playGameBtn.TabIndex = 2;
            playGameBtn.Text = "Play Game";
            playGameBtn.UseVisualStyleBackColor = true;
            playGameBtn.Click += playGameBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(956, 525);
            Controls.Add(playGameBtn);
            Controls.Add(createQuizBtn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Quiz Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button createQuizBtn;
        private Button playGameBtn;
    }
}
