namespace CourseWork {
    partial class PlayQuiz {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayQuiz));
            questionTimer_Tick = new System.Windows.Forms.Timer(components);
            panelMultiAnswer = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelTFAnswer = new Panel();
            submitTFbtn = new Button();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panelOpAnswer = new Panel();
            submitOPBtn = new Button();
            textBoxAnswer = new TextBox();
            labelQuestionText = new Label();
            labelClock = new Label();
            panelMultiAnswer.SuspendLayout();
            panelTFAnswer.SuspendLayout();
            panelOpAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // questionTimer_Tick
            // 
            questionTimer_Tick.Tick += questionTimer_Tick_Tick;
            // 
            // panelMultiAnswer
            // 
            panelMultiAnswer.Controls.Add(button4);
            panelMultiAnswer.Controls.Add(button3);
            panelMultiAnswer.Controls.Add(button2);
            panelMultiAnswer.Controls.Add(button1);
            panelMultiAnswer.Location = new Point(89, 108);
            panelMultiAnswer.Name = "panelMultiAnswer";
            panelMultiAnswer.Size = new Size(431, 252);
            panelMultiAnswer.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(17, 187);
            button4.Name = "button4";
            button4.Size = new Size(390, 48);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += checkAnswerEvent;
            // 
            // button3
            // 
            button3.Location = new Point(14, 130);
            button3.Name = "button3";
            button3.Size = new Size(393, 51);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += checkAnswerEvent;
            // 
            // button2
            // 
            button2.Location = new Point(11, 70);
            button2.Name = "button2";
            button2.Size = new Size(396, 54);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += checkAnswerEvent;
            // 
            // button1
            // 
            button1.Location = new Point(11, 13);
            button1.Name = "button1";
            button1.Size = new Size(396, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += checkAnswerEvent;
            // 
            // panelTFAnswer
            // 
            panelTFAnswer.Controls.Add(submitTFbtn);
            panelTFAnswer.Controls.Add(radioButton2);
            panelTFAnswer.Controls.Add(radioButton1);
            panelTFAnswer.Location = new Point(89, 295);
            panelTFAnswer.Name = "panelTFAnswer";
            panelTFAnswer.Size = new Size(428, 125);
            panelTFAnswer.TabIndex = 3;
            // 
            // submitTFbtn
            // 
            submitTFbtn.Location = new Point(13, 83);
            submitTFbtn.Name = "submitTFbtn";
            submitTFbtn.Size = new Size(245, 37);
            submitTFbtn.TabIndex = 2;
            submitTFbtn.Text = "Submit ";
            submitTFbtn.UseVisualStyleBackColor = true;
            submitTFbtn.Click += submitTFbtn_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(11, 50);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 27);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "False";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.Location = new Point(11, 17);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 27);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "True";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // panelOpAnswer
            // 
            panelOpAnswer.Controls.Add(submitOPBtn);
            panelOpAnswer.Controls.Add(textBoxAnswer);
            panelOpAnswer.Location = new Point(65, 81);
            panelOpAnswer.Name = "panelOpAnswer";
            panelOpAnswer.Size = new Size(431, 125);
            panelOpAnswer.TabIndex = 4;
            // 
            // submitOPBtn
            // 
            submitOPBtn.Location = new Point(6, 69);
            submitOPBtn.Name = "submitOPBtn";
            submitOPBtn.Size = new Size(244, 43);
            submitOPBtn.TabIndex = 1;
            submitOPBtn.Text = "Submit";
            submitOPBtn.UseVisualStyleBackColor = true;
            submitOPBtn.Click += submitOPBtn_Click;
            // 
            // textBoxAnswer
            // 
            textBoxAnswer.Location = new Point(6, 9);
            textBoxAnswer.Name = "textBoxAnswer";
            textBoxAnswer.Size = new Size(422, 27);
            textBoxAnswer.TabIndex = 0;
            // 
            // labelQuestionText
            // 
            labelQuestionText.AllowDrop = true;
            labelQuestionText.AutoSize = true;
            labelQuestionText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelQuestionText.Location = new Point(89, 33);
            labelQuestionText.Name = "labelQuestionText";
            labelQuestionText.Size = new Size(151, 25);
            labelQuestionText.TabIndex = 5;
            labelQuestionText.Text = "Question Here";
            // 
            // labelClock
            // 
            labelClock.AutoSize = true;
            labelClock.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelClock.Location = new Point(625, 23);
            labelClock.Name = "labelClock";
            labelClock.Size = new Size(89, 38);
            labelClock.TabIndex = 6;
            labelClock.Text = "00:00";
            // 
            // PlayQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(740, 455);
            Controls.Add(labelClock);
            Controls.Add(labelQuestionText);
            Controls.Add(panelOpAnswer);
            Controls.Add(panelTFAnswer);
            Controls.Add(panelMultiAnswer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PlayQuiz";
            Text = "PlayQuiz";
            panelMultiAnswer.ResumeLayout(false);
            panelTFAnswer.ResumeLayout(false);
            panelTFAnswer.PerformLayout();
            panelOpAnswer.ResumeLayout(false);
            panelOpAnswer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer questionTimer_Tick;
        private Panel panelMultiAnswer;
        private Button button2;
        private Button button1;
        private Panel panelTFAnswer;
        private Panel panelOpAnswer;
        private Button button4;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxAnswer;
        private Button submitTFbtn;
        private Button submitOPBtn;
        private Label labelQuestionText;
        private Label labelClock;
    }
}