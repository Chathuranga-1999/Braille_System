using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Braill_System
{
    public partial class Form3 : Form
    {
        int dotCount = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbldot.Visible = false;
            lblNdot.Visible = false;
            lblbraill.Visible = false;
            btncal.Visible = false;
        }

        private void btncon_Click(object sender, EventArgs e)
        {
            btncal.Visible = true;
            lblbraill.Visible = true;
            lblNdot.Visible = false;
            lbldot.Visible = false;
            string T = txtT.Text;
            string B = ConvertToBraille(T);
            lblbraill.Text = B;
            dotCount = 0;
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {


        }

        private string ConvertToBraille(string text)
        {

            // Define a dictionary with the Braille alphabet
            Dictionary<char, string> braille = new Dictionary<char, string>()
    {
         //letters
        {'a', "⠁"},{'b', "⠃"},{'c', "⠉"},{'d', "⠙"},
        {'e', "⠑"}, {'f', "⠋"},{'g', "⠛"},{'h', "⠓"},
        {'i', "⠊"},{'j', "⠚"},{'k', "⠅"},{'l', "⠇"},
        {'m', "⠍"},{'n', "⠝"}, {'o', "⠕"},{'p', "⠏"},
        {'q', "⠟"}, {'r', "⠗"},{'s', "⠎"}, {'t', "⠞"},
        {'u', "⠥"},{'v', "⠧"},{'w', "⠺"},{'x', "⠭"},
        {'y', "⠽"},{'z', "⠵"},

        //numbers
        {'0',"⠚"},{'1',"⠁" },{'2',"⠃"},{'3',"⠉"},{'4',"⠙"},{'5',"⠑"},
        {'6', "⠋"},{'7',"⠛"},{'8',"⠓"},{'9',"⠊"}

    };

            // Convert the text string to Braille
            StringBuilder brailleText = new StringBuilder();
            foreach (char c in text.ToLower())
            {
                if (braille.ContainsKey(c))
                {
                    brailleText.Append(braille[c]);
                }
                else
                {
                    brailleText.Append(c);
                }
            }

            return brailleText.ToString();
        }
        //calculate the dot count in braill
        private void btncal_Click(object sender, EventArgs e)
        {
            dotCount = 0;
            string T = txtT.Text;
            string B = ConvertToBraille(T);
           lbldot.Visible = true;
            lblNdot.Visible = true;
            Braill_count(B);
             
        }
        private void Braill_count(string brailleText)
        {

            foreach (char c in brailleText.ToString())
            {
                if (c >= 0x2800 && c <= 0x28FF) // Check if the character is a valid Braille character
                {
                    for (int i = 0; i < 6; i++) // Iterate through each dot position
                    {
                        if ((c & (1 << i)) != 0) // Check if the dot is raised
                        {
                            dotCount++; // Increment the dot count
                        }
                    }
                }
            }
            lbldot.Text=dotCount.ToString();

            
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void btntext_Click(object sender, EventArgs e)
        {
            Form2 myForm = new Form2();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
