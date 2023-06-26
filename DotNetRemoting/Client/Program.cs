using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MyProduct;

using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChannelServices.RegisterChannel(new TcpClientChannel(), false);
                IProduct iproduct = (IProduct)(Activator.GetObject(typeof(IProduct),
                    "tcp://localhost:9999/IProduct"));
                Console.WriteLine("Informacion de Producto");

                Product product = iproduct.find();

                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Nombre: " + product.Name);
                Console.WriteLine("Precio: " + product.Price);

                foreach (Product p in iproduct.findAll())
                {
                    Console.WriteLine("Id: " + p.Id);
                    Console.WriteLine("Nombre: " + p.Name);
                    Console.WriteLine("Precio: " + p.Price);
                    Console.WriteLine("******************************************");
                }
                Console.ReadLine();

            }
            catch 
            {
                Console.WriteLine("Can't connect to server");
            }
        }
    }
}
