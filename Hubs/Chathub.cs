using Microsoft.AspNetCore.SignalR;
namespace simple_chat.Hubs
{
    //interface javas way of implements but using chathub so chat hub implements a hub interface
    public class ChatHub : Hub 
    {
        //async declarationn means the method can waits without blocking the thread so when await is used it will wait for the method to finish before moving on to the next line of code
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
