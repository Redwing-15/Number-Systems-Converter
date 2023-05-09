using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Systems_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputEntry_TextChanged(object sender, EventArgs e)
        {
            outputEntry.Text = inputEntry.Text;
        }

        private void inputSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] options = new string[5] { "Binary", "Decimal", "Octal", "Hexadecimal", "ASCII"};
            int index = -1;
            foreach (string item in options)
            {
                index++;
                if (!outputSelect.Items.Contains(item))
                {
                    outputSelect.Items.Insert(index, item);
                }
            }

            if (inputSelect.SelectedItem.ToString() == "Hexadecimal")
            {
                outputSelect.Items.Add("RGB");
            }
            else
            {
                outputSelect.Items.Remove("RGB");
            }

            if (inputSelect.SelectedItem.ToString() == "RGB")
            {
                outputSelect.Items.Clear();
                outputSelect.Items.Add("Hexadecimal");
            }

            outputSelect.Items.Remove(inputSelect.SelectedItem.ToString());
        }

        private void outputSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
