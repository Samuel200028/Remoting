using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProduct;

using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace DotNetRemoting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TcpServerChannel chanel = new TcpServerChannel(9999);
                ChannelServices.RegisterChannel(chanel, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(ProductServer),
                    "IProduct", WellKnownObjectMode.SingleCall);
                Console.WriteLine("Server's running...");
                Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Can't start server");
            }
        }
    }
}
