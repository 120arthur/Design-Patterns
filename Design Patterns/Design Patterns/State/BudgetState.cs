using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class BudgetState
    {
        public float Balance { get; set; }
        public AccountState AccountState { set; get; }

        public BudgetState(float accountBalance)
        {
            Balance = accountBalance;
            if(Balance <= 0)
            {
                AccountState = new NegativeState();
                AccountState.VerifyBalance(this);
            }
            else
            {
                AccountState = new PositiveState();
            }
        }

        public void DepositMoney(float Deposit)
        {
            AccountState.DepositMoney(this, Deposit);
        }

        public void WithdrawMoney(float Whithdraw)
        {
            AccountState.DepositMoney(this, Whithdraw);
        }

        public void PositiveBalance()
        {
            AccountState.PositiveBalance(this);
        }

        public void NegativeBalance()
        {
            AccountState.NegativeBalance(this);
        }
    }
}
