using DemoAcculynx.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DemoAcculynx.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Items( string tag)
        {
            Root reservationList = new Root();
            HttpClientHandler handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (var httpClient = new HttpClient(handler))
            {

                var apiUrl = ("https://api.stackexchange.com/2.3/questions?fromdate=1598832000&order=desc&sort=activity&tagged=" + tag + "&site=stackoverflow&filter=!m6Wy7AN10y(E0TV5Yo_nHoqJ20Cfn6aVpiS(pp-2rJ4LZaSp.x0D45Te");

                //setup HttpClient
                httpClient.BaseAddress = new Uri(apiUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //make request
                var response = await httpClient.GetStringAsync(apiUrl);
                reservationList = JsonConvert.DeserializeObject<Root>(response);

            }




            return View(reservationList.items);
        }


        public async Task<ActionResult> Question(string tag)
        {
            Root reservationList = new Root();
            HttpClientHandler handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (var httpClient = new HttpClient(handler))
            {

                
                var apiUrl = ("https://api.stackexchange.com/2.3/questions?fromdate=1630346919&order=desc&sort=activity&tagged=" + tag + "&site=stackoverflow&filter=!0Wd8xO54ur4PONC.sD0EZf13v");

                //setup HttpClient
                httpClient.BaseAddress = new Uri(apiUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //make request
                var response = await httpClient.GetStringAsync(apiUrl);
                reservationList = JsonConvert.DeserializeObject<Root>(response);

            }




            return View(reservationList.items);
        }
        public async Task<ActionResult> Guess(int id)
        {
            //looking from where to get the question id
            Root reservationList = new Root();
            HttpClientHandler handler = new HttpClientHandler();
            handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (var httpClient = new HttpClient(handler))
            {


                var apiUrl = ("https://api.stackexchange.com/2.3/questions?fromdate=1630346919&order=desc&sort=activity&tagged=&site=stackoverflow&filter=!0Wd8xO54ur4PONC.sD0EZf13v");

                //setup HttpClient
                httpClient.BaseAddress = new Uri(apiUrl);
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //make request
                var response = await httpClient.GetStringAsync(apiUrl);
                reservationList = JsonConvert.DeserializeObject<Root>(response);

            }




            return View(reservationList.items);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Overall Goal.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}