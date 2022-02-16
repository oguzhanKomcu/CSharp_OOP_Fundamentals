using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_And_Exception
{
    public class Has_A_Letter : ApplicationException //We inherited from a class embedded in the system. It also inherited from the exception class.
    {


        public string Text { get; set; }

        //Constructor method
        public Has_A_Letter(string id)
        {

            this.Text = id;

            //The delegate is a class. Here I specify which methods should be triggered first to the constructor method of my class.
            Logger logger = new Logger(MailLogger); 
            logger += Dblog;//I'm adding it to the queue so that it does my other method.

            logger.Invoke("error received");




        }


        public override string Message => "Letters cannot be included in the ID...!!";

        public delegate void Logger(string message);

        public void MailLogger(string message)
        {

            //You can apply this email sending code to send email when an error is received. For this, you must first make certain settings in your gmail. Otherwise, your code will give an error.
            //https://myaccount.google.com/security?rapt=AEjHL4NOCatvDtXaHmNXuN5T2inpt98nUnGr6_eoGWjJjloVaf0kV8Bxn1KZKWDCx6dvOqYVjCRkvO-OkNPRxHM5_W2dv8KwtQ //You need to turn on "Less secure app access" and turn off 2-step verification.

            SmtpClient smtpClient = new SmtpClient(); 
            MailMessage mail = new MailMessage();
            smtpClient.Credentials = new NetworkCredential("emailname@gmail.com", "password");
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            mail.To.Add("emailname@gmail.com"); //Email address to send the error to.
            mail.From = new MailAddress("emailname@gmail.com"); //sender email address
            mail.Subject = $"DATE : {DateTime.Now}  CODE ERROR"; //mail header
            mail.Body =$"Error : {Message}" + System.Environment.MachineName.ToString(); //mail content..


            smtpClient.Send(mail);
        }

         public void Dblog(string message)
         {

            //I am a method to be used to write the exception error we receive in the program to the "Log.txt" file and read it when necessary.
            string folderPath = Application.StartupPath + @"\log.txt"; //I created "Log.txt" inside the file where my project is located.


            //I am assigning the incoming values ​​to my variables.

            DateTime exceptionDate = DateTime.Now;
            string exceptionMessage = this.Message;
            string userText = this.Text;
            string createdBy = Environment.MachineName;



            StreamWriter streamWriter = new StreamWriter(folderPath, true, Encoding.UTF8);


            StringBuilder sb = new StringBuilder();

            sb.Append(userText);
            sb.Append("|");
            sb.Append(exceptionMessage);
            sb.Append("|");
            sb.Append(exceptionDate);
            sb.Append("|");
            sb.Append(createdBy);

            streamWriter.WriteLine(sb.ToString());
            streamWriter.Close();

        }
    }
}
