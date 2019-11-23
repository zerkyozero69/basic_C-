using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestCODE_WAR
{
    class Class2
    {
        static void Main(string[] args)
        {
            string firstName = "แม้ว";
            string lastName = "ชินโนะสุเกะ";
            int age = 15;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            var fromAddress = new MailAddress("from@gmail.com", "From Name");
            var toAddress = new MailAddress("to@example.com", "To Name");
            const string fromPassword = "fromPassword";
            const string subject = "Subject";
            const string body = "Body";


            var smtp = new SmtpClient
            {
                Host = "http://www.nutrition-farm.nti.co.th/",
                Port = 587,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
                //{
                //    smtp.Send(message);
                //}


                Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
  //      public static int num (int[\] a){        
  //for (int i = 0; i<a.lenght; i++)
  //          {
  //   for (int j = a.lenght– 1; j > i; j–-)
  //          {

  //      if (a[\j] > a[\j - 1]){
  //         int b = a[\j];
  //      a[\j] = a[\j - 1];
  //         a[\j - 1] = b;
                
        

    }
}
