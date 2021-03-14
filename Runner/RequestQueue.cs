using System.Collections.Generic;

namespace Pythia
{
    public class RequestQueue<T> where T : IRequest
    {
        private readonly Queue<T> _queue = new();

        public void Process()
        {
            _queue.Dequeue().Dispatch();
        }

        public void QueueRequest(T request)
        {
            _queue.Enqueue(request);
        }
    }
}