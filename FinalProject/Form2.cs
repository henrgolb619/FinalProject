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
        int attemptsRemaining = 6; // starting guesses


        public Form2()
        {
            InitializeComponent();
        }



        // runs when the form loads
        private void Form2_Load(object sender, EventArgs ej)
        {
            
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
            string[] words = { "computer","notebook","student","programming",
                "science","teacher","library","mountain","adventure","holiday",
                "electricity","information","technology","imagination","environment"
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
        }

        private void secretWordLabel_Click(object sender, EventArgs e)
        {
            // no action needed when label is clicked
        }
    }
}