using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;

namespace LAB_PP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            load();
            Console.Read();
        }

        public static async void load()
        {
            Console.WriteLine("Podaj datę [YYYY-MM-DD]: ");
            string date = Console.ReadLine();
            string call = "https://openexchangerates.org/api/historical/" + date + ".json?app_id=81c1723f53a04465aca559053eaa515a";
            HttpClient httpclient = new HttpClient();
            string json = await httpclient.GetStringAsync(call); 
            currency cur = JsonConvert.DeserializeObject<currency>(json);
            Console.WriteLine(cur.rates["PLN"]);
        }

    }

    class currency
    { 
        public string base_cur { set; get; }
        public Dictionary<string, double> rates { get; set; }
    }
}
