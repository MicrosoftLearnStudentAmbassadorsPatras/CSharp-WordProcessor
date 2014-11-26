using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp_Presentation_WordProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Returns s1 in Upper Case
        private void ToUpper_Click(object sender, EventArgs e)
        {
            string output_str = (s1.Text).ToUpper();
            MessageBox.Show("You've clicked ToUpper.\n" + "String s1 in Upper Case is: " + output_str);
        }

        // Returns s1 in Lower Case
        private void ToLower_Click(object sender, EventArgs e)
        {
            string output_str = (s1.Text).ToLower();
            MessageBox.Show("You've clicked ToLower.\n" + "String s1 in Lower Case is: " + output_str);
        }

        // Returns an Index of the position of s2 in s1
        private void IndexOf_Click(object sender, EventArgs e)
        {
            int output_int = (s1.Text).IndexOf(s2.Text);
            string output_str = output_int.ToString();
            MessageBox.Show("You've clicked IndexOf.\n" + "The index of s2 in s1 is: " + output_str);
        }

        // Returns the length of s1
        // \u0000 is the NULL character and it is counted as 1 extra
        // character in the total number if it exists in the string
        private void Length_Click(object sender, EventArgs e)
        {
            string output_str = ((s1.Text).Length).ToString();
            MessageBox.Show("You've clicked Length.\n" + "The Length of string s1 is: " + output_str);
        }

        // s1 is the string to be replaced.
        // s2 is the string to replace all occurrences of s1 in s3.
        private void Replace_Click(object sender, EventArgs e)
        { 
            string output_str = (s3.Text).Replace( s1.Text, s2.Text);
            MessageBox.Show("You've clicked Replace.\n" + "The new string is: " + output_str);
        }

        // <0 if s1 < s2
        // >0 if s1 > s2
        // =0 if s1 = s2
        // The bool value determines whether the comparison
        // will be case sensitive or not
        // the comparison is between strings s1 & s2
        private void Compare_Click(object sender, EventArgs e)
        {
            int output_int = String.Compare( s1.Text, s2.Text, false );
            string output_str = output_int.ToString();

            MessageBox.Show("You've clicked Compare.");

            if (output_int > 0) MessageBox.Show("s1 > s2 ");
            else if (output_int < 0) MessageBox.Show("s1 < s2 ");
            else if (output_int == 0) MessageBox.Show("s1 == s2 ");
        }

        // Splits the words of a string (s1) based on an array of chars
        // (the array is predefined in our case for the sake of simplicity)
        // and returns an array of strings
        // (each string in the array contains a word)
        private void Split_Click(object sender, EventArgs e)
        {
            // Unicode Chars in char[] args
            // (left to right):  Space, Coma, Full stop, Colon
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            string[] output_str = (s1.Text).Split(delimiterChars);

            MessageBox.Show("You've Clicked Split.");
            for (int i = 0; i < output_str.Length; i++)
            {
                MessageBox.Show((i + 1).ToString() + ". word is: " + output_str[i]);
            }
        }

        // Inserts s2 at the end of s1
        private void Insert_Click(object sender, EventArgs e)
        {
            string output_str = (s1.Text).Insert((s1.Text).Length, s2.Text);
            MessageBox.Show("You've clicked Insert.\n" + "The Length of the sting is: " + output_str);
        }

        // Checks whether s1 starts with s2
        // and returns a bool value
        private void StartsWith_Click(object sender, EventArgs e)
        {
            bool output_bool = (s1.Text).StartsWith(s2.Text);

            MessageBox.Show("You've clicked StartsWith.");

            if (output_bool == true) MessageBox.Show("s1 starts with s2");
            else MessageBox.Show("s1 doesn't start with s2");
        }

        // s1 is the string that is modified
        // s2 is the number of characters to delete
        // the deletion always starts at 0 for functional purposes
        private void Remove_Click(object sender, EventArgs e)
        {
            int num_char = Int32.Parse(s2.Text);
            string output_str = (s1.Text).Remove(0, num_char);
            MessageBox.Show("You've clicked Remove.\n" + "The new s1 is: " + output_str);
        }
    }
}
