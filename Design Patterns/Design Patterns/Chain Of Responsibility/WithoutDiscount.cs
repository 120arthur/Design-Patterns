using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Chain_Of_Responsibility
{
    public class WithoutDiscount : Discont
    {
        public Discont NextVerification { get; set; }

        public float DiscountValue(BudgetDiscount budget)
        {
            return 0;
        }
    }

}
