using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SignalR;
using SignalR.Hubs;

namespace SignalRDemo.Hubs
{
    public class DemoHub : Hub
    {

        public DemoHub()
        {

        }

        public void Send(string message)
        {
            Clients.updatePage(message);
        }
    }
}