using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class BudgetState
    {
        public float Balance { get; private set; }
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
}
