using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InvoiceService.Models
{
    public class Material
    {
        [Column(TypeName = "char(36)")]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockAmount { get; set; }
    }
}
