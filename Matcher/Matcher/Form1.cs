using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Matcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBackColor = Color.White;

            MatchCollection matchCollection = Regex.Matches(richTextBox1.Text, textBox1.Text);

            if (matchCollection.Count > 0)
            {
                foreach (Match match in matchCollection)
                {
                    richTextBox1.Select(match.Index, match.Length);
                    richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
