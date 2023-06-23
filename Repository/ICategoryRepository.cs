    using FinanceTaskOne.Models;

namespace FinanceTaskOne.Repository
{
    public interface ICategoryRepository
    {
        int AddCategoryItem(Category category);

        Category GetCategoryById(int id);
        int DeleteCategoryItem(Category category);

        Category EditCategory(int id);
        int UpdateCategory(Category category);

        List<Category> GetAllCategories();  
    }
}
