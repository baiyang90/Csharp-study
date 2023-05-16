using System.Net.Http;

namespace ConsoleApp1
{
    internal class Program
    {


        static async Task Main(string[] args)
        {

            //Console.WriteLine("ssss");
            //await Testasync();
            //Console.WriteLine("bbbbb");
            await Gethttpstring(@"http://www.baidu.com", @"c:\by\baidu.txt");
            Console.WriteLine("123");
        }

        public static Task Testasync()
        {
            Thread.Sleep(1000);
            Console.WriteLine("这是等待1s得方法");
            return Task.CompletedTask;
        }
        public static async Task Gethttpstring(string url, string filename)
        {
            //HttpClientFactory factory = new HttpClientFactory();
            using(HttpClient client = new HttpClient())
            {
                string s = await client.GetStringAsync(url);
                await File.WriteAllTextAsync(filename, s);
            }
                
        }

    }


}