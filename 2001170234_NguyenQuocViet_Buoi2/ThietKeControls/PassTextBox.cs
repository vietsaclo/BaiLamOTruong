using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class PassTextBox : TextBox
    {
        private ErrorProvider errP;

        public PassTextBox()
        {
            errP = new ErrorProvider();
            TextChanged += new System.EventHandler(PassTextBox_TextChanged2);
            //TextChanged += new System.EventHandler(PassTextBox_TextChanged);
        }

        void PassTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.Text.Length < 6 || !checkRegex(this.Text))
            {
                errP.SetError(this, "Hello");
            }
            else
            {
                errP.SetError(this, null);
            }
        }

        void PassTextBox_TextChanged2(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\s]");

            string text = Text;
            if (text.Length < 6)
                errP.SetError(this, "Not valid!");
            else
            {
                foreach (char c in text)
                {
                    if (regex.IsMatch(c.ToString()))
                    {
                        errP.Clear();
                        return;
                    }
                    errP.SetError(this, "Not valid!");
                }
            }
        }
        bool checkRegex(string text)
        {
            return text.Any(ch => !char.IsLetterOrDigit(ch));
        }
    }
}
