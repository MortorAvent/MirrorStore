namespace Sklep_Internetowy_MirrorStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int MirrorId { get; set; }
        public Mirror Mirror { get; set; }
        public int Quantity { get; set; }
    }
}
