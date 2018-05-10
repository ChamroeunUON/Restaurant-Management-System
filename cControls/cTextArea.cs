using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WMS.components
{
    public class cTextArea : TextBox
    {
        // DATA MEMBERS
        private ErrorProvider error;
        // CONSTRUCTOR
        public cTextArea(){
            error = new ErrorProvider();
            AutoSize = false;
            base.Size = new Size(cConfig.TxtWidth, cConfig.TxtHeight);
            base.Font = new Font(cConfig.FontFamily, cConfig.FontSize);
            base.Multiline = true;
        }

        // METHODS
        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }
        // CHECK EMPTY TEXT AND SET ERROR PROVIDER
        public bool IsEmpty(string ErrorMessage)
        {
            if (String.IsNullOrEmpty(this.Text))
            {
                error.SetError(this, ErrorMessage);
                return true;
            }
            else
            {
                error.Clear();
                return false;
            }
        }
    }
}
