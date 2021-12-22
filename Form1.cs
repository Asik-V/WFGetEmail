using MailKit;
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using MailKit.Net.Imap;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WFGetEmail
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate("vladasekretov@gmail.com", "AsikV2003");
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                for (int i = 0; i < 5; i++)
                {
                    headingListBox.Items.Add(inbox.GetMessage(i).Subject);
                }
            }
        }


        private void headingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ImapClient client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate("vladasekretov@gmail.com", "AsikV2003");
                IMailFolder inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                this.contentTextBox.Text = inbox.GetMessage(this.headingListBox.SelectedIndex).TextBody;
            }
        }

    }
}
