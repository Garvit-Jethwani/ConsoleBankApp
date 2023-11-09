using Data.Enum;

namespace Data.Entities
{
    public class Account : BaseEntity
    {
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set;}
        public decimal AccountBalance { get; set;}
        public Guid UserID { get; set;}
    }
}
