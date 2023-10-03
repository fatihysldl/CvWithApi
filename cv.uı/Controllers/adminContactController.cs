using cv.uı.Models.contact;
using cv.uı.Models.education;
using DtoLayer.Dtos.contactDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace cv.uı.Controllers
{
    public class adminContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public adminContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7237/api/contactApi");
            if(responseMessage.IsSuccessStatusCode)
            {
                var datas=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<contactListDto>>(datas);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> updateContact(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7237/api/contactApi/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var datas = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<contactUpdateDto>(datas);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> updateContact(contactUpdateDto model)
        {
            var client = _httpClientFactory.CreateClient();
            var value = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(value, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7237/api/contactApi/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> deleteContact(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7237/api/contactApi/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }
    }
}
