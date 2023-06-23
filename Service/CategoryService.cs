using FinanceTaskOne.Models;
using FinanceTaskOne.Repository;

namespace FinanceTaskOne.Service
{
    public class CategoryService : ICategoryService
    {
        readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public int AddCategoryItem(Category category)
        {
            return _categoryRepository.AddCategoryItem(category);
        }

        public int DeleteCategoryItem(Category category)
        {
            return _categoryRepository.DeleteCategoryItem(category);
        }

        public Category EditCategory(int id)
        {
            return _categoryRepository.EditCategory(id);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAllCategories();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetCategoryById(id); 
        }

        public int UpdateCategory(Category category)
        {
            return _categoryRepository.UpdateCategory(category);
        }
    }
}
