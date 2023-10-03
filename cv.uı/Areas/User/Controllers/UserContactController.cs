using cv.uı.Models.contact;
using cv.uı.Models.education;
using DtoLayer.Dtos.contactDto;
using DtoLayer.Dtos.experienceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace cv.uı.Areas.User.Controllers
{
    public class UserContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Area("User")]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/contactApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<contactListDto>>(datas);
                return View(values);
            }
            return View();
        }

    }
}
