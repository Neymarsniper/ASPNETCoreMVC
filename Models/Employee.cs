namespace ASP_Core_Empty.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Married { get; set; }
        public MyEnum Gender { get; set; }
        public string Description { get; set; }
    }
    public enum MyEnum
    {
        Male, Female
    }
}
