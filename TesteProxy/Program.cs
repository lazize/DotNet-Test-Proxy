using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security;

namespace TesteProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (System.Net.WebClient client = new WebClient())
                {
                    // By default it will use proxy configured on config file.
                    // If you want to change it programatically, use it as below:
                    //----------------------------------------------------------------
                    //client.Proxy = new WebProxy("your.proxy.server", 3128);
                    //client.Proxy.Credentials = new NetworkCredential("USER_NAME", "USER_PASSWORD", "DOMAIN");

                    string result = client.DownloadString("http://www.google.com");
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadLine();
        }
    }
}
