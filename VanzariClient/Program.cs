using System;
using System.Collections.Generic;
using System.Linq;
using Grpc.Core;
using System.Windows.Forms;
using VanzariClient.Controllers;

namespace VanzariClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Channel channel = new Channel("127.0.0.1:3001", ChannelCredentials.Insecure);
            var client = new VanzariService.Service.ServiceClient(channel);
            VanzariProxy service = new VanzariProxy(client);
            LogInController controller = new LogInController(service);
            Application.Run(new LogIn(controller));
        }
    }
}
