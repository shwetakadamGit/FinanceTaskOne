using FinanceTaskOne.Models;
using FinanceTaskOne.Repository;

namespace FinanceTaskOne.Service
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public int AddProductItem(Products products)
        {
            return _productRepository.AddProductItem(products);
        }
        
        public int DeleteProductItem(Products products)
        {
            return _productRepository.DeleteProductItem(products);
        }

        public Products EditProduct(int id)
        {
            return _productRepository.EditProduct(id);
        }

        public List<Products> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public List<Category> GetCategoryName()
        {
            return _productRepository.GetCategoryName();
        }

        public Products GetProductById(int id)
        {
           return _productRepository.GetProductById(id);
        }

        public int UpdateProduct(Products products)
        {
            return _productRepository.UpdateProduct(products);
        }
    }
}
