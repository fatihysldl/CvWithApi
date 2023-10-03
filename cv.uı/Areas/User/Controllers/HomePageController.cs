using cv.uı.Models.about;
using cv.uı.Models.education;
using DtoLayer.Dtos.aboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace cv.uı.Areas.User.Controllers
{
    public class HomePageController : Controller
    {
       

        private readonly IHttpClientFactory _httpClientFactory;

        public HomePageController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        [HttpGet]
        [Area("User")]
        public async Task <IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/aboutApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<aboutListDto>>(datas);
                return View(values);
            }
            return View();
        }
    }
}
