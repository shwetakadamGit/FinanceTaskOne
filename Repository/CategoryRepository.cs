
using FinanceTaskOne.Context;
using FinanceTaskOne.Models;

namespace FinanceTaskOne.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public int AddCategoryItem(Category category)
        {
            _applicationDbContext.MasterTbl_Category.Add(category);
            return _applicationDbContext.SaveChanges();
        }

        public int DeleteCategoryItem(Category category)
        {
            _applicationDbContext.MasterTbl_Category.Remove(category);
            return _applicationDbContext.SaveChanges();
        }

        public Category EditCategory(int id)
        {
            return _applicationDbContext.MasterTbl_Category.Find(id);
        }

        public List<Category> GetAllCategories()
        {
            return _applicationDbContext.MasterTbl_Category.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _applicationDbContext.MasterTbl_Category.Find(id);
        }

        public int UpdateCategory(Category category)
        {
            _applicationDbContext.MasterTbl_Category.Update(category);
            return _applicationDbContext.SaveChanges();
        }
    }
}
