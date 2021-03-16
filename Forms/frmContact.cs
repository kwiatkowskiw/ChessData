using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class frmContact : Form
    {
        public frmContact()
        {
            InitializeComponent();
            adminTxt.Text = "kwiatkowskiww@gmail.com";
            password.PasswordChar = '*';
        }

        private void bt_sendmail_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = userTxt.Text,
                    Password = password.Text
                }
            };
            MailAddress FromEmail = new MailAddress(userTxt.Text, userTxt.Text);
            MailAddress ToEmail = new MailAddress(adminTxt.Text, "Admin");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = subjectTxt.Text,
                Body = messageTxt.Text,
                IsBodyHtml = true
            };
            Message.To.Add(ToEmail);
            try
            {
                smtpClient.Send(Message);
                status.Text = "Email has been successfully sent to ";
                status.ForeColor = Color.Green;
            }
            catch
            {
                status.Text = "Email has not been successfully sent to ";
                status.ForeColor = Color.Red;
            }
        }
    }
}
