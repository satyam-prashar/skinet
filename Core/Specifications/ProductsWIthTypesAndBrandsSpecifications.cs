using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWIthTypesAndBrandsSpecifications : BaseSpecification<Product>
    {
        public ProductsWIthTypesAndBrandsSpecifications()
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductsWIthTypesAndBrandsSpecifications(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}