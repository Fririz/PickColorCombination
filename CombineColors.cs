using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickColorCombinations
{
    class CombineColors
    {
        public void CombineColorsFunc(Button buttonCombine, TextBox textBoxR, TextBox textBoxG, TextBox textBoxB)
        {
            int R = Convert.ToInt32(textBoxR.Text);
            int G = Convert.ToInt32(textBoxG.Text);
            int B = Convert.ToInt32(textBoxB.Text);

            if (R <= 255 && G <= 255 && B <= 255)
                buttonCombine.BackColor = Color.FromArgb(255, R, G, B);
        }
    }
}
