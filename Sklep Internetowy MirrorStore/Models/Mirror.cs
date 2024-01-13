using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sklep_Internetowy_MirrorStore.Models
{
    public class Mirror
    {
        public string MirrorPicture { get; set; }
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        [Column(TypeName = "double")]
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
