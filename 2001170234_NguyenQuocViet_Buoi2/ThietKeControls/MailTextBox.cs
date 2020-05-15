using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThietKeControls
{
    public class MailTextBox:TextBox
    {
        private ErrorProvider errP;

        public MailTextBox()
        {
            errP = new ErrorProvider();
            TextChanged += MailTextBox_TextChanged;
        }

        void MailTextBox_TextChanged(object sender, EventArgs e)
        {
            string email = Text.ToLower();
            if (!email.Contains('@') || !email.Contains(".com"))
                errP.SetError(this, "Email is not valid!");
            else
                errP.Clear();
        }
    }
}