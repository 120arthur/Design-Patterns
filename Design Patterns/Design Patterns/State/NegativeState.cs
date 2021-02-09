using System;

namespace Design_Patterns.State
{
    public class NegativeState : AccountState
    {
        public override void DepositMoney(BudgetState budgetState, float Deposit)
        {
            budgetState.Balance += Deposit * 0.95f;
            VerifyBalance(budgetState);
        }

        public override void WithdrawMoney(BudgetState budgetState, float Whithdraw)
        {
            throw new Exception("You can't withdraw maney"); 
        }

        public override void NegativeBalance(BudgetState budgetState)
        {
            VerifyBalance(budgetState);
        }

        public override void PositiveBalance(BudgetState budgetState)
        {
            budgetState.AccountState = new PositiveState();
        }

    }

}
