using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodOrder.Entities;
namespace FoodOrder.DAL.Repositories
{
   public interface IOrderRepository
    {
        void PlaceOrder(Order order);
        Order GetOrder(int Order_Id);
        List<Order> GetOrders();
    }
}
