using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;

namespace _14._8GuessNumberSK
{
    public partial class Form1 : Form
    {
        static int number = 0;
        int guessedNumber = 0;
        static string message = "";
        static int guessDifference = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadNewGame();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            guessedNumber = Convert.ToInt32(txt_Guess.Text);

            if(Math.Abs(number - guessedNumber) < guessDifference)
            {
                this.BackColor = Color.Red;
            } else
            {
                this.BackColor = Color.Blue;
            }

            if (guessedNumber > number)
            {
                message = "Too High";
                txt_Guess.Focus();
            }
            else if (guessedNumber < number)
            {
                message = "Too Low";
                txt_Guess.Focus();
            }
            else
            {
                message = "Correct!";
                this.BackColor = Color.Green;
                btn_Guess.Enabled = false;
            }

            lbl_hint.Text = message;
            guessDifference = Math.Abs(number - guessedNumber);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            loadNewGame();
        }
        //Load a new game
        private void loadNewGame()
        {
            //Make new random number
            var rand = new Random();
            number = rand.Next(1,1001);

            //Enable game
            btn_Guess.Enabled = true;
            txt_Guess.Clear();
            this.BackColor = Color.White;
            lbl_hint.Text = "";
            txt_Guess.Focus();
        }
    }
}