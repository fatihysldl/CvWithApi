using cv.uı.Models.project;
using DtoLayer.Dtos.projectDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.Text;

namespace cv.uı.Controllers
{
    public class adminProjectController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminProjectController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/projectApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<projectListDto>>(datas);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult addProject()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> addProject(projectAddDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var datas = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(datas, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7237/api/projectApi", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]   
        public async Task<IActionResult> updateProject(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7237/api/projectApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<projectUpdateDto>(datas);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> updateProject(projectUpdateDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(value, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7237/api/projectApi/",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> deleteProject(int id)
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7237/api/projectApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
