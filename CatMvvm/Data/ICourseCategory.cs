using CatMvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatMvvm.Data
{
    public interface ICourseCategory
    {
        Task<List<CourseCategory>> ListAsync();
        Task<CourseCategory> GetAsync(int id);
        Task<CourseCategory> AddAsync(CourseCategory category);
        Task<CourseCategory> UpdateAsync(CourseCategory category);
        Task DeleteAsync(int id);
    }
}
