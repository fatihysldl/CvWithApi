
using cv.uı.Models.project;
using DtoLayer.Dtos.experienceDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace cv.uı.Controllers
{
    public class adminExperienceController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminExperienceController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/experienceApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<experienceListDto>>(datas);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult addExperience()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> addExperience(experienceAddDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var datas = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(datas, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7237/api/experienceApi", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> updateExperience(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7237/api/experienceApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<experienceUpdateDto>(datas);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> updateExperience(experienceUpdateDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(value, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7237/api/experienceApi/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> deleteExperience(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7237/api/experienceApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
