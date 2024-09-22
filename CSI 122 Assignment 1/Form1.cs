using System.Diagnostics;

namespace CSI_122_Assignment_1
{
    public partial class wMain : Form
    {
        public wMain()
        {
            InitializeComponent();
            this.Text = "Grade Calculator";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;

            int xPos = (this.ClientSize.Width - gbInputBox.Width) / 2;
            int yPos = (this.ClientSize.Height - gbInputBox.Height) / 2;


            gbInputBox.Text = "";
            gbInputBox.BackColor = System.Drawing.Color.LightGray;
            gbInputBox.Location = new Point(xPos, yPos);

            lNumGrade.Text = "Number Grade";
            lNumGrade.TextAlign = ContentAlignment.MiddleLeft;
            lNumGrade.TabIndex = 0;

            lLetterGrade.Text = "Letter Grade";
            lLetterGrade.TextAlign = ContentAlignment.MiddleLeft;

            lGradeError.Text = "Incorrect Input. \n Try Again";
            lGradeError.ForeColor = System.Drawing.Color.Red;
            lGradeError.Visible = false;

            tbNumGrade.TabIndex = 1;

            tbLetterGrade.ReadOnly = true;
            tbLetterGrade.TabStop = false;
            tbLetterGrade.ForeColor = System.Drawing.Color.DarkGray;

            bCalculate.Text = "Calculate";
            bCalculate.TabIndex = 2;

            bExit.Text = "Exit";
            bExit.TabIndex = 3;
            bExit.Click += bExit_Click;
        }
        //-----------------------------------------------------------------------
        #region
        private void bCalculate_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        //----------------------------------------------------------------------
        #region
        public void CheckInput()
        {
            double grade;

            if (!double.TryParse(tbNumGrade.Text, out grade))
            {
                lGradeError.Visible = true;
            }
            else
            {
                lGradeError.Visible = false;
                tbLetterGrade.Text = GradeCalc(grade);
            }
        }
        public string GradeCalc(double grade)
        {
            return grade switch
            {
                >= 90 and <= 100 => "A",
                >= 80 and < 90 => "B",
                >= 70 and < 80 => "C",
                >= 60 and < 70 => "D",
                >= 0 and < 60 => "F",
                _ => "Invalid"  // Handle out-of-bound grades
            };
        }
        #endregion

    }
}
