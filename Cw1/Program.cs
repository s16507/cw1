using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            //int tmp1 = 2;
            //double tmp2 = 2.0;
            //float tmp3 = 3.0f;

            //string tmp4 = "Ala ma kota";
            //bool tmp5 = true;
            //string tmp6 = "i psa";
            ////ctrl +k+c komentarz
            ////ctrl +k+u odkomentowanie
            //string path = @"c:\users\s16507\desktop\cw1";
            //Console.WriteLine($"{tmp4} {tmp6} {tmp1}");


            //var  newPerson = new Person { FirstName = "Kamil" };

            var url = "https://www.pja.edu.pl";

            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var htmlContent = await response.Content.ReadAsStringAsync();
                var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);

                var matches = regex.Matches(htmlContent);

                foreach (var match in matches)
                {
                    Console.WriteLine(match.ToString());
                }
            }

            



        }
    }
}
