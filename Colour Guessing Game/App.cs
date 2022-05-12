using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colour_Guessing_Game
{
    public partial class App : Form
    {
        int gameDuration = 30;
        int gameScore = 0;
        int gameHighscore = 0;
        bool running = false;
        Timer timer;
        Random colourPicker = new Random();

        string gameAnswer = "";

        List<string> coloursList = new List<string>
        {
            "Red",
            "Blue",
            "Purple",
            "Orange",
            "Brown",
            "Yellow",
            "Pink"
        };

        public App()
        {
            InitializeComponent();
        }

        private string getRandomColour()
        {
            int index = colourPicker.Next(0, coloursList.Count);
            string colourOutput = coloursList[index];
            return colourOutput;
        }

        private void setRandomColours()
        {
            string textColour = getRandomColour();
            string textOutput = getRandomColour();


            ColourOutput.ForeColor = Color.FromName(textColour);
            ColourOutput.Text = textOutput;
            gameAnswer = textColour;
            
        }
        private bool correctAnswer(string answer = "")
        {
            if (answer.ToLower() == gameAnswer.ToLower() && answer != "")
            {
                return true;
            }

            return false;
        }

        private void setScore(int newScore=0)
        {
            gameScore = newScore;
            ScoreLabel.Text = "Score: " + newScore.ToString();
        }

        private void incrementScore()
        {
            gameScore++;
            ScoreLabel.Text = "Score: " + gameScore.ToString();
        }
        private bool setHighscore(int HighscoreNumber=0)
        {
            if (HighscoreNumber > gameHighscore)
            {
                gameHighscore = HighscoreNumber;
                HighscoreLabel.Text = "Highscore: " + HighscoreNumber.ToString();
                return true;
            }
            return false;
        }

        private void resetGame(bool showMessage=true)
        {
            timer.Stop();
            running = false;
            if (showMessage == true)
            {
                bool setHigh = setHighscore(gameScore);
                if (setHigh == true)
                {
                    MessageBox.Show($"You set a new Highscore of {gameScore}!", "Guess the Colour");
                }
                else
                {
                    MessageBox.Show($"You got a score of {gameScore}!", "Guess the Colour");
                }
            }


            gameDuration = 30;
            setScore();
            ColourOutput.ForeColor = Color.FromName("White");
            ColourOutput.Text = "Type something into the box below to start.";
        }



        private void TimerTick(object sender, EventArgs e)
        {
            
            if (running == false)
            {
                resetGame();
            } else
            {
                gameDuration -= 1;
                timerOutput.Text = $"Time Left: {gameDuration}";
                if (gameDuration <= 0)
                {
                    resetGame();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void App_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // Runs every 1 second
            timer.Tick += new EventHandler(TimerTick);
            timer.Stop();

        }

        private void ColourEntry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            string answerProvided = ColourEntry.Text;

            ColourEntry.Text = ""; // Deletes text

            if (running == false)
            {
                resetGame(false);
                running = true;
                timer.Start();
                setRandomColours();
                return;
            }

            bool answerCorrect = correctAnswer(answerProvided);

            if (answerCorrect == true)
            {
                incrementScore();
            }

            setRandomColours();
            e.Handled = true;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool showMessage;

            if (gameScore > 0)
            {
                showMessage = true;
            } else
            {
                showMessage = false;
            }

            resetGame(showMessage);
        }
    }
}
