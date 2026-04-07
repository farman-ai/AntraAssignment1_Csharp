using System;

namespace App10_ParseURL
{
    public class Program
    {
        public static void Run()
        {
            Console.Write("Enter URL: ");
            string url = Console.ReadLine();

            string protocol = "";
            string server = "";
            string resource = "";

            int protocolIndex = url.IndexOf("://");
            if (protocolIndex != -1)
            {
                protocol = url.Substring(0, protocolIndex);
                url = url.Substring(protocolIndex + 3);
            }

            int resourceIndex = url.IndexOf("/");
            if (resourceIndex != -1)
            {
                server = url.Substring(0, resourceIndex);
                resource = url.Substring(resourceIndex + 1);
            }
            else
            {
                server = url;
            }

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
        }
    }
}