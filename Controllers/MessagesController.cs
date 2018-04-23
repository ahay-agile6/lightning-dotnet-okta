using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using lightning_dotnet_okta.Models;

[Authorize]
[Route("/api")]
public class MessagesController : Controller
{
    [HttpGet]
    [Route("messages")]    
    public IEnumerable<Message> GetPrivateMessages()
    {
        var login = User.Claims
            .SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)
            ?.Value;

        var messages = new List<Message>();
        messages.Add(new Message(DateTime.Now, "This message is from lightning-dotnet-okta"));

        return messages;
    }
}