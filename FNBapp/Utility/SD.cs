using FNBapp.Data;

namespace FNBapp.Utility
{
    public static class SD


    {
        public static string Role_Admin = "Admin";
        public static string Role_Customer = "Customer";
        public static string Role_Employee = "Employee";
        public static string Role_StoreManager = "StoreManager";
        public static string Role_Waiter = "Waiter";

        public static string StatusPending = "Pending";
        public static string StatusReadyForPickUp = "ReadyForPickUp";
        public static string StatusCompleted = "Completed";
        public static string StatusCancelled = "Cancelled";
        public static string StatusNotAvailable = "NotAvailable";

        public static List<OrderDetail> ConvertShoppingCartListToOrderDetail(List<ShoppingCart> shoppingCarts)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach(var cart in shoppingCarts)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    ProductId = cart.ProductId,
                    Count = cart.Count,
                    Price = Convert.ToDouble(cart.Product.Price),
                    ProductName = cart.Product.Name
                };
                orderDetails.Add(orderDetail);
            }
            return orderDetails;
        }
    }
}
