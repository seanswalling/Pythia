using System.Collections.Generic;

namespace Pythia
{
    public class RequestQueue<T> where T : IRequest
    {
        public Queue<T> Queue { get; set; }

        public void Process()
        {
            Queue.Dequeue().FulFill();
        }

        public void QueueRequest(T request)
        {
            Queue.Enqueue(request);
        }
    }
}