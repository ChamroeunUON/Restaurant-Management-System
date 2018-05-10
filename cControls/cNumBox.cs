using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WMS.components
{
    public class cNumBox : TextBox
    {
        // DATA MEMBERS
        private ErrorProvider error;
        // CONSTRUCTOR
        public cNumBox()
        {
            error = new ErrorProvider();
            AutoSize = false;
            base.Size = new Size(cConfig.TxtWidth, cConfig.TxtHeight);
            base.Font = new Font(cConfig.FontFamily, cConfig.FontSize);
        }

        // METHODS
        public override bool AutoSize { get { return base.AutoSize; } set { base.AutoSize = value; } }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (( this as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

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
