using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Shared.Dtos;

namespace FreeCourse.Services.Catalog.Services
{
    public interface ICategoryService
    {
        public Task<Response<List<CategoryDto>>> GetAllAsync();

        public Task<Response<CategoryDto>> CreateAsync(CategoryDto category);

        public Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
