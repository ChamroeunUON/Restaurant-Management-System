using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS.components.MsgBox
{
    public partial class frmMsgBox : Form
    {
        // DATA MEMBERS
        bool _btnYesClicked = false;

        private MessageBoxButtons _messageBoxButtons;
        public frmMsgBox(string title, string message, MessageBoxButtons button, MessageBoxIcon msgIcon)
        {
            InitializeComponent();
            SetMessage(title, message, button, msgIcon);
            _messageBoxButtons = button;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // SET MESSAGE BOX INFORMATION
        private void SetMessage(string title, string message, MessageBoxButtons button, MessageBoxIcon msgIcon) {
            // SET MESSAGE TITLE
            this.Text = title;
            // SET MESSAGE INFO
            lbMsg.Text = message;
            // SET MESSAGE BUTTON
            foreach (Control c in Controls) {
                bool flag = c is Button;
                if (flag) {
                    c.Hide();
                }
            }
            switch (button) {
                case MessageBoxButtons.OK:
                    btnOk.Show();
                    break;
                case MessageBoxButtons.YesNo:
                    btnYes.Show();
                    btnNo.Show();
                    break;
            }
            // SET MESSAGE ICON
            bool flag1 = msgIcon == MessageBoxIcon.Information;
            if (flag1)
            {
                icon.Image = SystemIcons.Information.ToBitmap();
            }
            else {
                bool flag2 = msgIcon == MessageBoxIcon.Error;
                if (flag2)
                {
                    icon.Image = SystemIcons.Error.ToBitmap();
                }
                else{
                    bool flag3 = msgIcon == MessageBoxIcon.Warning;
                    if (flag3)
                    {
                        icon.Image = SystemIcons.Warning.ToBitmap();
                    }
                    else
                    {
                        bool flag4 = msgIcon == MessageBoxIcon.Asterisk;
                        if (flag4)
                        {
                            icon.Image = SystemIcons.Asterisk.ToBitmap();
                        }
                        else
                        {
                            bool flag5 = msgIcon == MessageBoxIcon.Question;
                            if (flag5)
                            {
                                icon.Image = SystemIcons.Question.ToBitmap();
                            }
                            else
                            {
                                bool flag6 = msgIcon == MessageBoxIcon.Hand;
                                if (flag6)
                                {
                                    icon.Image = SystemIcons.Hand.ToBitmap();
                                }
                                else
                                {
                                    bool flag7 = msgIcon == MessageBoxIcon.Exclamation;
                                    if (flag7)
                                    {
                                        icon.Image = SystemIcons.Exclamation.ToBitmap();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // MESSAGE SHOW DIALOG
        public bool Show() {
            base.ShowDialog();
            bool flag = _messageBoxButtons == MessageBoxButtons.YesNo;
            if (flag)
            {
                if (_btnYesClicked)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            else {
                return false;
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            _btnYesClicked = true;
            this.Close();
        }
    }
}
