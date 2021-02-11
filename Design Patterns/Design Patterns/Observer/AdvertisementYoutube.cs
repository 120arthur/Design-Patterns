using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Observer
{

    public class AdvertisementYoutube : ISubscribe
    {
        public void Action()
        {
            Console.Write(@"
Sending Promotion SMS...");
        }
    }
}