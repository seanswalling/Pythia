using System;

namespace Pythia
{
    public class BusinessRequest : IRequest
    {
        private readonly Action<Business> _request;
        private readonly Business _business;

        public BusinessRequest(Action<Business> request, Business business)
        {
            _request = request;
            _business = business;
        }

        public void FulFill()
        {
            _request.Invoke(_business);
        }
    }
}
