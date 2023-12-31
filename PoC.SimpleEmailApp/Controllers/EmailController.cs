﻿using Microsoft.AspNetCore.Mvc;
using PoC.SimpleEmailApp.Models;
using PoC.SimpleEmailApp.Services.EmailService;

namespace PoC.SimpleEmailApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;
    public EmailController(IEmailService emailService) 
    {
        _emailService = emailService;
    }
    [HttpPost]
    public IActionResult SendEmail(EmailDto request)
    {     
        _emailService.SendEmail(request);
        return Ok();
    } 
}
