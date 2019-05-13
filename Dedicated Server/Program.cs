using DedicatedServerFramework.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicated_Server
{
    class Program
    {
       static ClientUpdateHandler myClient;
        static void Main(string[] args)
        {
            Program.myClient = new ClientUpdateHandler(333);
            while (true) ;
        }
    }
}
