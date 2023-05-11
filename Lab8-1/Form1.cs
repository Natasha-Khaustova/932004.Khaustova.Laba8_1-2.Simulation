using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void yOrNBtn_Click(object sender, EventArgs e)
        {
            if(queTxtBox.Text.Length!=0)
            {
                Random rnd = new Random();
                int value = rnd.Next(0, 2);
                if (value == 1)
                    answerLabel.Text = "YES";
                else
                    answerLabel.Text = "NO";
            }
            else
            {
                MessageBox.Show("No question - no answer!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queTxtBox.Text.Length != 0)
            {
                String[] answer = { "It is certain", "It is decidedly so", "Without a doubt",
                "Yes — definitely", "You may rely on it",
                "As I see it, yes", "Most likely", "Outlook good",
                "Signs point to yes", "Yes", "Reply hazy, try again",
                "Ask again later", "Better not tell you now", "Cannot predict now",
                "Concentrate and ask again", "Don’t count on it", "Very doubtful",
                "My reply is no", "My sources say no", "Outlook not so good"};

                double p = 1.0 / 20.0;

                Random rnd = new Random();
                double A = rnd.NextDouble();
                int value = 0;
                A -= p;

                while (A > 0)
                {
                    A -= p;
                    value++;
                };
                magicBallLabel.Text = answer[value];

            }
            else
            {
                MessageBox.Show("No question - no answer!");
            }
        }
    }
}
