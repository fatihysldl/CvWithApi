using cv.uı.Models.about;
using cv.uı.Models.education;
using DtoLayer.Dtos.aboutDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace cv.uı.Controllers
{
    public class adminAboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminAboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/aboutApi");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas =await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<aboutListDto>>(datas);
                return View(values);
            }
            return View();
        }

        
        public async Task<IActionResult> deleteAbout(int id)
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7237/api/aboutApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task< IActionResult> updateAbout(int id)
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage=await client.GetAsync($"https://localhost:7237/api/aboutApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<aboutUpdateDto>(datas);
                return View(values);
            }
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> updateAbout(aboutUpdateDto model)
        {
            var client=_httpClientFactory.CreateClient();
            var data = JsonConvert.SerializeObject(model);
            StringContent content=new StringContent(data, Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("https://localhost:7237/api/aboutApi/",content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult addAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> addAbout(aboutListDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var datas = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(datas, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7237/api/aboutApi", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
