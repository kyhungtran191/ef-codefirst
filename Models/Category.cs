namespace EFCore_CodeFirst.Models
{
    public class Category
    {
        [Key]
        public long CategoryID {
            get; set;
        }
        public string CategoryName { get; set; }
    }
}
