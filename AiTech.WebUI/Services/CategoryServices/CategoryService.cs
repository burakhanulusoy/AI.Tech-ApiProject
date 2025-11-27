using AiTech.WebUI.DTOs.CategoryDtos;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace AiTech.WebUI.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;

        public CategoryService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://localhost:7235/api/");
            _client = client;

        }

        public async Task CreateAsync(CreateCategoryDto categoryDto)
        {
          
           var json=JsonConvert.SerializeObject(categoryDto);

           var content = new StringContent(json, Encoding.UTF8, "application/json");
           
           await _client.PostAsync("categories",content);

        }

        public async Task DeleteAsync(int id)
        {

            await _client.DeleteAsync("categories/" + id);


        }

        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {

            var response = await _client.GetAsync("categories");//istek attık apiye

            if(!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori Listesi Alınamadı!");
               
            }

            var JsonContent=await response.Content.ReadAsStringAsync();//json formatı oluyor

            var desirailazeValue=JsonConvert.DeserializeObject<List<ResultCategoryDto>>(JsonContent);

            return desirailazeValue;


        }

        public async Task<UpdateCategoryDto> GetByIdAsync(int id)
        {

            var response = await _client.GetAsync("categories/" + id);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Kategori Listesi Alınamadı!");

            }

            var json=await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UpdateCategoryDto>(json);//null olabilir dediği için altı çiziyor
           



        }

        public async Task UpdateAsync(UpdateCategoryDto categoryDto)
        {
            
            var json=JsonConvert.SerializeObject(categoryDto);
            var content=new StringContent(json,Encoding.UTF8,"application/json");

            await _client.PutAsync("categories", content);





        }
    }
}
