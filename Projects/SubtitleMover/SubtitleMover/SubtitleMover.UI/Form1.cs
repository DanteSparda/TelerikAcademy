using System;
using System.Drawing;
using System.Windows.Forms;

namespace SubtitleMover.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = textBox1.Text;
            var mover = new SubMover(path);
            if (radioButton1.Checked)
            {
                textBox2.Text = "Moving subtitles to sub folders!";
                var response = mover.MoveSubtitlesToDirectories();
                if (response.HasMoved)
                {
                    textBox2.Text = string.Format("Total {0} subtitles were moved", response.Count);
                }
                else
                {
                    textBox2.Text = response.Message;
                    textBox2.ForeColor = Color.Red;
                }
            }
            else if (radioButton2.Checked)
            {
                textBox2.Text = "Moving videos to main folder!";
                var response = mover.MoveVideosToMainDirectory();
                if (response.HasMoved)
                {
                    textBox2.Text = string.Format("Total {0} videos were moved", response.Count);
                }
                else
                {
                    textBox2.Text = response.Message;
                    textBox2.ForeColor = Color.Red;
                }

            }
            else
            {
                textBox2.Text = "Something went wrong";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && textBox1.Text.Length != 0)
            {
                button1.Text = "RUN";
                button1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length!=0 && !radioButton1.Checked && !radioButton2.Checked)
            {
                button1.Text = "Please enter an action via the radio buttons";
            }
            else if(radioButton1.Checked || radioButton2.Checked)
            {
                button1.Text = "RUN";
                button1.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButton1.TabStop = false;
            this.radioButton2.TabStop = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked && textBox1.Text.Length != 0)
            {
                button1.Text = "RUN";
                button1.Enabled = true;
            }
        }
    }
}
