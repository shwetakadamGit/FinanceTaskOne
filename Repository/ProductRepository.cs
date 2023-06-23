using FinanceTaskOne.Context;
using FinanceTaskOne.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceTaskOne.Repository
{
    public class ProductRepository : IProductRepository
    {
        readonly ApplicationDbContext _applicationDbContext;
        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public int AddProductItem(Products products)
        {
            _applicationDbContext.MasterTbl_Products.Add(products);
            return _applicationDbContext.SaveChanges();
        }

        public int DeleteProductItem(Products products)
        {
            _applicationDbContext.MasterTbl_Products.Remove(products);
            return _applicationDbContext.SaveChanges();
        }

        public Products EditProduct(int id)
        {
            return _applicationDbContext.MasterTbl_Products.Include(c => c.Category).SingleOrDefault(p => p.ProductId == id);
        }

        public List<Products> GetAllProducts()
        {
            return _applicationDbContext.MasterTbl_Products.Include(c =>c.Category).ToList();
        }

        public List<Category> GetCategoryName()
        {
            return _applicationDbContext.MasterTbl_Category.ToList();
        }

        public Products GetProductById(int id)
        {
            //return _applicationDbContext.MasterTbl_Products.Include(p => p.ProductId).SingleOrDefault(c => c.ProductId == id);
            return _applicationDbContext.MasterTbl_Products.Include(cat => cat.Category).SingleOrDefault(p => p.ProductId == id);
        }

        public int UpdateProduct(Products products)
        {
            _applicationDbContext.MasterTbl_Products.Update(products);
            return _applicationDbContext.SaveChanges();
        }
    }
}
