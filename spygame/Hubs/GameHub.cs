using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace spygame.Hubs
{
    public class GameHub : Hub
    {
        Handlers.UserHandler userHandler = new Handlers.UserHandler();

        public override Task OnConnectedAsync()
        {
            userHandler.ConnectedPlayers.Add(Context.ConnectionId, "");
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            userHandler.ConnectedPlayers.Remove(Context.ConnectionId);
            return base.OnDisconnectedAsync(exception);
        }

        public Task AddPlayer(string playerName)
        {
            userHandler.ConnectedPlayers[Context.ConnectionId] = playerName;
            return Clients.All.InvokeAsync("DisplayPlayers", JsonConvert.SerializeObject(userHandler.ConnectedPlayers, Formatting.None));
        }

        public Task FetchVIP()
        {
            return Clients.All.InvokeAsync("DisplayVIP", JsonConvert.SerializeObject(userHandler.GetVIP(), Formatting.None));
        }

        //public Task FetchRoomCode(string connectionId)
        //{
        //    return Clients.Client(connectionId).InvokeAsync("DisplayRoomCode", JsonConvert.SerializeObject(this.Context.Connection.);

        //}

    }
}
