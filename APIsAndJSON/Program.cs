using System;
using System.Net.Http;
using KanyeAndRon;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            Quotes.KanyeQuote();

            Quotes.RonQuote();
            
        }
    }
}
