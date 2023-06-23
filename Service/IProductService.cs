using FinanceTaskOne.Models;

namespace FinanceTaskOne.Service
{
    public interface IProductService
    {
        int AddProductItem(Products products);

        Products GetProductById(int id);

        int DeleteProductItem(Products products);

        Products EditProduct(int id);
        int UpdateProduct(Products products);

        List<Products> GetAllProducts();

        List<Category> GetCategoryName();

        //Products ProductData(int id);
    }
}
