using System;
using System.Windows.Forms;

namespace Guess_Number
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int remainingAttempts = 5;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomNumber();
            Text = "Guess Number";
        }

        private void GenerateRandomNumber()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 11);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (remainingAttempts <= 0)
            {
                MessageBox.Show("You Lost The Game");
                return;
            }

            int guessedNumber = Convert.ToInt32(textBox1.Text);

            int difference = Math.Abs(randomNumber - guessedNumber);

            if (difference > 5)
            {
                Text = "Too High";
            }

            else if (difference < 5)
            {
                Text = "Too Low";
            }

            else
            {
                MessageBox.Show("You Won The Game");
                return;
            }

            remainingAttempts--;

            label2.Text = $"Attempts Remaining: {remainingAttempts}";

            textBox1.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
