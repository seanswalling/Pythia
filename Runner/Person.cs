using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Pythia
{
    public class Person
    {
        public decimal Money { get; set; }
        public decimal Utility { get; set; }
        public decimal UnitSatisfaction { get; set; }
        private readonly Queue<Good> _goods = new();
        private decimal _dailyUtilityDecrease;

        public void DailySubsidy()
        {
            Money += 100;
        }

        public void NewDay()
        {
            Utility -= _dailyUtilityDecrease;
        }

        public void Consume()
        {
            while(Utility < _dailyUtilityDecrease)
            {
                var good = _goods.Dequeue();
                Utility += (good.BaseUtility * UnitSatisfaction);
            }
        }

        public void Buy(Good good)
        {
            Money -= good.Price;
            _goods.Enqueue(good);
        }
    }
}
