using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentEmail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("namgoku235@gmail.com");
                mail.To.Add(recipientEmail);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port =587;
                SmtpServer.Credentials = new NetworkCredential("namgoku235@gmail.com", "01668462570");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }
        private string GenerateVerificationCode()
        {
            // Tạo mã xác nhận ngẫu nhiên (ví dụ: một chuỗi số có độ dài 6)
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int otp;
        Random random = new Random();
        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            #region 
            /*
            // Lấy email của người dùng từ TextBox
            string recipientEmail = "doantuannam2206.sp@gmail.com";

            // Tạo mã xác nhận (có thể sử dụng thuật toán tạo mã xác nhận ngẫu nhiên)
            string verificationCode = GenerateVerificationCode();

            // Gửi email chứa mã xác nhận
            SendEmail(recipientEmail, "Verification Code", "Your verification code is: " + verificationCode);
            */
            #endregion

            try
            {
                otp = random.Next(100, 1000);

                var fromAddress = new MailAddress("namgoku235@gmail.com");// mail dùng để gửi mã otp 
                var toAddress = new MailAddress("doantuannam2206.sp@gmail.com"); // mail dùng để nhận mã otp 


                const string frompass = "putm xvul wdxi cdpp";
                const string subject = "OTP code";
                string body = otp.ToString();

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, frompass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Otp đã được gửi qua mail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
    }
}
