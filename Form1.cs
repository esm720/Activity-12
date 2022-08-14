using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Enrique Sanchezmurillo
 * CST-150, Activity 12
 * 14 August 2022
 */
namespace Activity_12
{
    public partial class Form1 : Form
    {
        StreamReader inputFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int counter = 0;
            String filePhrase;
            //Initiate directory for file
            openFile.InitialDirectory = "C:\\Users\\esm72\\source\\repos\\Activity 12\\bin\\Debug";
            openFile.ShowDialog();
            inputFile = File.OpenText(openFile.FileName);
            //Read file and assign contents to filePhrase
            filePhrase = inputFile.ReadToEnd();
            //Assign contentes to array by splitting it from punctuation
            String[] fileWords = filePhrase.Split(' ',',', '.', '!', '?','-');
            //Read each word for the t and e condition
            foreach (String word in fileWords)
            {
                if(word.EndsWith("t") || word.EndsWith("e"))
                {
                    counter++;
                }
            }
            MessageBox.Show("There are " + counter + " words that end in t or e");


        }
        //Close Form
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
