using System;

namespace Design_Patterns.Observer
{
    public class PromotionSMS : ISubscribe
    {
        public void Action()
        {
            Console.Write(@"
Sending Promotion SMS...");
        }
    }
}