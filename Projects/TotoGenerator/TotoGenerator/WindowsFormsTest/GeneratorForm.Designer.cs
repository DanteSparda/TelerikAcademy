namespace RandomTotoCombinationGenerator
{
    public partial class OuterBox
    {
        private System.Windows.Forms.Button generatingButton;
        private System.Windows.Forms.Panel numbersPanel;
        private System.Windows.Forms.RadioButton sixFortyNine;
        private System.Windows.Forms.RadioButton sixFourtyTwo;
        private System.Windows.Forms.RadioButton fiveThirtyfive;
        private System.Windows.Forms.RadioButton zodiak;
        private System.Windows.Forms.PictureBox pictureBoxOne;
        private System.Windows.Forms.PictureBox pictureBoxSix;
        private System.Windows.Forms.PictureBox pictureBoxFive;
        private System.Windows.Forms.PictureBox pictureBoxFour;
        private System.Windows.Forms.PictureBox pictureBoxThree;
        private System.Windows.Forms.PictureBox pictureBoxTwo;

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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.generatingButton = new System.Windows.Forms.Button();
            this.numbersPanel = new System.Windows.Forms.Panel();
            this.sixFortyNine = new System.Windows.Forms.RadioButton();
            this.sixFourtyTwo = new System.Windows.Forms.RadioButton();
            this.fiveThirtyfive = new System.Windows.Forms.RadioButton();
            this.zodiak = new System.Windows.Forms.RadioButton();
            this.pictureBoxOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxThree = new System.Windows.Forms.PictureBox();
            this.pictureBoxFour = new System.Windows.Forms.PictureBox();
            this.pictureBoxFive = new System.Windows.Forms.PictureBox();
            this.pictureBoxSix = new System.Windows.Forms.PictureBox();
            this.numbersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSix)).BeginInit();
            this.SuspendLayout();
            // 
            // generatingButton
            // 
            this.generatingButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.generatingButton.FlatAppearance.BorderSize = 2;
            this.generatingButton.Font = new System.Drawing.Font("Gabriola", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatingButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.generatingButton.Location = new System.Drawing.Point(235, 12);
            this.generatingButton.Name = "generatingButton";
            this.generatingButton.Size = new System.Drawing.Size(321, 87);
            this.generatingButton.TabIndex = 0;
            this.generatingButton.Text = "Toto Generator";
            this.generatingButton.UseVisualStyleBackColor = true;
            this.generatingButton.Click += new System.EventHandler(this.GeneratingButton_Click);
            // 
            // numbersPanel
            // 
            this.numbersPanel.Controls.Add(this.pictureBoxSix);
            this.numbersPanel.Controls.Add(this.pictureBoxFive);
            this.numbersPanel.Controls.Add(this.pictureBoxFour);
            this.numbersPanel.Controls.Add(this.pictureBoxThree);
            this.numbersPanel.Controls.Add(this.pictureBoxTwo);
            this.numbersPanel.Controls.Add(this.pictureBoxOne);
            this.numbersPanel.Location = new System.Drawing.Point(12, 114);
            this.numbersPanel.Name = "numbersPanel";
            this.numbersPanel.Size = new System.Drawing.Size(779, 124);
            this.numbersPanel.TabIndex = 19;
            // 
            // sixFortyNine
            // 
            this.sixFortyNine.AutoSize = true;
            this.sixFortyNine.Location = new System.Drawing.Point(41, 12);
            this.sixFortyNine.Name = "sixFortyNine";
            this.sixFortyNine.Size = new System.Drawing.Size(48, 17);
            this.sixFortyNine.TabIndex = 20;
            this.sixFortyNine.TabStop = true;
            this.sixFortyNine.Text = "6/49";
            this.sixFortyNine.UseVisualStyleBackColor = true;
            this.sixFortyNine.CheckedChanged += new System.EventHandler(this.SixFortyNine_CheckedChanged);
            // 
            // sixFourtyTwo
            // 
            this.sixFourtyTwo.AutoSize = true;
            this.sixFourtyTwo.Location = new System.Drawing.Point(41, 49);
            this.sixFourtyTwo.Name = "sixFourtyTwo";
            this.sixFourtyTwo.Size = new System.Drawing.Size(48, 17);
            this.sixFourtyTwo.TabIndex = 21;
            this.sixFourtyTwo.TabStop = true;
            this.sixFourtyTwo.Text = "6/42";
            this.sixFourtyTwo.UseVisualStyleBackColor = true;
            this.sixFourtyTwo.CheckedChanged += new System.EventHandler(this.SixFourtyTwo_CheckedChanged);
            // 
            // fiveThirtyfive
            // 
            this.fiveThirtyfive.AutoSize = true;
            this.fiveThirtyfive.Location = new System.Drawing.Point(645, 13);
            this.fiveThirtyfive.Name = "fiveThirtyfive";
            this.fiveThirtyfive.Size = new System.Drawing.Size(48, 17);
            this.fiveThirtyfive.TabIndex = 22;
            this.fiveThirtyfive.TabStop = true;
            this.fiveThirtyfive.Text = "5/35";
            this.fiveThirtyfive.UseVisualStyleBackColor = true;
            this.fiveThirtyfive.CheckedChanged += new System.EventHandler(this.FiveThirtyfive_CheckedChanged);
            // 
            // zodiak
            // 
            this.zodiak.AutoSize = true;
            this.zodiak.Location = new System.Drawing.Point(645, 49);
            this.zodiak.Name = "zodiak";
            this.zodiak.Size = new System.Drawing.Size(100, 17);
            this.zodiak.TabIndex = 23;
            this.zodiak.TabStop = true;
            this.zodiak.Text = "Zodiac/Зодиак";
            this.zodiak.UseVisualStyleBackColor = true;
            this.zodiak.CheckedChanged += new System.EventHandler(this.Zodiak_CheckedChanged);
            // 
            // pictureBoxOne
            // 
            this.pictureBoxOne.Location = new System.Drawing.Point(18, 13);
            this.pictureBoxOne.Name = "pictureBoxOne";
            this.pictureBoxOne.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxOne.TabIndex = 24;
            this.pictureBoxOne.TabStop = false;
            // 
            // pictureBoxTwo
            // 
            this.pictureBoxTwo.Location = new System.Drawing.Point(144, 13);
            this.pictureBoxTwo.Name = "pictureBoxTwo";
            this.pictureBoxTwo.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxTwo.TabIndex = 25;
            this.pictureBoxTwo.TabStop = false;
            // 
            // pictureBoxThree
            // 
            this.pictureBoxThree.Location = new System.Drawing.Point(274, 13);
            this.pictureBoxThree.Name = "pictureBoxThree";
            this.pictureBoxThree.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxThree.TabIndex = 26;
            this.pictureBoxThree.TabStop = false;
            // 
            // pictureBoxFour
            // 
            this.pictureBoxFour.Location = new System.Drawing.Point(404, 13);
            this.pictureBoxFour.Name = "pictureBoxFour";
            this.pictureBoxFour.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxFour.TabIndex = 27;
            this.pictureBoxFour.TabStop = false;
            // 
            // pictureBoxFive
            // 
            this.pictureBoxFive.Location = new System.Drawing.Point(536, 13);
            this.pictureBoxFive.Name = "pictureBoxFive";
            this.pictureBoxFive.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxFive.TabIndex = 28;
            this.pictureBoxFive.TabStop = false;
            // 
            // pictureBoxSix
            // 
            this.pictureBoxSix.Location = new System.Drawing.Point(660, 13);
            this.pictureBoxSix.Name = "pictureBoxSix";
            this.pictureBoxSix.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxSix.TabIndex = 29;
            this.pictureBoxSix.TabStop = false;
            // 
            // OuterBox
            // 
            this.ClientSize = new System.Drawing.Size(833, 262);
            this.Controls.Add(this.zodiak);
            this.Controls.Add(this.fiveThirtyfive);
            this.Controls.Add(this.sixFourtyTwo);
            this.Controls.Add(this.sixFortyNine);
            this.Controls.Add(this.numbersPanel);
            this.Controls.Add(this.generatingButton);
            this.Name = "OuterBox";
            this.Load += new System.EventHandler(this.OuterBox_Load);
            this.numbersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
