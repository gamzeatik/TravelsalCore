using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TravelsalCore.Models;

namespace TravelsalCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Route("Admin/Index")]
    [Authorize(Roles = "Admin")]

    public class MailController : Controller
    {
        //[Route("")]
        //[Route("Index")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        //[Route("Index")]
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "gamze.atik.santsg@gmail.com");//name - sender mail
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("gamze.atik.santsg@gmail.com", "eujofnghsbumyacw");//gmail app pass alanindan olusturdugum sifre //sender mail
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);
            return View();
        }
    }
}
//gamze.atik.santsg@gmail.com