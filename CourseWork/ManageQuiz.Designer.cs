namespace CourseWork {
    partial class ManageQuiz {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageQuiz));
            openEndedPanel = new Panel();
            textBoxOpenEnded = new TextBox();
            buttonCreate = new Button();
            listBoxQuestion = new ListBox();
            cbBoxQuesionType = new ComboBox();
            label2 = new Label();
            trueFalsePanel = new Panel();
            radioButtonFalse = new RadioButton();
            radioButtonTrue = new RadioButton();
            textBoxQuestion = new TextBox();
            multipleChoicePanel = new Panel();
            textBoxOption3 = new TextBox();
            textBoxOption2 = new TextBox();
            textBoxOption1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBoxCorrectAns = new TextBox();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            openEndedPanel.SuspendLayout();
            trueFalsePanel.SuspendLayout();
            multipleChoicePanel.SuspendLayout();
            SuspendLayout();
            // 
            // openEndedPanel
            // 
            openEndedPanel.Controls.Add(textBoxOpenEnded);
            openEndedPanel.Location = new Point(444, 247);
            openEndedPanel.Name = "openEndedPanel";
            openEndedPanel.Size = new Size(401, 103);
            openEndedPanel.TabIndex = 7;
            // 
            // textBoxOpenEnded
            // 
            textBoxOpenEnded.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxOpenEnded.Location = new Point(0, 3);
            textBoxOpenEnded.Multiline = true;
            textBoxOpenEnded.Name = "textBoxOpenEnded";
            textBoxOpenEnded.PlaceholderText = "Open-Ended Answer";
            textBoxOpenEnded.Size = new Size(341, 34);
            textBoxOpenEnded.TabIndex = 0;
            // 
            // buttonCreate
            // 
            buttonCreate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCreate.Location = new Point(87, 493);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(163, 51);
            buttonCreate.TabIndex = 10;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // listBoxQuestion
            // 
            listBoxQuestion.BorderStyle = BorderStyle.None;
            listBoxQuestion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxQuestion.FormattingEnabled = true;
            listBoxQuestion.Location = new Point(546, 135);
            listBoxQuestion.Name = "listBoxQuestion";
            listBoxQuestion.Size = new Size(378, 420);
            listBoxQuestion.TabIndex = 12;
            // 
            // cbBoxQuesionType
            // 
            cbBoxQuesionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBoxQuesionType.FormattingEnabled = true;
            cbBoxQuesionType.Location = new Point(87, 211);
            cbBoxQuesionType.Name = "cbBoxQuesionType";
            cbBoxQuesionType.Size = new Size(341, 28);
            cbBoxQuesionType.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(369, 24);
            label2.Name = "label2";
            label2.Size = new Size(269, 65);
            label2.TabIndex = 11;
            label2.Text = "Manage Quiz";
            // 
            // trueFalsePanel
            // 
            trueFalsePanel.Controls.Add(radioButtonFalse);
            trueFalsePanel.Controls.Add(radioButtonTrue);
            trueFalsePanel.Location = new Point(472, 369);
            trueFalsePanel.Name = "trueFalsePanel";
            trueFalsePanel.Size = new Size(352, 105);
            trueFalsePanel.TabIndex = 9;
            // 
            // radioButtonFalse
            // 
            radioButtonFalse.AutoSize = true;
            radioButtonFalse.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonFalse.Location = new Point(4, 44);
            radioButtonFalse.Name = "radioButtonFalse";
            radioButtonFalse.Size = new Size(71, 29);
            radioButtonFalse.TabIndex = 1;
            radioButtonFalse.TabStop = true;
            radioButtonFalse.Text = "False";
            radioButtonFalse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTrue
            // 
            radioButtonTrue.AutoSize = true;
            radioButtonTrue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButtonTrue.Location = new Point(3, 5);
            radioButtonTrue.Name = "radioButtonTrue";
            radioButtonTrue.Size = new Size(65, 29);
            radioButtonTrue.TabIndex = 0;
            radioButtonTrue.TabStop = true;
            radioButtonTrue.Text = "True";
            radioButtonTrue.UseVisualStyleBackColor = true;
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.BackColor = SystemColors.Window;
            textBoxQuestion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxQuestion.ForeColor = Color.Gray;
            textBoxQuestion.Location = new Point(87, 108);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.PlaceholderText = "Enter a question";
            textBoxQuestion.Size = new Size(341, 93);
            textBoxQuestion.TabIndex = 5;
            // 
            // multipleChoicePanel
            // 
            multipleChoicePanel.Controls.Add(textBoxOption3);
            multipleChoicePanel.Controls.Add(textBoxOption2);
            multipleChoicePanel.Controls.Add(textBoxOption1);
            multipleChoicePanel.Controls.Add(label4);
            multipleChoicePanel.Controls.Add(label3);
            multipleChoicePanel.Controls.Add(textBoxCorrectAns);
            multipleChoicePanel.Location = new Point(87, 245);
            multipleChoicePanel.Name = "multipleChoicePanel";
            multipleChoicePanel.Size = new Size(341, 242);
            multipleChoicePanel.TabIndex = 6;
            // 
            // textBoxOption3
            // 
            textBoxOption3.Location = new Point(20, 192);
            textBoxOption3.Name = "textBoxOption3";
            textBoxOption3.PlaceholderText = "Optional";
            textBoxOption3.Size = new Size(289, 27);
            textBoxOption3.TabIndex = 5;
            // 
            // textBoxOption2
            // 
            textBoxOption2.Location = new Point(21, 154);
            textBoxOption2.Name = "textBoxOption2";
            textBoxOption2.PlaceholderText = "Optional";
            textBoxOption2.Size = new Size(288, 27);
            textBoxOption2.TabIndex = 4;
            // 
            // textBoxOption1
            // 
            textBoxOption1.Location = new Point(21, 114);
            textBoxOption1.Name = "textBoxOption1";
            textBoxOption1.PlaceholderText = "Optional";
            textBoxOption1.Size = new Size(288, 27);
            textBoxOption1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 85);
            label4.Name = "label4";
            label4.Size = new Size(126, 20);
            label4.TabIndex = 2;
            label4.Text = "Optional Answer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 11);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 1;
            label3.Text = "Correct Answer";
            // 
            // textBoxCorrectAns
            // 
            textBoxCorrectAns.Location = new Point(21, 44);
            textBoxCorrectAns.Name = "textBoxCorrectAns";
            textBoxCorrectAns.PlaceholderText = "Required";
            textBoxCorrectAns.Size = new Size(288, 27);
            textBoxCorrectAns.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUpdate.Location = new Point(265, 494);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(163, 50);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.ForeColor = SystemColors.ButtonHighlight;
            buttonDelete.Location = new Point(87, 550);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(341, 54);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 104);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 16;
            label1.Text = "Current Question List:";
            // 
            // CreateQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(971, 608);
            Controls.Add(label1);
            Controls.Add(openEndedPanel);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(multipleChoicePanel);
            Controls.Add(buttonCreate);
            Controls.Add(trueFalsePanel);
            Controls.Add(listBoxQuestion);
            Controls.Add(cbBoxQuesionType);
            Controls.Add(label2);
            Controls.Add(textBoxQuestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreateQuiz";
            Text = "ManageQuiz";
            Load += CreateQuiz_Load;
            openEndedPanel.ResumeLayout(false);
            openEndedPanel.PerformLayout();
            trueFalsePanel.ResumeLayout(false);
            trueFalsePanel.PerformLayout();
            multipleChoicePanel.ResumeLayout(false);
            multipleChoicePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel openEndedPanel;
        private Button buttonCreate;
        private ListBox listBoxQuestion;
        private ComboBox cbBoxQuesionType;
        private Label label2;
        private Panel trueFalsePanel;
        private TextBox textBoxQuestion;
        private Panel multipleChoicePanel;
        private TextBox textBoxOption3;
        private TextBox textBoxOption2;
        private TextBox textBoxOption1;
        private Label label4;
        private Label label3;
        private TextBox textBoxCorrectAns;
        private RadioButton radioButtonTrue;
        private TextBox textBoxOpenEnded;
        private RadioButton radioButtonFalse;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Label label1;
    }
}