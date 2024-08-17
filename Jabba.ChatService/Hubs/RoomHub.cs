using Jabba.ChatService.Models;
using Microsoft.AspNetCore.SignalR;

namespace Jabba.ChatService.Hubs
{
    public class RoomHub : Hub
    {
        public async Task JoinRoom(UserConnection connection)
        {
            await Clients.All.SendAsync("ReceiveMessage", "admin", $"{connection.Username} has joined the room");
        }

        public async Task JoinSpecificRoom(UserConnection connection)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, connection.Room);

            await Clients.Group(connection.Room).SendAsync("ReceiveMessage", "admin", $"{connection.Username} has joined {connection.Room}");
        }
    }
}
