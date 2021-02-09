using System;

namespace Design_Patterns.State
{
    public class PositiveState : AccountState
    {
        public override void DepositMoney(BudgetState budgetState, float Deposit)
        {
            budgetState.Balance += Deposit * 0.98f;
            VerifyBalance(budgetState);
        }

        public override void WithdrawMoney(BudgetState budgetState, float Whithdraw)
        {
            if (Whithdraw <= budgetState.Balance)
            {
                budgetState.Balance -= Whithdraw;
                VerifyBalance(budgetState);
                return;
            }

            throw new Exception("You Don't have this money");
        }

        public override void NegativeBalance(BudgetState budgetState)
        {
            budgetState.AccountState = new NegativeState();
        }

        public override void PositiveBalance(BudgetState budgetState)
        {
            throw new Exception("You are With the positive Balance");
        }

    }



}
