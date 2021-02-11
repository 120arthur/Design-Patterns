using System;

namespace Design_Patterns.Observer
{
    public class PromotionEmail : ISubscribe
    {
        public void Action()
        {
            Console.Write(@"
Sending Promotion Email...");
        }
    }
}