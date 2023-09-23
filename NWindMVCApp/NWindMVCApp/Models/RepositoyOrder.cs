using NWindMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace NWindMVCApp.Models
{
    public class RepositoyOrder
    {
        public NorthwindContext _context;
        public RepositoyOrder(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrder()
        {
            return (from o in _context.OrderDetails select o.OrderId).ToList();
        }
        public List<Order> GetOrders()
        {
            return _context.Orders.ToList();
        }
        public Order PutOrder(int id)
        {
            Console.WriteLine($"searching id: {id}");
            Order order = _context.Orders.Find(id);
            return order;
        }
        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }
        public Dictionary<int, string> GetallProductId()
        {
            return _context.Products.ToDictionary(x => x.ProductId, x => x.ProductName);
        }
    }
}
