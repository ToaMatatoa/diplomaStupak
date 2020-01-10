using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Diploma.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;


namespace Diploma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("DmitriyStupak", "rikonikotako@gmail.com"));
            message.To.Add(new MailboxAddress("DmitriyStupak", "rikonikotako@gmail.com"));
            message.Subject = "Hi there!";
            message.Body = new TextPart("plain")
            {
                Text = "do you know about this?"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate("rikonikotako@gmail.com", "some pass");

                client.Send(message);

                client.Disconnect(true);
            }
            return View();
        }

        public IActionResult About()
        {

            return View();
        }

        public IActionResult Help()
        {

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

