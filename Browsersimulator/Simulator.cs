using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browsersimulator
{
    internal class Simulator
    {
        public void Run()
        {
            while (true)
            {
                Console.Write("Geben Sie die gewünschte URL ein: ");
                string url = Console.ReadLine();
                if (url == "e")
                {
                    break;
                }
                BrowseURL(url);
            }
        }

        public void BrowseURL(string url)
        {
            Console.WriteLine($"Lade : {url}");
        }
    }
}
