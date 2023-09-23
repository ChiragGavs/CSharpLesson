using Microsoft.AspNetCore.Mvc;

namespace NWindMVCApp.Models
{
    public class RepositoryEmployee
    {
        public NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployee()
        {
            return _context.Employees.ToList();
        }

        public Product GetProductById(int productid)
        {
            return _context.Products.Find(productid);
       
        }
        public Dictionary<int, string> GetallProductId()
        {
            return _context.Products.ToDictionary(x => x.ProductId, x => x.ProductName);
        }
      
    }
}
