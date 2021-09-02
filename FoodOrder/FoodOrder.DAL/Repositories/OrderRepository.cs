using FoodOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FoodOrder.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private SqlConnection connection = null;
        private SqlCommand command;
        public OrderRepository()
        {
            connection = new SqlConnection(@"Data Source=SANTU\MSSQLSERVER2019;Initial Catalog=FoodOrder;Integrated Security=True");
        }
        public Order GetOrder(int Order_Id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Order order)
        {
            try
            {
                command = new SqlCommand("PlaceOrder", connection)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@OrderId", order.OrderId);
                command.Parameters.AddWithValue("@OrderName", order.Order_Name);
                command.Parameters.AddWithValue("@OrderDate", order.Order_Date);
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
