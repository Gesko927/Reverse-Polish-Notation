using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandInputFunction
{
    public partial class MainForm : Form
    {
        Function func;
        public MainForm()
        {
            InitializeComponent();

            func = new Function();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (func.IsRightDugki(expressionTextBox.Text))
            {
                polishTextBox.Text = func.ToPolish(func.StrWithWhitespaces(expressionTextBox.Text));
            }
            
            resultBox.Text = func.Result(polishTextBox.Text).ToString();
        }
    }
}
