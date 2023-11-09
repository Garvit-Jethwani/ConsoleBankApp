namespace Data.Entities
{
    public class User : BaseEntity
    {
        public string FullName {get; set;}
        public string Email { get; set;}
        public string PassWord { get; set;}
    }
}
