using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using System.Text.Json;
using TwoibiCSharpDevChallengeByHeltonFurau.Models;
using TwoibiCSharpDevChallengeByHeltonFurau.Models;

namespace TwoibiCSharpDevChallengeByHeltonFurau.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly HttpClient client = new HttpClient();
        private static async Task<List<Country>> ProcessCountries()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var streamCountry = client.GetStreamAsync("https://restcountries.com/v3.1/all");
            var countries = await JsonSerializer.DeserializeAsync<List<Country>>(await streamCountry);

            return countries;

        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var countries = await ProcessCountries();
            return View(countries);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}