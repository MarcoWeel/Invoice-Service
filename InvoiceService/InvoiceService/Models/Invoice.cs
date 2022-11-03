using System.ComponentModel.DataAnnotations;

namespace InvoiceService.Models
{
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public int RequestedAmount { get; set; }
        public Material Material { get; set; }

    }
}
