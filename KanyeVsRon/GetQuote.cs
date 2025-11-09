using Newtonsoft.Json.Linq;

namespace KanyeVsRon;

public class GetQuote
{
    public static void GetKanyeQuote()
    {
        var client = new HttpClient();
        var kanyeUrl = "https://api.kanye.rest/";
        var kanyeResponseJson = client.GetStringAsync(kanyeUrl).Result;
        var kanyeQuote = JObject.Parse(kanyeResponseJson).GetValue("quote").ToString();
        Console.WriteLine($"Kanye: {kanyeQuote}");
    }

    public static void GetRonQuote()
    {
        var client = new HttpClient();
        var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes/";
        var ronResponseJson = client.GetStringAsync(ronUrl).Result;
        var ronQuote = JArray.Parse(ronResponseJson).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
        Console.WriteLine($"Ron: {ronQuote}");
    }
}