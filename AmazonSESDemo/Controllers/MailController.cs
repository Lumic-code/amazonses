using AmazonSESDemo.Models;
using AmazonSESDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmazonSESDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("send-email")]
        public async Task<IActionResult> SendMail(MailRequest request)
        {
            await _mailService.SendEmailAsync(request);
            return Ok();
        }
    }
}
