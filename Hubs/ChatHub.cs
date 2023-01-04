using Microsoft.AspNetCore.SignalR;

namespace HIN_Ventures.Hubs
{

    
    using Microsoft.AspNetCore.SignalR;

    public class ChatHub : Hub
    {
        public async Task SendAssignment()//string customer, string title,
            //string description)

        {

            await Clients.All.SendAsync("ReceiveAssignments"); //, customer, title, description);
        }
    }

}

