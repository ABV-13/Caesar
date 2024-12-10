using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caesar
{
    public partial class Form2 : Form
    {

        public static string CaesarCipher(string text, int shift)
        {
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char letterOffset = char.IsUpper(letter) ? 'A' : 'a';
                    letter = (char)((((letter + shift) - letterOffset) % 26) + letterOffset);
                }

                buffer[i] = letter;
            }

            return new string(buffer);
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output_text.Text = CaesarCipher(input_text.Text, int.Parse(key_text_box.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void output_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText(output_text.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            input_text.Text = Clipboard.GetText();
        }
    }
}
