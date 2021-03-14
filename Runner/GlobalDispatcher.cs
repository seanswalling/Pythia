using System;
using System.Collections.Generic;

namespace Pythia
{
    public class GlobalDispatcher
    {
        private readonly Queue<IRequest> _dispatchQueue = new();
        private readonly Dictionary<Type, RequestQueue<IRequest>> _lookup = new(); //Di this shit

        public void QueueForDispatch(IRequest request)
        {
            _dispatchQueue.Enqueue(request);
        }

        public void Dispatch()
        {
            var req = _dispatchQueue.Dequeue();
            _lookup[req.GetType()].QueueRequest(req);
        }
    }
}
