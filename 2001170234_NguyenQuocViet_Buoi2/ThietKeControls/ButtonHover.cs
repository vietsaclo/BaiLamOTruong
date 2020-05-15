using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ThietKeControls
{
    public class ButtonHover : Button
    {
        private Color colorStock;

        public ButtonHover()
        {
            colorStock = BackColor;
            Cursor = Cursors.Hand;
            MouseMove += ButtonHover_MouseMove;
            MouseLeave += ButtonHover_MouseLeave;
            //MouseHover += ButtonHover_MouseHover;
        }

        void ButtonHover_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.LightBlue;
        }

        void ButtonHover_MouseLeave(object sender, EventArgs e)
        {
            BackColor = colorStock;
        }

        void ButtonHover_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightBlue;
        }
    }
}
