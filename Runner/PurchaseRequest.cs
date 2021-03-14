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

        public void Dispatch()
        {
            Business.Process(this);
        }

        public void FulFill()
        {
            Person.Buy(Business.Supply());
        }

        public void Reject()
        {
            Person.PurchaseRejected();
        }
    }
}
