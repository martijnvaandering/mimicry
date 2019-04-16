using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;

namespace Mimicry.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new EmbeddedServer(new EFDefinitionLoader(new DefinitionContext("mimicry.db"))))
            {
                server.OnEnpointInvocation += (s, e) =>
                {
                    Console.WriteLine(e.MinicDefinition.RelativeEndpointUrl + " @ " + e.TimeStamp.ToShortTimeString() + " took: " + e.LoadTime.TotalSeconds);
                };
                Console.WriteLine("Server running @ " + server.BaseUrl);
                Console.ReadLine();
            }
        }
    }
}
