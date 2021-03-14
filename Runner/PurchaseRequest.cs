using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pythia
{
    public class PurchaseRequest : IRequest
    {
        public Person Person { get; }
        public Business Business { get; }
        public decimal Money { get; }

        public PurchaseRequest(Person person, Business business, decimal money)
        {
            Person = person;
            Business = business;
            Money = money;
        }

        public void FulFill()
        {
            Person.Buy(Business.Supply());
        }
    }
}
