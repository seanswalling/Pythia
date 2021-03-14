using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pythia
{
    public class Person
    {
        private decimal _money;
        private decimal _utility;
        
        private readonly Queue<Good> _goods = new();
        private decimal _dailyUtilityDecrease;
        private decimal _unitSatisfaction;

        public void DailySubsidy()
        {
            _money += 100;
        }

        public void NewDay()
        {
            _utility -= _dailyUtilityDecrease;
        }

        public void Consume()
        {
            while(_utility < _dailyUtilityDecrease)
            {
                var good = _goods.Dequeue();
                _utility += (good.BaseUtility * _unitSatisfaction);
            }
        }

        public void Buy(Good good)
        {
            _money -= good.Price;
            _goods.Enqueue(good);
        }


        public void PurchaseRejected()
        {
            
        }

        public void Process(EvaluateRequest req)
        {
            req.Dispatcher.Dispatch(new PurchaseRequest());
        }
    }
}
