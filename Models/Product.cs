namespace EFCore_CodeFirst.Models
{
    public class Product
    {
        public long ProductID
        {
            get; set;
        }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateofPurchase { get; set; }   
        public string AvailabilityStatus { get; set; }  
        public long? CategoryID { get; set; }
        public long? BrandId { get; set; }  
        public bool? Active { get; set; } 
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }

    }
}
