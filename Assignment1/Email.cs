using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Assignment1
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }



        private void sendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress(fromTxtBox.Text);
                mail.To.Add(toTxtB.Text);
                mail.Subject = titleTxtB.Text;
                mail.Body = bodyTextB.Text;
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(locationLbl.Text);
                mail.Attachments.Add(attachment);

                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(fromTxtBox.Text, passTxtBox.Text);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail has been successfully sent!", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            locationLbl.Text = openFileDialog1.FileName;
        }
    }
}
