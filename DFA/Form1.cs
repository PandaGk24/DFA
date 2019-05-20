using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile(ref string name)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                name = openfile.FileName;
            }
        }

        private void ReadFile(string name)
        {
            int n = 0;
            StreamReader reader = File.OpenText(name);
            StreamReader reader2 = File.OpenText(name);
            string xy = "";

            while ((xy = reader.ReadLine()) != null)
            {
                n++;
            }

            Parts.condition = new int[n, Parts.alphabet.Length];
            Parts.finished = new bool[n];

            n = 0;

            while ((xy = reader2.ReadLine()) != null)
            {
                string[] split = xy.Split(' ');

                for (int i = 0; i < Parts.alphabet.Length; i++)
                {
                    Parts.condition[n, i] = Convert.ToInt32(split[i]);
                }

                if (split[Parts.alphabet.Length].Equals("f"))
                {
                    Parts.finished[n] = false;
                }
                else
                {
                    Parts.finished[n] = true;
                }
                n++;
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string str = InputBox.Text;
                if (str.Length == 0)
                {
                    MessageBox.Show("Wrong alphabet input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (str.Length > 1)
                {
                    for (int i = 1; i < str.Length; i = i + 2)
                    {
                        if (!str[i].Equals(';'))
                        {
                            MessageBox.Show("Wrong alphabet input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                Parts.alphabet = str.Split(';');
                FileLoad.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Wrong alphabet reading!", "Check ur alphabet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FileLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string file = "";
                OpenFile(ref file);
                ReadFile(file);
            }
            catch
            {
                MessageBox.Show("File reading violation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = 0; i < Parts.alphabet.Length; i++)
            {
                if (i == Parts.alphabet.Length - 1)
                {
                    AlphabetShow.Text += Parts.alphabet[i];
                }
                else AlphabetShow.Text += Parts.alphabet[i] + ";";
            }
        }       

        string str;
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            str = StringInput.Text;
            string alphabet = string.Join(null, Parts.alphabet);
            for (int i = 0; i < str.Length; i++)
            {
                if (!alphabet.Contains(str[i].ToString()))
                {
                    MessageBox.Show("These symbols aren't from the alphabet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            PositionLabel.Text = "0";

            PositionCheck.Enabled = true;
            ApplyButton.Enabled = false;
        }

        int countLetter = 0;
        int currentState = 0;
        bool isFinish;

        private void PositionCheck_Click(object sender, EventArgs e)
        {
            if (str.Length == 0)
            {
                MessageBox.Show("Stopped at step " + currentState + Environment.NewLine + "This step isn't final -> automate doesn't accept this string", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PositionCheck.Enabled = false;
                ApplyButton.Enabled = true;
                return;
            }

            for (int i = 0; i < Parts.alphabet.Length; i++)
            {
                if (str[countLetter].ToString().Equals(Parts.alphabet[i]))
                {
                    currentState = Parts.condition[currentState, i];
                }
            }

            isFinish = Parts.finished[currentState];
            countLetter++;
            PositionCheck.Text = ("Check letter #" + (countLetter + 1)).ToString();

            PositionLabel.Text = currentState.ToString();
            if (isFinish)
            {
                PositionLabel.ForeColor = Color.Green;
            }
            else PositionLabel.ForeColor = Color.Black;

            if (str.Length == countLetter)
            {
                if (isFinish)
                {
                    MessageBox.Show("Stopped at step " + currentState + Environment.NewLine + "This step is final -> automate accepts this string", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    currentState = 0;
                    countLetter = 0;
                    PositionCheck.Text = ("Check letter #" + (countLetter + 1)).ToString();

                    PositionCheck.Enabled = false;
                    ApplyButton.Enabled = true;
                }
                if (!isFinish)
                {
                    MessageBox.Show("Stopped at step " + currentState + Environment.NewLine + "This step isn't final -> automate doesn't accept this string", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    currentState = 0;
                    countLetter = 0;
                    PositionCheck.Text = ("Check letter #" + (countLetter + 1)).ToString();
                    PositionLabel.ForeColor = Color.Black;

                    PositionCheck.Enabled = false;
                    ApplyButton.Enabled = true;
                }
            }
        }

        private void RefreshAll_Click(object sender, EventArgs e)
        {
            AlphabetShow.ResetText();
            StringInput.Clear();
            PositionLabel.ResetText();
        }
    }
}
