using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace spygame.Hubs
{
    public class GameHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Handlers.UserHandler.ConnectedPlayers.Add(Context.ConnectionId, "");
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            Handlers.UserHandler.ConnectedPlayers.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

        public Task AddPlayer(string playerName)
        {
            Handlers.UserHandler.ConnectedPlayers[Context.ConnectionId] = playerName;
            return Clients.All.InvokeAsync("DisplayPlayers", JsonConvert.SerializeObject(Handlers.UserHandler.ConnectedPlayers, Formatting.Indented));
        }

        //public Task Start()
        //{
        //}
    }
}
