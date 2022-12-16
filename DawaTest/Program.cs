using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace DawaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apiref = "adresser?struktur=mini&id=0a3f50c0-ee7e-32b8-e044-0003ba298018";
            using (HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://api.dataforsyningen.dk/")
            })
            {
                try
                {
                    var response = client.GetAsync(apiref).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(result);
                    Console.ReadLine();
                }
                catch (Exception err)
                {
                    Console.WriteLine(err);
                    Console.ReadLine();
                }
            }

            
        }
    }
}
