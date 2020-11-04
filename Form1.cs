using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encoding_and_decoding
{
    public partial class Form1 : Form
    {
        public byte[] ToEndceAsBytes { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                byte[] ToDecodeData = System.Convert.FromBase64String(textBox2.Text);
                MessageBox.Show(System.Text.Encoding.UTF8.GetString(ToDecodeData));
            }
            else
            {
                byte[] ToEncodeData = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
                textBox2.Text = System.Convert.ToBase64String(ToEncodeData);
            }
            
        }
    }
}
