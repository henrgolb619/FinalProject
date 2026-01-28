using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form2 : Form
    {
        string secretWord;
        string hiddenWord;
        int attemptsRemaining = 7; // starting guesses


        public Form2()
        {
            InitializeComponent();
        }



        // runs when the form loads
        private void Form2_Load(object sender, EventArgs ej)
        {
            loseLabel.Visible = false;
            resetButton.Visible = false;
            inputButton.Enabled = true;
            letterTextBox.Enabled = true;

            secretWord = GetSecretWord();
            hiddenWord = "";

            // create hidden word with underscores
            for (int i = 0; i < secretWord.Length; i++)
            {
                hiddenWord += "_";
            }

            // show hidden word on label
            secretWordLabel.Text = hiddenWord;

            // show starting attempts
            attemptLabel.Text = "Attempts Remaining: " + attemptsRemaining;
        }

        // returns a random word from the word list
        string GetSecretWord()
        {
            // list of words for hangman
            string[] words = {   
                "computer","notebook","student","programming","science","teacher","library",
                "mountain","adventure","holiday","electricity","information","technology",
                "imagination","environment",
                "education","engineering","chemistry","mathematics","geography","astronomy",
                "literature","philosophy","psychology","architecture","transportation",
                "communication","organization","civilization","responsibility"
};


            // pick a random index
            Random random = new Random();
            int index = random.Next(0, words.Length);

            return words[index];
        }

        // runs when the guess button is clicked
        private void inputButton_Click(object sender, EventArgs e)
        {
            // get the letter guessed by user
            string input = letterTextBox.Text.ToLower();

            // only allow single letters
            if (input.Length != 1)
            {
                return;
            }

            string newHidden = "";
            bool found = false; // track if letter is in the word

            // check each letter in secretWord
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == input[0])
                {
                    newHidden += input; // reveal letter if guessed correctly
                    found = true;
                }
                else
                {
                    newHidden += hiddenWord[i]; // keep underscore or previous letters
                }
            }

            hiddenWord = newHidden;
            secretWordLabel.Text = hiddenWord;

            // if letter not in word, subtract 1 attempt
            if (!found)
            {
                attemptsRemaining--;
                attemptLabel.Text = "Attempts Remaining: " + attemptsRemaining;
            }

            // clear input box
            letterTextBox.Text = "";

            if (attemptsRemaining == 0)
            {
                loseLabel.Text = "You lost! The word was " + secretWord;
                loseLabel.Visible = true;

                attemptLabel.Visible = false;
                inputButton.Enabled = false;
                letterTextBox.Enabled = false;
                resetButton.Visible = true;
            }

            // check if player has guessed the whole word
            if (hiddenWord == secretWord)
            {
                loseLabel.Text = "You won! The word was " + secretWord;
                loseLabel.Visible = true;

                attemptLabel.Visible = false;
                inputButton.Enabled = false;
                letterTextBox.Enabled = false;
                resetButton.Visible = true;
                resetButton.Text = "Play Again";
            }
            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // restart the game
            secretWord = GetSecretWord();
            hiddenWord = "";
            attemptsRemaining = 6;

            for (int i = 0; i < secretWord.Length; i++)
            {
                hiddenWord += "_";
            }

            secretWordLabel.Text = hiddenWord;
            attemptLabel.Text = "Attempts Remaining: " + attemptsRemaining;

            attemptLabel.Visible = true;
            loseLabel.Visible = false;
            resetButton.Visible = false;

            inputButton.Enabled = true;
            letterTextBox.Enabled = true;
            letterTextBox.Text = "";
        }
    }
}