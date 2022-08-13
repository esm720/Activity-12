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
            openFile.InitialDirectory = "C:\\Users\\esm72\\source\\repos\\Activity 12\\bin\\Debug";
            openFile.ShowDialog();
            inputFile = File.OpenText(openFile.FileName);
            filePhrase = inputFile.ReadToEnd();
            String[] fileWords = filePhrase.Split(' ',',', '.', '!', '?','-');
            foreach (String word in fileWords)
            {
                if(word.EndsWith("t") || word.EndsWith("e"))
                {
                    counter++;
                }
            }
            MessageBox.Show("There are " + counter + " words that end in t or e");


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
