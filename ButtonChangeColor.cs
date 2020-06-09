using System;
using System.Drawing;
using System.Windows.Forms;

namespace PickColorCombinations
{
    class ButtonChangeColor
    {
        public void StandartChangeButtonColor(Button button1)
        {
            Color[] array = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.White, Color.Black, Color.Gray, Color.AntiqueWhite, Color.Aqua, Color.Azure, Color.Black, Color.DimGray, Color.BlanchedAlmond, Color.DarkGoldenrod };
            Random Rand = new Random();
            button1.BackColor = array[Rand.Next(0, array.Length)];
            button1.ForeColor = array[Rand.Next(0, array.Length)];
            button1.Text = $"BackColor = {button1.BackColor} \nForeColor = {button1.ForeColor}";
        }
        public void FlatUIChangeButtonColor(Button button1)
        {
            Color[] array = new Color[]
            {
                Color.FromArgb(26, 188, 156, 1), Color.FromArgb(46, 204, 113, 1), Color.FromArgb(52, 152, 219, 1), Color.FromArgb(155, 89, 182, 1), Color.FromArgb(52, 73, 94),
                Color.FromArgb(22, 160, 133, 1), Color.FromArgb(39, 174, 96, 1), Color.FromArgb(41, 128, 185, 1), Color.FromArgb(142, 68, 173, 1), Color.FromArgb(44, 62, 80, 1),
                Color.FromArgb(241, 196, 15, 1), Color.FromArgb(230, 126, 34, 1), Color.FromArgb(231, 76, 60,1), Color.FromArgb(236, 240, 241,1), Color.FromArgb(149, 165, 166,1),
                Color.FromArgb(243, 156, 18,1), Color.FromArgb(211, 84, 0,1), Color.FromArgb(192, 57, 43,1), Color.FromArgb(189, 195, 199,1), Color.FromArgb(127, 140, 141,1)

            };
            Random Rand = new Random();
            button1.BackColor = array[Rand.Next(0, array.Length)];
            button1.ForeColor = array[Rand.Next(0, array.Length)];
            button1.Text = $"BackColor = {button1.BackColor} \nForeColor = {button1.ForeColor}";
        }
    }
}
