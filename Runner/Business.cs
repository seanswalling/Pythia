using System.Collections.Generic;

namespace Pythia
{
    public class Business
    {
        private decimal _money;
        private readonly Queue<Good> _goods = new();
        
        public void DailySubsidy()
        {
            for (var i = 0; i < 100; i++)
            {
                _goods.Enqueue(new Good(1,1)); //TODO adjust price and utility
            }
        }

        public Good Supply()
        {
            var good = _goods.Dequeue();
            _money += good.Price;
            return good;
        }

        public void Purchase(PurchaseRequest purchase)
        {
            if (_goods.Count > 0 && _goods.Peek().Price <= purchase.Money)
                purchase.FulFill();
        }
    }
}