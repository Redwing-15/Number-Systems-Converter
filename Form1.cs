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
            inputSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            inputSelect.SelectedIndex = 0;

            outputSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            outputSelect.SelectedIndex = 1;
        }

        private void inputEntry_TextChanged(object sender, EventArgs e)
        {
            outputEntry.Text = inputEntry.Text;
        }
    }
}
