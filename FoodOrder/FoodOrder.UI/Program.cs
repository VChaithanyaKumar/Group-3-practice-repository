using System;
using FoodOrder.BAL;
using FoodOrder.Entities;
namespace FoodOrder.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                OrderService orderService = new OrderService();
                orderService.PlaceOrder(new Order()
                {
                    OrderId = 12345,
                    Order_Name = "Pizza",
                    Order_Date = DateTime.Now
                });
            }
            catch (Exception ex)
            {

                //Add exception details to errlog.txt file.
                string content = string.Format($"Error Message:{ex.Message} Date:{DateTime.Now} Class:Programe");
                //add contet to errlog.txt file using streamwriter.
            }
            Console.ReadKey();
        }
    }
}
