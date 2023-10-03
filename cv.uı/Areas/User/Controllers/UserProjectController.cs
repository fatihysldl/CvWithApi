using cv.uı.Models.project;
using DtoLayer.Dtos.projectDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace cv.uı.Areas.User.Controllers
{
    public class UserProjectController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public UserProjectController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Area("User")]
        [HttpGet]

        public async Task<IActionResult> Index()
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/projectApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas= await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<List<projectListDto>>(datas);
                return View(values);
            }
            return View();
        }
    }
}
