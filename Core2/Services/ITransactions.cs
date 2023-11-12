using Data.Entities;

namespace Core.Services
{
    public interface ITransactions
    {
        void CreateAccount(User loggedInUser);      
        void ProcessWithdrawal(User loggedInUser );
        void Deposit(User loggedInUser );
        void Transfer(User loggedInUser );

    }
}
