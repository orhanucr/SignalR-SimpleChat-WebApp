using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mosas.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(String user, String message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
