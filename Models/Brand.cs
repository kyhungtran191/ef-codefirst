using System.ComponentModel.DataAnnotations;

namespace EFCore_CodeFirst.Models
{
    public class Brand
    {
        [Key]
        public long BrandId { get; set; }   
        public string BrandName { get; set; }   
    }
}
