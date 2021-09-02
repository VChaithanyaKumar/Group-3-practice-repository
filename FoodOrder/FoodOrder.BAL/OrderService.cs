using System;
using FoodOrder.DAL.Repositories;
using FoodOrder.Entities;
using FoodOrder.BAL.Validations;
namespace FoodOrder.BAL
{
    public class OrderService
    {
        private OrderRepository repository = null;
        public OrderService()
        {
            repository = new OrderRepository();
        }
        public void PlaceOrder(Order order)
        {
            bool IsValid=OrderValidations.ValiDateOrderName(order.Order_Name);
            if (IsValid)
            {
                repository.PlaceOrder(order); //invoike PlaceOrder() from DAL project
            }
            else
            {

            }
            
        }
    }
}
