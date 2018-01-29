using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CWCommandLine
{
    class Program
    {
        private const string APIURL = "http://localhost:50660/";
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var messageFromApi = GetMessageFromAPI().Result;
            Console.WriteLine(messageFromApi);

            //Wait for Key press to give oppetunity to read the message from API
            Console.ReadLine();
        }
        private static async Task<string> GetMessageFromAPI()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            var stringTask = client.GetStringAsync($"{APIURL}/api/values");
            var msg = await stringTask;
            return msg;
        }
    }
}
