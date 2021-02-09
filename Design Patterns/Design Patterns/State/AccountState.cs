using System;

namespace Design_Patterns.State
{
    public abstract class AccountState
    {
        public abstract void PositiveBalance(BudgetState budgetState);
        public abstract void NegativeBalance(BudgetState budgetState);
        public abstract void DepositMoney(BudgetState budgetState, float Deposit);
        public abstract void WithdrawMoney(BudgetState budgetState, float Whithdraw);

        public void VerifyBalance(BudgetState budgetState)
        {
            if (budgetState.Balance <= 0)
            {
                Console.WriteLine("You are whith Negative Balance");
                budgetState.AccountState = new NegativeState();
            }
            else
            {
                budgetState.AccountState = new PositiveState();
                Console.WriteLine("You are whith Positive Balance");
            }
        }
    }



}
