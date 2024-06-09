using System.Collections.Generic;
using Testing.Models;

namespace Testing.Repositories;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
}