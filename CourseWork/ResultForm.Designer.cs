namespace CourseWork {
    partial class ResultForm {
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
            dataGridViewSummary = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSummary).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSummary
            // 
            dataGridViewSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSummary.Location = new Point(69, 119);
            dataGridViewSummary.Name = "dataGridViewSummary";
            dataGridViewSummary.ReadOnly = true;
            dataGridViewSummary.RowHeadersWidth = 51;
            dataGridViewSummary.Size = new Size(641, 113);
            dataGridViewSummary.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 71);
            label1.TabIndex = 1;
            label1.Text = "Result Form";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridViewSummary);
            Name = "ResultForm";
            Text = "ResultForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSummary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewSummary;
        private Label label1;
    }
}