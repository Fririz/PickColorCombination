using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickColorCombinations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ButtonChangeColor BCC { get; set; } = new ButtonChangeColor();
        ChangeMode ChangeModeProg { get; set; } = new ChangeMode();
        CombineColors CombineColor { get; set; } = new CombineColors();

        private void button1_Click(object sender, EventArgs e)
        {
            BCC.FlatUIChangeButtonColor(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BCC.StandartChangeButtonColor(button2);
        }

        private void ChangeMode_Click(object sender, EventArgs e)
        {
            ChangeModeProg.ChangeModeFunc(button1, button2, buttonCombine, TextBoxMode, textBoxR, textBoxG, textBoxB);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCombine_Click(object sender, EventArgs e)
        {
            CombineColor.CombineColorsFunc(buttonCombine, textBoxR, textBoxG, textBoxB);
        }
    }
}
