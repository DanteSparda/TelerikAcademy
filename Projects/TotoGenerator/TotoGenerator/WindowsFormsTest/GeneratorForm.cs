namespace RandomTotoCombinationGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class OuterBox : Form
    {
        private const string SixFromFortyNine = "6/49";
        private const string SixFromFortyTwo = "6/42";
        private const string FiveFromThirtyFive = "5/35";
        private const string Zodiac = "Zodiak/Зодиак";
        private const int MaxRangeSixFromFortyNine = 49;
        private const int MaxRangeSixFromFortyTwo = 42;
        private const int MaxRangeFiveFromThirtyFive = 35;
        private const int MaxRangeZodiac = 50;
        private string number;
        private List<string> generatedNumbers;
        private int numberOfMembersInSeries = 6;

        public OuterBox()
        {
            this.InitializeComponent();
        }

        private void OuterBox_Load(object sender, EventArgs e)
        {
            this.numbersPanel.Visible = false;
            this.generatingButton.Enabled = false;
            this.sixFortyNine.Checked = false;
            this.sixFortyNine.AutoCheck = false;
            this.sixFortyNine.AutoCheck = true;
        }

        private void SetNumbersInPositions()
        {
            if (this.numberOfMembersInSeries == 6)
            {
                Image firstBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[0] + ".png");
                Image secondBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[1] + ".png");
                Image thirdBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[2] + ".png");
                Image fourthBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[3] + ".png");
                Image fifthBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[4] + ".png");
                Image sixthBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[5] + ".png");

                this.pictureBoxOne.Image = firstBoxImage;
                this.pictureBoxTwo.Image = secondBoxImage;
                this.pictureBoxThree.Image = thirdBoxImage;
                this.pictureBoxFour.Image = fourthBoxImage;
                this.pictureBoxFive.Image = fifthBoxImage;
                this.pictureBoxSix.Image = sixthBoxImage;
                this.pictureBoxSix.Visible = true;
            }
            else
            {
                Image firstBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[0] + ".png");
                Image secondBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[1] + ".png");
                Image thirdBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[2] + ".png");
                Image fourthBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[3] + ".png");
                Image fifthBoxImage = Image.FromFile("..\\..\\Numbers and Zodiacs\\" + this.generatedNumbers[4] + ".png");

                this.pictureBoxOne.Image = firstBoxImage;
                this.pictureBoxTwo.Image = secondBoxImage;
                this.pictureBoxThree.Image = thirdBoxImage;
                this.pictureBoxFour.Image = fourthBoxImage;
                this.pictureBoxFive.Image = fifthBoxImage;
                this.pictureBoxSix.Visible = false;
            }
        }

        private void GeneratingButton_Click(object sender, EventArgs e)
        {
            // Generate numbers
            if (this.number == SixFromFortyNine)
            {
                this.generatedNumbers = Toto.TotoGenerator(MaxRangeSixFromFortyNine);
                this.numberOfMembersInSeries = 6;
            }
            else if (this.number == SixFromFortyTwo)
            {
                this.generatedNumbers = Toto.TotoGenerator(MaxRangeSixFromFortyTwo);
                this.numberOfMembersInSeries = 6;
            }
            else if (this.number == FiveFromThirtyFive)
            {
                this.generatedNumbers = Toto.TotoGenerator(MaxRangeFiveFromThirtyFive);
                this.numberOfMembersInSeries = 5;
            }
            else if (this.number == Zodiac)
            {
                this.generatedNumbers = Toto.TotoGenerator(MaxRangeZodiac);
                this.numberOfMembersInSeries = 6;
            }

            this.SetNumbersInPositions();
            this.numbersPanel.Visible = true;
        }

        // Radio buttons checked
        private void SixFortyNine_CheckedChanged(object sender, EventArgs e)
        {
            this.number = SixFromFortyNine;
            this.generatingButton.Enabled = true;
            this.BackColor = Color.IndianRed;
        }

        private void SixFourtyTwo_CheckedChanged(object sender, EventArgs e)
        {
            this.number = SixFromFortyTwo;
            this.generatingButton.Enabled = true;
            this.BackColor = Color.DeepSkyBlue;
        }

        private void FiveThirtyfive_CheckedChanged(object sender, EventArgs e)
        {
            this.number = FiveFromThirtyFive;
            this.generatingButton.Enabled = true;
            this.BackColor = Color.Green;
        }

        private void Zodiak_CheckedChanged(object sender, EventArgs e)
        {
            this.number = Zodiac;
            this.generatingButton.Enabled = true;
            this.BackColor = Color.DodgerBlue;
        }
    }
}
