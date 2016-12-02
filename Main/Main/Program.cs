using HtmlAgilityPack;
using Main;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Enums;
using static Keyword;

namespace URLCategorize
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Write("Enter URL: ");
                    var input = Console.ReadLine();
                    var data = new Data();
                    var html = new HTML(input);
                    var results = new Result(html, data);
                    results.WriteResults();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }

        
    }

}