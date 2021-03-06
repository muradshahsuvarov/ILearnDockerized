using ILearnCoreV19.Areas.Identity.Data;
using Microsoft.AspNetCore.SignalR;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System.Threading.Tasks;

namespace ILearnCoreV19.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(ApplicationMessage message)
        {
            await Clients.All.SendAsync("receiveMessage", message);
        }


        public async Task CheckNotification()
        {
            await Clients.All.SendAsync("checkNotifs");
        }

    }
}
