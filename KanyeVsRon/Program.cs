using KanyeVsRon;
using Newtonsoft.Json.Linq;

for (int i = 0; i < 5; i++)
{
    GetQuote.GetKanyeQuote();
    Thread.Sleep(1000);
    GetQuote.GetRonQuote();
    Thread.Sleep(1000);
}

