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
        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            string secretWord = GetSecretWord();
            secretWordLabel.Text = secretWord;
        }

        string GetSecretWord()
        {
            // array of words with more than 5 letters
            string[] words = { "computer", "notebook", "student", "program", "science",
                           "teacher", "library", "morning", "picture", "holiday" };

            Random random = new Random();
            int index = random.Next(0, words.Length);

            return words[index];
        }


    }
}
