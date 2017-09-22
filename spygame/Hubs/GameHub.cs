using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spygame.Hubs
{
    public class GameHub : Hub
    {
        public Task Start(string message)
        {
            return Clients.All.InvokeAsync("Start", message);
        }
    }
}
