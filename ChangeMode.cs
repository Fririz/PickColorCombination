using System;
using System.Windows.Forms;

namespace PickColorCombinations
{
    class ChangeMode
    {
        bool State { get; set; } = true; // if true - 1 mode, if false - 2 mode
        public void ChangeModeFunc(Button button1, Button button2, Button buttonCombine, TextBox TextBoxMode, TextBox textBoxR, TextBox textBoxG, TextBox textBoxB)
        {
            if (State)
            {
                TextBoxMode.Text = "Random color mode";
                button1.Visible = true;
                button2.Visible = true;

                buttonCombine.Visible = false;
                textBoxR.Visible = false;
                textBoxG.Visible = false;
                textBoxB.Visible = false;



                State = false;
            }
            else
            {
                TextBoxMode.Text = "Write color mode";
                button1.Visible = false;
                button2.Visible = false;

                buttonCombine.Visible = true;
                textBoxR.Visible = true;
                textBoxG.Visible = true;
                textBoxB.Visible = true;


                State = true;
            }
        }
    }
}
