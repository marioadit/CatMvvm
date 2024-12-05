using CatMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatMvvm.Data
{
    public class CourseCategoryRepository : ICourseCategory
    {
        private readonly HttpClient _httpClient;

        public CourseCategoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public Task<CourseCategory> AddAsync(CourseCategory category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCategory> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseCategory>> ListAsync()
        {
            //get data from http
            var response = await _httpClient.GetAsync($"{HttpHelper.BaseAddress}/api/v1/Categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<CourseCategory>>(content, 
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return categories ?? new List<CourseCategory>();
            }
            else
            {
                throw new ArgumentException("Failed to get data from server");
            }
        }

        public Task<CourseCategory> UpdateAsync(CourseCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
