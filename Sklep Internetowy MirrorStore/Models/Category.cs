namespace Sklep_Internetowy_MirrorStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Mirror> Mirrrors { get; set; }
    }
}
