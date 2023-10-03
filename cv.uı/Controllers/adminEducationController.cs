using cv.uı.Models.contact;
using cv.uı.Models.project;
using cv.uı.Models.education;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using DtoLayer.Dtos.contactDto;
using DtoLayer.Dtos.educationDto;

namespace cv.uı.Controllers
{
    public class adminEducationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminEducationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/educationApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<educationListDto>>(datas);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult addToEducation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> addToEducation(educationAddDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var datas = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(datas, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7237/api/educationApi", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> updateEducation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7237/api/educationApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<educationUpdateDto>(datas);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> updateEducation(educationUpdateDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(value, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7237/api/educationApi/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

     
        public async Task<IActionResult> deleteEducation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7237/api/educationApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
