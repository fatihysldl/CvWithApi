using System.Collections.Generic;
using DtoLayer.Dtos.experienceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace cv.uı.Areas.User.Controllers
{
    public class UserExperienceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserExperienceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Area("User")]
        [HttpGet]
       
        public async Task <IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/experienceApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<experienceListDto>>(datas);
                return View(values);
            }
            return View();
        }
    }
}
