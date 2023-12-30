using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace davaleba13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] saxelebi = { "ავთო", "ბარბარე", "ბექა", "კაკო", "თორნიკე", "ავთო", "მარიამი" };
            var starts_with_b = from saxeli in saxelebi where saxeli.StartsWith("ბ") select saxeli;
            foreach (var saxeli in starts_with_b)
            {
                label1.Text += saxeli + ", ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] saxelebi = { "ავთო", "ბარბარე", "ბექა", "კაკო", "თორნიკე", "ავთო", "მარიამი" };
            var starts_with_b = from saxeli in saxelebi orderby saxeli ascending select saxeli;
            foreach (var saxeli in starts_with_b)
            {
                label1.Text += saxeli + ", ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string[] saxelebi = { "ავთო", "ბარბარე", "ბექა", "კაკო", "თორნიკე", "ავთო", "მარიამი" };
            var starts_with_b = from saxeli in saxelebi orderby saxeli descending select saxeli;
            foreach (var saxeli in starts_with_b)
            {
                label1.Text += saxeli + ", ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Random random = new Random();
            int[] numarray = new int[1000000];
            int counter = 0;
            for (int i = 0; i < numarray.Length; i++)
            {
                numarray[i] = random.Next();
            }
            var starts_with_b = from num in numarray where num % 5 == 0 select num;
            foreach (var num in starts_with_b)
            {
                if (counter == 11)
                {
                    label1.Text += "\n";
                    counter = 0;
                }
                label1.Text += num + ", ";
                counter++;
            }
        }
    }
}
