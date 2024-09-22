namespace CSI_122_Assignment_1
{
    partial class wMain
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
            lNumGrade = new Label();
            lLetterGrade = new Label();
            tbNumGrade = new TextBox();
            tbLetterGrade = new TextBox();
            bCalculate = new Button();
            bExit = new Button();
            gbInputBox = new GroupBox();
            lGradeError = new Label();
            gbInputBox.SuspendLayout();
            SuspendLayout();
            // 
            // lNumGrade
            // 
            lNumGrade.AutoSize = true;
            lNumGrade.Location = new Point(24, 35);
            lNumGrade.Name = "lNumGrade";
            lNumGrade.Size = new Size(68, 15);
            lNumGrade.TabIndex = 0;
            lNumGrade.Text = "lNumGrade";
            // 
            // lLetterGrade
            // 
            lLetterGrade.AutoSize = true;
            lLetterGrade.Location = new Point(21, 65);
            lLetterGrade.Name = "lLetterGrade";
            lLetterGrade.Size = new Size(71, 15);
            lLetterGrade.TabIndex = 1;
            lLetterGrade.Text = "lLetterGrade";
            // 
            // tbNumGrade
            // 
            tbNumGrade.Location = new Point(112, 32);
            tbNumGrade.Name = "tbNumGrade";
            tbNumGrade.Size = new Size(100, 23);
            tbNumGrade.TabIndex = 2;
            // 
            // tbLetterGrade
            // 
            tbLetterGrade.Location = new Point(112, 62);
            tbLetterGrade.Name = "tbLetterGrade";
            tbLetterGrade.Size = new Size(100, 23);
            tbLetterGrade.TabIndex = 3;
            // 
            // bCalculate
            // 
            bCalculate.Location = new Point(24, 103);
            bCalculate.Name = "bCalculate";
            bCalculate.Size = new Size(75, 23);
            bCalculate.TabIndex = 4;
            bCalculate.Text = "bCalculate";
            bCalculate.UseVisualStyleBackColor = true;
            bCalculate.Click += bCalculate_Click;
            // 
            // bExit
            // 
            bExit.Location = new Point(137, 103);
            bExit.Name = "bExit";
            bExit.Size = new Size(75, 23);
            bExit.TabIndex = 5;
            bExit.Text = "bExit";
            bExit.UseVisualStyleBackColor = true;
            // 
            // gbInputBox
            // 
            gbInputBox.Controls.Add(lGradeError);
            gbInputBox.Controls.Add(bExit);
            gbInputBox.Controls.Add(bCalculate);
            gbInputBox.Controls.Add(tbLetterGrade);
            gbInputBox.Controls.Add(tbNumGrade);
            gbInputBox.Controls.Add(lLetterGrade);
            gbInputBox.Controls.Add(lNumGrade);
            gbInputBox.Location = new Point(61, 32);
            gbInputBox.Name = "gbInputBox";
            gbInputBox.Size = new Size(356, 168);
            gbInputBox.TabIndex = 7;
            gbInputBox.TabStop = false;
            gbInputBox.Text = "gbInputBox";
            // 
            // lGradeError
            // 
            lGradeError.AutoSize = true;
            lGradeError.Location = new Point(233, 35);
            lGradeError.Name = "lGradeError";
            lGradeError.Size = new Size(66, 15);
            lGradeError.TabIndex = 6;
            lGradeError.Text = "lGradeError";
            // 
            // wMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbInputBox);
            Name = "wMain";
            Text = "wMain";
            gbInputBox.ResumeLayout(false);
            gbInputBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lNumGrade;
        private Label lLetterGrade;
        private TextBox tbNumGrade;
        private TextBox tbLetterGrade;
        private Button bCalculate;
        private Button bExit;
        private GroupBox gbInputBox;
        private Label lGradeError;
    }
}
